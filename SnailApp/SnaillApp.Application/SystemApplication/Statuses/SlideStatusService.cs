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
using SnailApp.ViewModels.System.Statuses.SlideStatus;

namespace SnailApp.Application.SystemApplication.Statuses
{
    public interface ISlideStatusService
    {
        Task<ApiResult<List<SlideStatusDto>>> GetAll(ManageSlideStatusPagingRequest request);
        Task<PagedResult<SlideStatusDto>> GetManageListPaging(ManageSlideStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(SlideStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<SlideStatusDto>> GetById(int slideStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(SlideStatusRequest request);
    }
    public class SlideStatusService : ISlideStatusService
    {
        private readonly EShopDbContext _context;

        public SlideStatusService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<SlideStatusDto>>> GetAll(ManageSlideStatusPagingRequest request)
        {
            var query = from s in _context.SlideStatuses
                        join st in _context.SlideStatusTranslations on s.Id equals st.SlideStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<SlideStatusDto>>(await query.Select(x => new SlideStatusDto()
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
        public async Task<ApiResult<int>> CreateAsync(SlideStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<SlideStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new SlideStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new SlideStatusTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var slideStatus = new SlideStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                SlideStatusTranslations = translations
            };

            _context.SlideStatuses.Add(slideStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(slideStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var slideStatuses = await _context.SlideStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (slideStatuses == null) throw new EShopException($"Cannot find SlideStatus: {request.Ids.ToString()}");

                List<int> slideStatusIds = slideStatuses.Select(m => m.Id).ToList();
                var slideStatusTranslations = _context.SlideStatusTranslations.Where(m => slideStatusIds.Contains(m.SlideStatusId)).ToList();
                if (slideStatusTranslations != null)
                {
                    _context.SlideStatusTranslations.RemoveRange(slideStatusTranslations);
                }

                _context.SlideStatuses.RemoveRange(slideStatuses);

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

        public async Task<PagedResult<SlideStatusDto>> GetManageListPaging(ManageSlideStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.SlideStatuses
                        join st in _context.SlideStatusTranslations on s.Id equals st.SlideStatusId into sst
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
            var data = await query.Select(x => new SlideStatusDto()
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
            var pagedResult = new PagedResult<SlideStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<SlideStatusDto>> GetById(int slideStatusId, int languageId)
        {
            var slideStatus = await _context.SlideStatuses.FindAsync(slideStatusId);
            var slideStatusTranslation = await _context.SlideStatusTranslations.FirstOrDefaultAsync(x => x.SlideStatusId == slideStatusId
                                                                                            && x.LanguageId == languageId);

            var slideStatusDto = new SlideStatusDto()
            {
                Id = slideStatus.Id,
                CreatedDate = slideStatus.CreatedDate,
                Description = slideStatusTranslation != null ? slideStatusTranslation.Description : string.Empty,
                LanguageId = slideStatusTranslation.LanguageId,
                SortOrder = slideStatus.SortOrder,
                Code = slideStatus.Code,
                Name = slideStatusTranslation != null ? slideStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<SlideStatusDto>(slideStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(SlideStatusRequest request)
        {
            var slideStatus = await _context.SlideStatuses.FindAsync(request.Id);
            var slideStatusTranslations = await _context.SlideStatusTranslations.FirstOrDefaultAsync(x => x.SlideStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (slideStatus == null || slideStatusTranslations == null) throw new EShopException($"Cannot find a slideStatus with id: {request.Id}");

            slideStatusTranslations.Name = request.Name;
            slideStatus.SortOrder = request.SortOrder;
            slideStatus.Code = request.Code;
            slideStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
