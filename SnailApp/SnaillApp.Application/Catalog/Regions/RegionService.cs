using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SnailApp.ViewModels.Catalog.Regions;

namespace SnailApp.Application.Catalog.Regions
{
    public interface IRegionService
    {
        Task<ApiResult<int>> CreateAsync(RegionRequest request);

        Task<ApiResult<int>> UpdateAsync(RegionRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<RegionDto>> GetById(RegionRequest request);

        Task<PagedResult<RegionDto>> GetManageListPaging(ManageRegionPagingRequest request);
    }

    public class RegionService : IRegionService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;

        public RegionService(ClinicDbContext context,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(RegionRequest request)
        {
            try
            {
                var region = _mapper.Map<Region>(request);
                region.CreatedDate = DateTime.Now;
                region.ModifiedDate = DateTime.Now;
                _context.Regions.Add(region);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(region.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(RegionRequest request)
        {
            try
            {
                var check = await _context.Regions.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();
                if (check == null ) throw new EShopException($"Cannot find a region with id: {request.Id}");
                var region = _mapper.Map<Region>(request);
                region.ModifiedDate = DateTime.Now;
                _context.Regions.Update(region);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(region.Id);

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
                var regions = await _context.Regions.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (regions == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

               
                _context.Regions.RemoveRange(regions);

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
        public async Task<PagedResult<RegionDto>> GetManageListPaging(ManageRegionPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from r in _context.Regions
                            where r.Level == request.Level 
                            && (request.ParentId.HasValue ? request.ParentId.Value == r.ParentId.Value : r.Id > 0)
                            select new { r };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.r.Name.Contains(request.TextSearch)
                    || x.r.Code.Contains(request.TextSearch));

                //3.Sort
                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.r.Id) :
                                query.OrderByDescending(x => x.r.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.r.Code) :
                                query.OrderByDescending(x => x.r.Code);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.r.Name) :
                                query.OrderByDescending(x => x.r.Name);

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

                var data = await query.Select(x=> new RegionDto() {
                    Id = x.r.Id,
                    Code = x.r.Code,
                    Name =   x.r.Name,
                    ParentId =   x.r.ParentId,
                }).AsNoTracking().ToListAsync();


                foreach(var item in data.Where(x => x.ParentId.HasValue))
                {
                    item.ParentName =  _context.Regions.FindAsync(item.ParentId.Value).Result.Name;
                }

                //5. Select and projection
                var pagedResult = new PagedResult<RegionDto>()
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
                return  new PagedResult<RegionDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<RegionDto>> GetById(RegionRequest request)
        {
            var region = await _context.Regions.FindAsync(request.Id);
            var regionDto = _mapper.Map<RegionDto>(region);
            return new ApiSuccessResult<RegionDto>(regionDto);
        }
    }
}