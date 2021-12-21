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
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.Catalog.Products;

namespace Snail.Application.Catalog.ProductSKUs
{
    public interface IProductSKUService
    {
        Task<ApiResult<int>> CreateAsync(ProductSKURequest request);

        Task<ApiResult<int>> UpdateAsync(ProductSKURequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<ProductSKUDto>> GetById(int id);

        Task<PagedResult<ProductSKUDto>> GetManageListPaging(ManageProductSKUPagingRequest request);

    }
    public class ProductSKUService : IProductSKUService
    {
        private readonly EShopDbContext _context;

        public ProductSKUService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(ProductSKURequest request)
        {
            var productSKU = new ProductSKU()
            {
                Code = request.Code,
                Name = request.Name,
                ProductId = request.ProductId,
                CreatedUserId = Guid.Parse(request.CreatedUserId),
                ModifiedUserId = Guid.Parse(request.ModifiedUserId)
            };

            _context.ProductSKUs.Add(productSKU);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(productSKU.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(ProductSKURequest request)
        {
            try
            {
                var productSKU = await _context.ProductSKUs.FindAsync(request.Id);

                if (productSKU == null) throw new EShopException($"Cannot find a productSKU with id: {request.Id}");

                productSKU.Code = request.Code;
                productSKU.Name = request.Name;
                productSKU.ProductId = request.ProductId;
                productSKU.ModifiedDate = DateTime.Now;
                productSKU.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(productSKU.Id);
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

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var productSKUs = await _context.ProductSKUs.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (productSKUs == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.ProductSKUs.RemoveRange(productSKUs);

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

        public async Task<PagedResult<ProductSKUDto>> GetManageListPaging(ManageProductSKUPagingRequest request)
        {
            //1. Select join
            var query = from ps in _context.ProductSKUs
                        join p in _context.Products on ps.ProductId equals p.Id
                        select new { ps, p };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.ps.Name.Contains(request.TextSearch) || x.ps.Code.Contains(request.TextSearch));
            }

            if (request.ProductId != null)
            {
                query = query.Where(x => x.p.Id == request.ProductId.Value);
            }                

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.ps.Id) :
                            query.OrderByDescending(x => x.ps.Id);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.ps.Name) :
                            query.OrderByDescending(x => x.ps.Name);

                        break;

                    default: break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
            }


            var data = await query.Select(x => new ProductSKUDto()
            {
                Id = x.ps.Id,
                Code = x.ps.Code,
                Name = x.ps.Name,
                Price = x.ps.Price,
                BuyingPrice = x.ps.BuyingPrice,
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ProductSKUDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<ProductSKUDto>> GetById(int id)
        {
            var data = await _context.ProductSKUs.FindAsync(id);

            return new ApiSuccessResult<ProductSKUDto>(new ProductSKUDto() { Id = data.Id });
        }
    }
}