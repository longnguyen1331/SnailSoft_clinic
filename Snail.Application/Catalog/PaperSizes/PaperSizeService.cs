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
using Snail.ViewModels.Catalog.PaperSizes;

namespace Snail.Application.Catalog.PaperSizes
{
    public interface IPaperSizeService
    {
        Task<ApiResult<int>> CreateAsync(PaperSizeRequest request);

        Task<ApiResult<int>> UpdateAsync(PaperSizeRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<PaperSizeDto>> GetById(int id);

        Task<PagedResult<PaperSizeDto>> GetManageListPaging(ManagePaperSizePagingRequest request);
    }
    public class PaperSizeService : IPaperSizeService
    {
        private readonly EShopDbContext _context;

        public PaperSizeService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(PaperSizeRequest request)
        {
            var paperSize = new PaperSize()
            {
                Name = request.Name,
                Value = request.Value,
                CreatedDate = DateTime.Now
            };

            _context.PaperSizes.Add(paperSize);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(paperSize.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(PaperSizeRequest request)
        {
            try
            {
                var paperSize = await _context.PaperSizes.FindAsync(request.Id);

                if (paperSize == null) throw new EShopException($"Cannot find a paperSize with id: {request.Id}");

                paperSize.Name = request.Name;
                paperSize.Value = request.Value;
                paperSize.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(paperSize.Id);

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
                var paperSizes = await _context.PaperSizes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (paperSizes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.PaperSizes.RemoveRange(paperSizes);

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

        public async Task<PagedResult<PaperSizeDto>> GetManageListPaging(ManagePaperSizePagingRequest request)
        {
            //1. Select join
            var query = from p in _context.PaperSizes
                        select new { p };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.p.Name.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.p.Id) :
                            query.OrderByDescending(x => x.p.Id);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.p.Name) :
                            query.OrderByDescending(x => x.p.Name);

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


            var data = await query.Select(x => new PaperSizeDto() {
                Id = x.p.Id,
                Name = x.p.Name,
                Value = x.p.Value
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<PaperSizeDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<PaperSizeDto>> GetById(int id)
        {
            var data = await _context.PaperSizes.FindAsync(id);

            return new ApiSuccessResult<PaperSizeDto>(new PaperSizeDto() { Id = data.Id });
        }
    }
}