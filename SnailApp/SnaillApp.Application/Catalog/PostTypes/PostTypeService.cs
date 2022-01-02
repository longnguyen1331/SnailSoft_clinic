using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.PostTypes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BHSNetCoreLib;

namespace SnailApp.Application.Catalog.PostTypes
{
    public interface IPostTypeService
    {
        Task<ApiResult<List<PostTypeDto>>> GetAll(ManagePostTypePagingRequest request);
        Task<PagedResult<PostTypeDto>> GetManageListPaging(ManagePostTypePagingRequest request);
        Task<ApiResult<int>> CreateAsync(PostTypeRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PostTypeDto>> GetById(PostTypeRequest request);
        Task<ApiResult<int>> UpdateAsync(PostTypeRequest request);
    }
    public class PostTypeService : IPostTypeService
    {
        private readonly EShopDbContext _context;

        public PostTypeService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<PostTypeDto>>> GetAll(ManagePostTypePagingRequest request)
        {
            var query = from p in _context.PostTypes
                        join pt in _context.PostTypeTranslations on p.Id equals pt.PostTypeId
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));
            }                

            return new ApiSuccessResult<List<PostTypeDto>>( await query.Select(x => new PostTypeDto()
            {
                Id = x.p.Id,
                Name = x.pt.Name
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(PostTypeRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<PostTypeTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new PostTypeTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId,
                        SeoDescription = request.SeoDescription,
                        SeoTitle = request.Name,
                        SeoAlias = StringUtil.ToUrlFormat(request.Name),
                    });
                }
                else
                {
                    translations.Add(new PostTypeTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        SeoDescription = SystemConstants.AppConstants.NA,
                        SeoAlias = SystemConstants.AppConstants.NA,
                        SeoTitle = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var postType = new PostType()
            {
                PostTypeTranslations = translations,
                //PostTypeStatusId = request.PostTypeStatusId
            };

            _context.PostTypes.Add(postType);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(postType.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var postTypes = await _context.PostTypes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (postTypes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> postTypeIds = postTypes.Select(m => m.Id).ToList();
                var postTypeTranslations = _context.PostTypeTranslations.Where(m => postTypeIds.Contains(m.PostTypeId)).ToList();
                if (postTypeTranslations != null)
                {
                    _context.PostTypeTranslations.RemoveRange(postTypeTranslations);
                }

                _context.PostTypes.RemoveRange(postTypes);

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

        public async Task<PagedResult<PostTypeDto>> GetManageListPaging(ManagePostTypePagingRequest request)
        {
            //1. Select join
            var query = from p in _context.PostTypes
                        join pt in _context.PostTypeTranslations on p.Id equals pt.PostTypeId into ppt
                        from pt in ppt.DefaultIfEmpty()
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if(request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new PostTypeDto()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    CreatedDate = x.p.CreatedDate,
                    LanguageId = x.pt.LanguageId
                }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<PostTypeDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<PostTypeDto>> GetById(PostTypeRequest request)
        {
            var postType = await _context.PostTypes.FindAsync(request.Id);
            var postTypeTranslation = await _context.PostTypeTranslations.FirstOrDefaultAsync(x => x.PostTypeId == request.Id
                                                                                                && x.LanguageId == request.LanguageId);

            var postTypeDto = new PostTypeDto()
            {
                Id = postType.Id,
                CreatedDate = postType.CreatedDate,
                LanguageId = postTypeTranslation.LanguageId,
                Name = postTypeTranslation != null ? postTypeTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<PostTypeDto>(postTypeDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(PostTypeRequest request)
        {
            var postType = await _context.PostTypes.FindAsync(request.Id);
            var postTypeTranslations = await _context.PostTypeTranslations.FirstOrDefaultAsync(x => x.PostTypeId == request.Id
            && x.LanguageId == request.LanguageId);

            if (postType == null || postTypeTranslations == null) throw new EShopException($"Cannot find a postType with id: {request.Id}");

            postTypeTranslations.Name = request.Name;
            postTypeTranslations.SeoAlias = StringUtil.ToUrlFormat(request.Name);
            postTypeTranslations.SeoDescription = request.SeoDescription;
            postTypeTranslations.SeoTitle = request.SeoTitle;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}