using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
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
using SnailApp.ViewModels.Sales.Carts;

namespace SnailApp.Application.Sales.Carts
{
    public interface ICartService
    {
        Task<ApiResult<int>> CreateAsync(CartRequest request);

        Task<ApiResult<int>> UpdateAsync(CartRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<CartDto>> GetById(int id);

        Task<PagedResult<CartDto>> GetManageListPaging(ManageCartPagingRequest request);
    }
    public class CartService : ICartService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public CartService(EShopDbContext context, IFileStorageService storageService,
                                IConfiguration configuration)
        {
            _context = context;
            _storageService = storageService;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(CartRequest request)
        {
            var cart = new Cart()
            {
                Code = request.Code,
                Name = request.Name,
                CreatedDate = DateTime.Now
            };

            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(cart.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(CartRequest request)
        {
            try
            {
                var cart = await _context.Carts.FindAsync(request.Id);

                if (cart == null) throw new EShopException($"Cannot find a cart with id: {request.Id}");

                cart.Code = request.Code;
                cart.Name = request.Name;
                cart.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(cart.Id);

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
                var carts = await _context.Carts.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (carts == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Carts.RemoveRange(carts);

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

        public async Task<PagedResult<CartDto>> GetManageListPaging(ManageCartPagingRequest request)
        {
            //1. Select join
            var query = from c in _context.Carts
                        select new { c };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.c.Name.Contains(request.TextSearch)
                || x.c.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.c.Id) :
                            query.OrderByDescending(x => x.c.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.c.Code) :
                            query.OrderByDescending(x => x.c.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.c.Name) :
                            query.OrderByDescending(x => x.c.Name);

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

            var data = await query.Select(x => new CartDto()
            {
                Id = x.c.Id,
                Code = x.c.Code,
                Name = x.c.Name
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<CartDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<CartDto>> GetById(int id)
        {
            var cart = await _context.Carts.FindAsync(id);

            var cartDto = new CartDto()
            {
                Id = cart.Id,
                Code = cart.Code,
                Name = cart.Name
            };
            return new ApiSuccessResult<CartDto>(cartDto);
        }
    }

}
