using Snail.Application.Common;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Snail.ViewModels.Sales.Promotion_ProductSKUs;
using Snail.ViewModels.Catalog.Products;
using Snail.ViewModels.Catalog.ProductSKUs;

namespace Snail.Application.Sales.Promotion_ProductSKUs
{
    public interface IPromotion_ProductSKUService
    {
        Task<PagedResult<Promotion_ProductSKUDto>> GetManageListPaging(ManagePromotion_ProductSKUPagingRequest request);
        Task<ApiResult<int>> CreateAsync(Promotion_ProductSKURequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<Promotion_ProductSKUDto>> GetById(Promotion_ProductSKURequest request);
        Task<ApiResult<int>> UpdateAsync(Promotion_ProductSKURequest request);
    }
    public class Promotion_ProductSKUService : IPromotion_ProductSKUService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public Promotion_ProductSKUService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(Promotion_ProductSKURequest request)
        {
            try
            {
                var promotion_ProductSKU = new Promotion_ProductSKU()
                {
                    PromotionId = request.PromotionId,
                    ProductSKUId = request.ProductSKUId,
                    Discount = request.Discount,
                    DiscountPercent = request.DiscountPercent,
                    Commission = request.Commission,
                    CommissionPercent = request.CommissionPercent
                };

                _context.Promotion_ProductSKUs.Add(promotion_ProductSKU);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(promotion_ProductSKU.Id);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var promotion_ProductSKUs = await _context.Promotion_ProductSKUs.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (promotion_ProductSKUs == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Promotion_ProductSKUs.RemoveRange(promotion_ProductSKUs);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<Promotion_ProductSKUDto>> GetManageListPaging(ManagePromotion_ProductSKUPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from p_ps in _context.Promotion_ProductSKUs
                            join ps in _context.ProductSKUs on p_ps.ProductSKUId equals ps.Id
                                join p in _context.Products on ps.ProductId equals p.Id
                                join pt in _context.ProductTranslations on p.Id equals pt.ProductId into p_pt
                                    from pt in p_pt.DefaultIfEmpty()
                            where pt.LanguageId == request.LanguageId
                            select new { p_ps, ps, p, pt };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                {
                    query = query.Where(x => x.ps.Name.Contains(request.TextSearch));
                }

                if (request.PromotionId != null)
                {
                    query = query.Where(x => x.p_ps.PromotionId == request.PromotionId);
                }

                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
                }
                var data = await query.Select(x => new Promotion_ProductSKUDto()
                {
                    Id = x.p_ps.Id,
                    Product = new ProductDto() { 
                        Id = x.p.Id,
                        Name = x.pt.Name
                    },
                    ProductSKUId = x.ps.Id,
                    ProductSKUCode = x.ps.Code,
                    ProductSKUName = x.ps.Name,
                    Discount = x.p_ps.Discount,
                    DiscountPercent = x.p_ps.DiscountPercent,
                    Commission = x.p_ps.Commission,
                    CommissionPercent = x.p_ps.CommissionPercent
                }).AsNoTracking().ToListAsync();

                //4. Select and projection
                var pagedResult = new PagedResult<Promotion_ProductSKUDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };

                return pagedResult;
            }
            catch (Exception ex)
            {
                return new PagedResult<Promotion_ProductSKUDto>()
                {
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<Promotion_ProductSKUDto>> GetById(Promotion_ProductSKURequest request)
        {
            try
            {
                var promotion_ProductSKU = await (from p_cd in _context.Promotion_ProductSKUs
                                                    join cd in _context.ProductSKUs on p_cd.ProductSKUId equals cd.Id
                                                    where p_cd.Id == request.Id
                                                    select new Promotion_ProductSKUDto()
                                                    {
                                                        Id = p_cd.Id,
                                                        ProductSKU = new ProductSKUDto()
                                                        {
                                                            Id = cd.Id,
                                                            Code = cd.Code,
                                                            Name = cd.Name
                                                        },
                                                        Discount = p_cd.Discount,
                                                        DiscountPercent = p_cd.DiscountPercent,
                                                        Commission = p_cd.Commission,
                                                        CommissionPercent = p_cd.CommissionPercent
                                                    }).AsNoTracking().FirstOrDefaultAsync();

                if (promotion_ProductSKU == null)
                {
                    return new ApiErrorResult<Promotion_ProductSKUDto>("Không tồn tại.");
                }

                return new ApiSuccessResult<Promotion_ProductSKUDto>(promotion_ProductSKU);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<Promotion_ProductSKUDto>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> UpdateAsync(Promotion_ProductSKURequest request)
        {
            try
            {
                var promotion_ProductSKU = await _context.Promotion_ProductSKUs.FindAsync(request.Id);

                if (promotion_ProductSKU == null) throw new EShopException($"Cannot find a promotion_ProductSKU with id: {request.Id}");

                promotion_ProductSKU.PromotionId = request.PromotionId;
                promotion_ProductSKU.ProductSKUId = request.ProductSKUId;
                promotion_ProductSKU.Discount = request.Discount;
                promotion_ProductSKU.DiscountPercent = request.DiscountPercent;
                promotion_ProductSKU.Commission = request.Commission;
                promotion_ProductSKU.CommissionPercent = request.CommissionPercent;
                
                _context.Promotion_ProductSKUs.Update(promotion_ProductSKU);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
    }
}

