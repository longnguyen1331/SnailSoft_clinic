using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.System.Statuses.PostStatus;

namespace SnailApp.Application.SystemApplication.Statuses
{
    public interface IPostStatusService
    {
        Task<ApiResult<List<PostStatusDto>>> GetAll(ManagePostStatusPagingRequest request);
        Task<PagedResult<PostStatusDto>> GetManageListPaging(ManagePostStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(PostStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PostStatusDto>> GetById(int postStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(PostStatusRequest request);
    }
    public class PostStatusService : IPostStatusService
    {
        private readonly EShopDbContext _context;

        public PostStatusService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<PostStatusDto>>> GetAll(ManagePostStatusPagingRequest request)
        {
            var query = from s in _context.PostStatuses
                        join st in _context.PostStatusTranslations on s.Id equals st.PostStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<PostStatusDto>>(await query.Select(x => new PostStatusDto()
            {
                Id = x.s.Id,
                SortOrder = x.s.SortOrder,
                Code = x.s.Code,
                Name = x.st.Name,
                CreatedDate = x.s.CreatedDate,
                Description = x.st.Description,
                LanguageId = x.st.LanguageId
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(PostStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<PostStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new PostStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new PostStatusTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var postStatus = new PostStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                PostStatusTranslations = translations
            };

            _context.PostStatuses.Add(postStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(postStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var postStatuses = await _context.PostStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (postStatuses == null) throw new EShopException($"Cannot find PostStatus: {request.Ids.ToString()}");

                List<int> postStatusIds = postStatuses.Select(m => m.Id).ToList();
                var postStatusTranslations = _context.PostStatusTranslations.Where(m => postStatusIds.Contains(m.PostStatusId)).ToList();
                if (postStatusTranslations != null)
                {
                    _context.PostStatusTranslations.RemoveRange(postStatusTranslations);
                }

                _context.PostStatuses.RemoveRange(postStatuses);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<PagedResult<PostStatusDto>> GetManageListPaging(ManagePostStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.PostStatuses
                        join st in _context.PostStatusTranslations on s.Id equals st.PostStatusId into sst
                        from st in sst.DefaultIfEmpty()
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.st.Name.Contains(request.TextSearch));
            }

            //3.Sort
            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.s.Id) :
                            query.OrderByDescending(x => x.s.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.s.Code) :
                            query.OrderByDescending(x => x.s.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

                        break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new PostStatusDto()
            {
                Id = x.s.Id,
                SortOrder = x.s.SortOrder,
                Code = x.s.Code,
                Name = x.st.Name,
                CreatedDate = x.s.CreatedDate,
                Description = x.st.Description,
                LanguageId = x.st.LanguageId
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<PostStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<PostStatusDto>> GetById(int postStatusId, int languageId)
        {
            var postStatus = await _context.PostStatuses.FindAsync(postStatusId);
            var postStatusTranslation = await _context.PostStatusTranslations.FirstOrDefaultAsync(x => x.PostStatusId == postStatusId
                                                                                            && x.LanguageId == languageId);

            var postStatusDto = new PostStatusDto()
            {
                Id = postStatus.Id,
                CreatedDate = postStatus.CreatedDate,
                Description = postStatusTranslation != null ? postStatusTranslation.Description : string.Empty,
                LanguageId = postStatusTranslation.LanguageId,
                SortOrder = postStatus.SortOrder,
                Code = postStatus.Code,
                Name = postStatusTranslation != null ? postStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<PostStatusDto>(postStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(PostStatusRequest request)
        {
            var postStatus = await _context.PostStatuses.FindAsync(request.Id);
            var postStatusTranslations = await _context.PostStatusTranslations.FirstOrDefaultAsync(x => x.PostStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (postStatus == null || postStatusTranslations == null) throw new EShopException($"Cannot find a postStatus with id: {request.Id}");

            postStatusTranslations.Name = request.Name;
            postStatus.SortOrder = request.SortOrder;
            postStatus.Code = request.Code;
            postStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
