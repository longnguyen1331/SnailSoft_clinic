using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Catalog.ProductTypes;
using SnailApp.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BHSNetCoreLib;

namespace SnailApp.Application.Catalog.ProductTypes
{
    public interface IProductTypeService
    {
        Task<ApiResult<List<ProductTypeDto>>> GetAll(ManageProductTypePagingRequest request);
        Task<PagedResult<ProductTypeDto>> GetManageListPaging(ManageProductTypePagingRequest request);
        Task<ApiResult<int>> CreateAsync(ProductTypeRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ProductTypeDto>> GetById(int productTypeId, int languageId);
        Task<ApiResult<int>> UpdateAsync(ProductTypeRequest request);
    }
    public class ProductTypeService : IProductTypeService
    {
        private readonly ClinicDbContext _context;

        public ProductTypeService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<ProductTypeDto>>> GetAll(ManageProductTypePagingRequest request)
        {
            var query = from p in _context.ProductTypes
                        join pt in _context.ProductTypeTranslations on p.Id equals pt.ProductTypeId
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };

            var list = await query.AsNoTracking().OrderBy(x => x.p.ParentId).Select(x => new ProductTypeDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name,
                SortOrder = x.p.SortOrder,
                ParentId = x.p.ParentId
            }).ToListAsync();

            var translates = await query.Select(x => x.pt).ToListAsync();
            List<ProductTypeDto> data = new List<ProductTypeDto>();

            DeQuiDanhMuc(list, translates, null, ref data, "");

            return new ApiSuccessResult<List<ProductTypeDto>>(data);
        }
        public async Task<ApiResult<int>> CreateAsync(ProductTypeRequest request)
        {
            try
            {
                var languages = _context.Languages;
                var translations = new List<ProductTypeTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new ProductTypeTranslation()
                        {
                            Name = request.Name,
                            SeoAlias = StringUtil.ToUrlFormat(request.Name),
                            SeoDescription = request.Name,
                            SeoTitle = request.Name,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new ProductTypeTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            SeoAlias = StringUtil.ToUrlFormat(request.Name),
                            SeoDescription = request.Name,
                            SeoTitle = request.Name,
                            LanguageId = language.Id
                        });
                    }
                }

                var productType = new ProductType()
                {
                    ProductTypeTranslations = translations,
                    Store = await _context.Stores.FindAsync(request.StoreId),
                    ParentId = request.ParentId > 0 ? request.ParentId : null,
                    SortOrder = request.SortOrder,
                    CreatedUserId = request.CreatedUserId,
                    ModifiedUserId = request.CreatedUserId,
                    CreatedDate = DateTime.Now
                };

                _context.ProductTypes.Add(productType);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(productType.Id);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<int>() {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
            
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var productTypes = await _context.ProductTypes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (productTypes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> productTypeIds = productTypes.Select(m => m.Id).ToList();
                var productTypeTranslations = _context.ProductTypeTranslations.Where(m => productTypeIds.Contains(m.ProductTypeId)).ToList();
                if (productTypeTranslations != null)
                {
                    _context.ProductTypeTranslations.RemoveRange(productTypeTranslations);
                }

                _context.ProductTypes.RemoveRange(productTypes);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<PagedResult<ProductTypeDto>> GetManageListPaging(ManageProductTypePagingRequest request)
        {
            //1. Select join
            var query = from p in _context.ProductTypes.AsNoTracking()
                        join pt in _context.ProductTypeTranslations.AsNoTracking() on p.Id equals pt.ProductTypeId into ppt
                        from pt in ppt.DefaultIfEmpty()
                        join s in _context.Stores.AsNoTracking() on p.Store.Id equals s.Id into st
                        from s in st.DefaultIfEmpty()
                        where pt.LanguageId == request.LanguageId && s.Id == request.StoreId
                        select new { p, pt};
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }

            
            var list = await query.AsNoTracking().OrderBy(x=>x.p.ParentId).Select(x => new ProductTypeDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name,
                SortOrder = x.p.SortOrder,
                ParentId = x.p.ParentId
            }).ToListAsync();
            var translates = await query.Select(x => x.pt).ToListAsync();

            List<ProductTypeDto> data = new List<ProductTypeDto>();
            DeQuiDanhMuc(list, translates, null, ref data, "");

            //4. Select and projection
            var pagedResult = new PagedResult<ProductTypeDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<ProductTypeDto>> GetById(int productTypeId, int languageId)
        {
            var productType = await _context.ProductTypes.FindAsync(productTypeId);
            var productTypeTranslation = await _context.ProductTypeTranslations.FirstOrDefaultAsync(x => x.ProductTypeId == productTypeId
                                                                                                            && x.LanguageId == languageId);

            var productTypeDto = new ProductTypeDto()
            {
                Id = productType.Id,
                CreatedDate = productType.CreatedDate,
                LanguageId = productTypeTranslation.LanguageId,
                Name = productTypeTranslation != null ? productTypeTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<ProductTypeDto>(productTypeDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(ProductTypeRequest request)
        {
            var productType = await _context.ProductTypes.FindAsync(request.Id);
            var productTypeTranslations = await _context.ProductTypeTranslations.FirstOrDefaultAsync(x => x.ProductTypeId == request.Id
            && x.LanguageId == request.LanguageId);

            if (productType == null || productTypeTranslations == null) throw new EShopException($"Cannot find a productType with id: {request.Id}");

            productTypeTranslations.Name = request.Name;
            productTypeTranslations.SeoAlias = StringUtil.ToUrlFormat(request.Name);
            productTypeTranslations.SeoDescription = request.Name;
            productTypeTranslations.SeoTitle = request.Name;


            productType.SortOrder = request.SortOrder;
            productType.ParentId = request.ParentId > 0 ? request.ParentId : null;
            productType.ModifiedUserId = request.ModifiedUserId;
            productType.ModifiedDate = DateTime.Now;

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }


        private static void DeQuiDanhMuc(List<ProductTypeDto> danhMucs,
            List<ProductTypeTranslation> trans,
            int? danhMucCapTrenId, ref List<ProductTypeDto> result, string prefixName = "")
        {
            
            foreach (var item in danhMucs.Where(m => m.ParentId == danhMucCapTrenId).OrderBy(m => m.SortOrder))
            {
                var datas = danhMucs.Where(m => m.ParentId == item.Id);

                var currentPrefix = "---" + prefixName;

                item.Name = string.IsNullOrEmpty(prefixName) ? item.Name : currentPrefix + item.Name;
                item.ParentName = item.ParentId != null ? trans.FirstOrDefault(x =>x.ProductTypeId == item.ParentId.Value).Name : string.Empty;
                result.Add(item);
                if (datas.Count() > 0)
                {
                    DeQuiDanhMuc(danhMucs.ToList(), trans, item.Id, ref result, currentPrefix);
                }
            }
        }
    }
}