using SnailApp.Utilities.Exceptions;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Countries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SnailApp.Application.Catalog.Countries
{
    public interface ICountryService
    {
        Task<ApiResult<int>> AddOrUpdateAsync(CountryRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<CountryDto>> GetById(CountryRequest request);
        Task<PagedResult<CountryDto>> GetManageListPaging(ManageCountryPagingRequest request);
    }
    public class CountryService : ICountryService
    {
        private readonly EShopDbContext _context;

        public CountryService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(CountryRequest request)
        {
            try
            {
                bool isNew = (request.Id == null);
                Country country = null;

                if (isNew == true)
                {
                    country = new Country()
                    {
                        CreatedUserId = Guid.Parse(request.CreatedUserId)
                    };
                }
                else
                {
                    country = await _context.Countries.FindAsync(request.Id);

                    if (country == null) throw new EShopException($"Cannot find a Country with id: {request.Id}");
                }

                country.Code = request.Code;
                country.Name = request.Name;
                country.ModifiedDate = DateTime.Now;

                if (isNew == true)
                {
                    _context.Countries.Add(country);
                }
                else
                {
                    _context.Countries.Update(country);
                }

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(country.Id);
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
                var countrys = await _context.Countries.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (countrys == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Countries.RemoveRange(countrys);

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
        public async Task<PagedResult<CountryDto>> GetManageListPaging(ManageCountryPagingRequest request)

        {
            //1. Select join
            var query = from c in _context.Countries
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

            var data = await query.Select(x => new CountryDto()
            {
                Id = x.c.Id,
                Code = x.c.Code,
                Name = x.c.Name
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<CountryDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<CountryDto>> GetById(CountryRequest request)
        {
            var country = await _context.Countries.FindAsync(request.Id);



            var countryDto = new CountryDto()
            {
                Id = country.Id,
                CreatedDate = country.CreatedDate,
                Code = country.Code,
                Name = country.Name
            };

            return new ApiSuccessResult<CountryDto>(countryDto);
        }
    }
}
