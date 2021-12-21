using Snail.Application.Common;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
using Snail.ViewModels.Enums;
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
using Snail.ViewModels.System.Statuses.ProductTypeStatus;

namespace Snail.Application.SystemApplication.Statuses
{
    public interface IProductTypeStatusService
    {
        Task<ApiResult<List<ProductTypeStatusDto>>> GetAll(ManageProductTypeStatusPagingRequest request);
        Task<PagedResult<ProductTypeStatusDto>> GetManageListPaging(ManageProductTypeStatusPagingRequest request);
        Task<ApiResult<int>> CreateAsync(ProductTypeStatusRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ProductTypeStatusDto>> GetById(int productTypeStatusId, int languageId);
        Task<ApiResult<int>> UpdateAsync(ProductTypeStatusRequest request);
    }
    public class ProductTypeStatusService : IProductTypeStatusService
    {
        private readonly EShopDbContext _context;

        public ProductTypeStatusService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<ProductTypeStatusDto>>> GetAll(ManageProductTypeStatusPagingRequest request)
        {
            var query = from s in _context.ProductTypeStatuses
                        join st in _context.ProductTypeStatusTranslations on s.Id equals st.ProductTypeStatusId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.s.Code.Contains(request.TextSearch)
                                    || x.st.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<ProductTypeStatusDto>>(await query.Select(x => new ProductTypeStatusDto()
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
        public async Task<ApiResult<int>> CreateAsync(ProductTypeStatusRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<ProductTypeStatusTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new ProductTypeStatusTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new ProductTypeStatusTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var productTypeStatus = new ProductTypeStatus()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                ProductTypeStatusTranslations = translations
            };

            _context.ProductTypeStatuses.Add(productTypeStatus);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(productTypeStatus.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var productTypeStatuses = await _context.ProductTypeStatuses.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (productTypeStatuses == null) throw new EShopException($"Cannot find ProductTypeStatus: {request.Ids.ToString()}");

                List<int> productTypeStatusIds = productTypeStatuses.Select(m => m.Id).ToList();
                var productTypeStatusTranslations = _context.ProductTypeStatusTranslations.Where(m => productTypeStatusIds.Contains(m.ProductTypeStatusId)).ToList();
                if (productTypeStatusTranslations != null)
                {
                    _context.ProductTypeStatusTranslations.RemoveRange(productTypeStatusTranslations);
                }

                _context.ProductTypeStatuses.RemoveRange(productTypeStatuses);

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

        public async Task<PagedResult<ProductTypeStatusDto>> GetManageListPaging(ManageProductTypeStatusPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.ProductTypeStatuses
                        join st in _context.ProductTypeStatusTranslations on s.Id equals st.ProductTypeStatusId into sst
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
            var data = await query.Select(x => new ProductTypeStatusDto()
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
            var pagedResult = new PagedResult<ProductTypeStatusDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<ProductTypeStatusDto>> GetById(int productTypeStatusId, int languageId)
        {
            var productTypeStatus = await _context.ProductTypeStatuses.FindAsync(productTypeStatusId);
            var productTypeStatusTranslation = await _context.ProductTypeStatusTranslations.FirstOrDefaultAsync(x => x.ProductTypeStatusId == productTypeStatusId
                                                                                            && x.LanguageId == languageId);

            var productTypeStatusDto = new ProductTypeStatusDto()
            {
                Id = productTypeStatus.Id,
                CreatedDate = productTypeStatus.CreatedDate,
                Description = productTypeStatusTranslation != null ? productTypeStatusTranslation.Description : string.Empty,
                LanguageId = productTypeStatusTranslation.LanguageId,
                SortOrder = productTypeStatus.SortOrder,
                Code = productTypeStatus.Code,
                Name = productTypeStatusTranslation != null ? productTypeStatusTranslation.Name : string.Empty
            };

            return new ApiSuccessResult<ProductTypeStatusDto>(productTypeStatusDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(ProductTypeStatusRequest request)
        {
            var productTypeStatus = await _context.ProductTypeStatuses.FindAsync(request.Id);
            var productTypeStatusTranslations = await _context.ProductTypeStatusTranslations.FirstOrDefaultAsync(x => x.ProductTypeStatusId == request.Id
            && x.LanguageId == request.LanguageId);

            if (productTypeStatus == null || productTypeStatusTranslations == null) throw new EShopException($"Cannot find a productTypeStatus with id: {request.Id}");

            productTypeStatusTranslations.Name = request.Name;
            productTypeStatus.SortOrder = request.SortOrder;
            productTypeStatus.Code = request.Code;
            productTypeStatus.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
