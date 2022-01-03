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
using SnailApp.ViewModels.System.Statuses.PostTypeStatus;

namespace SnailApp.Application.SystemApplication.Statuses
{
    public interface IPostTypeStatusService
    {
        Task<ApiResult<List<PostTypeStatusDto>>> GetAll(ManagePostTypeStatusPagingRequest request);
        Task<PagedResult<PostTypeStatusDto>> GetManageListPaging(ManagePostTypeStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(PostTypeStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PostTypeStatusDto>> GetById(int postTypeStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(PostTypeStatusRequest request);
    }
    public class PostTypeStatusService : IPostTypeStatusService
    {
        private readonly ClinicDbContext _context;

        public PostTypeStatusService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<PostTypeStatusDto>>> GetAll(ManagePostTypeStatusPagingRequest request)
        {
            var query = from s in _context.PostTypeStatuses
                        join st in _context.PostTypeStatusTranslations on s.Id equals st.PostTypeStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<PostTypeStatusDto>>(await query.Select(x => new PostTypeStatusDto()
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
        public async Task<ApiResult<int>> CreateAsync(PostTypeStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<PostTypeStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new PostTypeStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new PostTypeStatusTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var postTypeStatus = new PostTypeStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                PostTypeStatusTranslations = translations,
            };

            _context.PostTypeStatuses.Add(postTypeStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(postTypeStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var postTypeStatuses = await _context.PostTypeStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (postTypeStatuses == null) throw new EShopException($"Cannot find PostTypeStatus: {request.Ids.ToString()}");

                List<int> postTypeStatusIds = postTypeStatuses.Select(m => m.Id).ToList();
                var postTypeStatusTranslations = _context.PostTypeStatusTranslations.Where(m => postTypeStatusIds.Contains(m.PostTypeStatusId)).ToList();
                if (postTypeStatusTranslations != null)
                {
                    _context.PostTypeStatusTranslations.RemoveRange(postTypeStatusTranslations);
                }

                _context.PostTypeStatuses.RemoveRange(postTypeStatuses);

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

        public async Task<PagedResult<PostTypeStatusDto>> GetManageListPaging(ManagePostTypeStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.PostTypeStatuses
                        join st in _context.PostTypeStatusTranslations on s.Id equals st.PostTypeStatusId into sst
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
            var data = await query.Select(x => new PostTypeStatusDto()
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
            var pagedResult = new PagedResult<PostTypeStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<PostTypeStatusDto>> GetById(int postTypeStatusId, int languageId)
        {
            var postTypeStatus = await _context.PostTypeStatuses.FindAsync(postTypeStatusId);
            var postTypeStatusTranslation = await _context.PostTypeStatusTranslations.FirstOrDefaultAsync(x => x.PostTypeStatusId == postTypeStatusId
                                                                                            && x.LanguageId == languageId);

            var postTypeStatusDto = new PostTypeStatusDto()
            {
                Id = postTypeStatus.Id,
                CreatedDate = postTypeStatus.CreatedDate,
                Description = postTypeStatusTranslation != null ? postTypeStatusTranslation.Description : string.Empty,
                LanguageId = postTypeStatusTranslation.LanguageId,
                SortOrder = postTypeStatus.SortOrder,
                Code = postTypeStatus.Code,
                Name = postTypeStatusTranslation != null ? postTypeStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<PostTypeStatusDto>(postTypeStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(PostTypeStatusRequest request)
        {
            var postTypeStatus = await _context.PostTypeStatuses.FindAsync(request.Id);
            var postTypeStatusTranslations = await _context.PostTypeStatusTranslations.FirstOrDefaultAsync(x => x.PostTypeStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (postTypeStatus == null || postTypeStatusTranslations == null) throw new EShopException($"Cannot find a postTypeStatus with id: {request.Id}");

            postTypeStatusTranslations.Name = request.Name;
            postTypeStatus.SortOrder = request.SortOrder;
            postTypeStatus.Code = request.Code;
            postTypeStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
