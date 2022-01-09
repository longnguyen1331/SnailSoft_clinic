using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace SnailApp.Application.Catalog.Clinics
{
    public interface IBloodService
    {
        Task<ApiResult<int>> CreateAsync(BaseRequest request);

        Task<ApiResult<int>> UpdateAsync(BaseRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<BaseDto>> GetById(BaseRequest request);

        Task<PagedResult<BaseDto>> GetManageListPaging(PagingRequestBase request);
    }

    public class BloodService : IBloodService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;

        public BloodService(ClinicDbContext context,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(BaseRequest request)
        {
            try
            {
                var blood = _mapper.Map<Blood>(request);
                blood.CreatedDate = DateTime.Now;
                blood.ModifiedDate = DateTime.Now;
                _context.Bloods.Add(blood);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(blood.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(BaseRequest request)
        {
            try
            {
                var check = await _context.Bloods.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();
                if (check == null ) throw new EShopException($"Cannot find a blood with id: {request.Id}");
                var blood = _mapper.Map<Blood>(request);
                blood.ModifiedDate = DateTime.Now;
                _context.Bloods.Update(blood);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(blood.Id);

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
                var bloods = await _context.Bloods.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (bloods == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

               
                _context.Bloods.RemoveRange(bloods);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch(Exception ex)
            {
                return new ApiResult<int>(){
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
        public async Task<PagedResult<BaseDto>> GetManageListPaging(PagingRequestBase request)
        {
            try
            {
                //1. Select join
                var query = _context.Bloods.AsQueryable().AsNoTracking();

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.Name.Contains(request.TextSearch)
                    || x.Code.Contains(request.TextSearch));

                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.Id) :
                                query.OrderByDescending(x => x.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.Code) :
                                query.OrderByDescending(x => x.Code);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.Name) :
                                query.OrderByDescending(x => x.Name);

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

                var data = await query.Select(x=> new BaseDto() {
                    Id = x.Id,
                    Code = x.Code,
                    Name =   x.Name,
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<BaseDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
            }
            catch(Exception ex)
            {
                return  new PagedResult<BaseDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<BaseDto>> GetById(BaseRequest request)
        {
            var blood = await _context.Bloods.FindAsync(request.Id);
            var bloodDto = _mapper.Map<BaseDto>(blood);
            return new ApiSuccessResult<BaseDto>(bloodDto);
        }
    }
}