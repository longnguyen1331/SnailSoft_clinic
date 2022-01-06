using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Clinics;
using AutoMapper;

namespace SnailApp.Application.Catalog.Clinics
{
    public interface IClinicService
    {
        Task<ApiResult<int>> CreateAsync(ClinicRequest request);

        Task<ApiResult<int>> UpdateAsync(ClinicRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<ClinicDto>> GetById(ClinicRequest request);

        Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request);
    }

    public class ClinicService : IClinicService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;

        public ClinicService(ClinicDbContext context,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(ClinicRequest request)
        {
            try
            {
                var clinic = _mapper.Map<Clinic>(request);
                _context.Clinics.Add(clinic);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(clinic.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(ClinicRequest request)
        {
            try
            {
                var clinic = await _context.Clinics.FindAsync(request.Id);

                if (clinic == null ) throw new EShopException($"Cannot find a product with id: {request.Id}");

                clinic = _mapper.Map<Clinic>(request);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(clinic.Id);

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
                var clinics = await _context.Clinics.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (clinics == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                var clinicIds = clinics.Select(m => m.Id).ToList();
                _context.Clinics.RemoveRange(clinics);

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
        public async Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request)
        {
            try
            {
                //1. Select join
                var query = _context.Clinics.AsQueryable().AsNoTracking();

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.Name.Contains(request.TextSearch)
                    || x.Code.Contains(request.TextSearch)
                    || x.Phone.Contains(request.TextSearch)
                    || x.Email.Contains(request.TextSearch)
                    || x.Address.Contains(request.TextSearch));

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
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.Name) :
                                query.OrderByDescending(x => x.Name);

                            break;

                        case "phone":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.Phone) :
                                query.OrderByDescending(x => x.Phone);

                            break;

                        case "address":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.Address) :
                                query.OrderByDescending(x => x.Address);

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

                var data = await query.Select(x=> new ClinicDto() {
                    Code = x.Code,
                    Name=   x.Name,
                    Phone = x.Phone,    
                    Email = x.Address,
                    Status = x.Status,
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<ClinicDto>()
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
                return  new PagedResult<ClinicDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<ClinicDto>> GetById(ClinicRequest request)
        {
            var clinic = await _context.Clinics.FindAsync(request.Id);
            var clinicDto = _mapper.Map<ClinicDto>(clinic);
            return new ApiSuccessResult<ClinicDto>(clinicDto);
        }
    }
}