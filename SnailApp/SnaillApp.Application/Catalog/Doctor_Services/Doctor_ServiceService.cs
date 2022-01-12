using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SnailApp.ViewModels.Catalog.Services;
using SnailApp.ViewModels.Catalog.Doctor_Services;

namespace SnailApp.Application.Catalog.Doctor_Services
{
    public interface IDoctor_ServiceService
    {
        Task<ApiResult<int>> CreateAsync(Doctor_ServiceRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<PagedResult<Doctor_ServiceDto>> GetManageServiceByUserListPaging(ManageDoctor_ServicePagingRequest request);
        Task<PagedResult<Doctor_ServiceDto>> GetManageUserByServiceListPaging(ManageDoctor_ServicePagingRequest request);
    }
    public class Doctor_ServiceService : IDoctor_ServiceService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;
        public Doctor_ServiceService(ClinicDbContext context,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(Doctor_ServiceRequest request)
        {
            try
            {
                var check = await _context.Doctor_Services.Where(x=>x.DoctorId == request.DoctorId && x.ServiceId == request.ServiceId).AsNoTracking().ToListAsync();
                if (check.Any())
                {
                    return new ApiErrorResult<int>()
                    {
                        IsSuccessed = false,
                        Message = "service - doctor is exits"
                    };
                }
                else
                {
                    var service = _mapper.Map<Doctor_Service>(request);
                    service.CreatedDate = DateTime.Now;
                    service.ModifiedDate = DateTime.Now;
                    _context.Doctor_Services.Add(service);
                    await _context.SaveChangesAsync();
                    return new ApiSuccessResult<int>(service.Id);
                }
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
                var doctor_services = await _context.Doctor_Services.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (doctor_services == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Doctor_Services.RemoveRange(doctor_services);

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
        public async Task<PagedResult<Doctor_ServiceDto>> GetManageServiceByUserListPaging(ManageDoctor_ServicePagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from st in _context.Doctor_Services
                            where st.ClinicId == request.ClinicId
                            where st.DoctorId == request.DoctorId
                            select new { st };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.st.Name.Contains(request.TextSearch)
                    || x.st.Code.Contains(request.TextSearch));

                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Id) :
                                query.OrderByDescending(x => x.st.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Code) :
                                query.OrderByDescending(x => x.st.Code);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Name) :
                                query.OrderByDescending(x => x.st.Name);

                            break;

                        case "sortOrder":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.SortOrder) :
                                query.OrderByDescending(x => x.st.SortOrder);
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

                var data = await query.Select(x=> new Doctor_ServiceDto() {
                    Id = x.st.Id,
                    Code = x.st.Code,
                    IsVisibled = x.st.IsVisibled,
                    Name =  x.st.Name,
                    ServiceId = x.st.ServiceId,
                    Description =  x.st.Description,
                    SortOrder = x.st.SortOrder,
                }).AsNoTracking().ToListAsync();

                foreach (var item in data)
                {
                    item.ServiceName = _context.Services.FindAsync(item.ServiceId).Result.Name;
                }

                //5. Select and projection
                var pagedResult = new PagedResult<Doctor_ServiceDto>()
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
                return  new PagedResult<Doctor_ServiceDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<PagedResult<Doctor_ServiceDto>> GetManageUserByServiceListPaging(ManageDoctor_ServicePagingRequest request)
        {
            try
            {
                //1. Select join
                var query = from st in _context.Doctor_Services
                            where st.ClinicId == request.ClinicId
                            where st.ServiceId == request.ServiceId
                            select new { st };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.st.Name.Contains(request.TextSearch)
                    || x.st.Code.Contains(request.TextSearch));

                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Id) :
                                query.OrderByDescending(x => x.st.Id);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Code) :
                                query.OrderByDescending(x => x.st.Code);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.Name) :
                                query.OrderByDescending(x => x.st.Name);

                            break;

                        case "sortOrder":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.st.SortOrder) :
                                query.OrderByDescending(x => x.st.SortOrder);
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

                var data = await query.Select(x => new Doctor_ServiceDto()
                {
                    Id = x.st.Id,
                    Code = x.st.Code,
                    IsVisibled = x.st.IsVisibled,
                    Name = x.st.Name,
                    DoctorId = x.st.DoctorId,
                    Description = x.st.Description,
                    SortOrder = x.st.SortOrder,
                }).AsNoTracking().ToListAsync();

                foreach (var item in data)
                {
                    var doctor = await _context.AppUsers.FindAsync(item.DoctorId);
                    item.DoctorFullName = doctor.FirstName + " " + doctor.LastName;
                }

                //5. Select and projection
                var pagedResult = new PagedResult<Doctor_ServiceDto>()
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
                return new PagedResult<Doctor_ServiceDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
    }
}