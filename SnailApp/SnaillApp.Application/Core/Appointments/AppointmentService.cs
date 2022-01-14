using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Appointments;
using AutoMapper;
using System.Globalization;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Http;
using SnailApp.Application.Common;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Application.Catalog.Appointments
{
    public interface IAppointmentService
    {
        Task<ApiResult<int>> CreateAsync(AppointmentRequest request);
        Task<ApiResult<int>> ChangeStatus(AppointmentRequest request);
        Task<ApiResult<int>> UpdateAsync(AppointmentRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AppointmentDto>> GetById(AppointmentRequest request);
        Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageAppointmentPagingRequest request);
    }

    public class AppointmentService : IAppointmentService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public AppointmentService(ClinicDbContext context,
            IFileStorageService storageService,
            IConfiguration configuration,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _storageService = storageService;
            _configuration = configuration;
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(AppointmentRequest request)
        {
            try
            {
                var appointment = _mapper.Map<Appointment>(request);

                DateTime datetim1;
                if (DateTime.TryParseExact(request.Date, "yyyy-MM-dd HH:mm", null, DateTimeStyles.None, out datetim1))
                {
                    appointment.Date = datetim1;
                }
                else
                {
                    appointment.Date = DateTime.Now;
                }

                appointment.CreatedDate = DateTime.Now;
                appointment.ModifiedDate = DateTime.Now;
                _context.Appointments.Add(appointment);
                await _context.SaveChangesAsync();
                if(request.Appointment_ServiceRequests.Count > 0)
                {
                    var appointment_services = _mapper.Map<List<Appointment_Service>>(request.Appointment_ServiceRequests);

                    for(int i=0; i< appointment_services.Count; i++)
                    {
                        DateTime date;
                        if (DateTime.TryParseExact(request.Appointment_ServiceRequests[i].Date, "yyyy-MM-dd HH:mm", null, DateTimeStyles.None, out date))
                        {
                            appointment_services[i].Date = date;
                        }
                        else
                        {
                            appointment_services[i].Date = DateTime.Now;
                        }

                        appointment_services[i].AppointmentId = appointment.Id;
                    }

                    _context.Appointment_Services.AddRange(appointment_services);
                    await _context.SaveChangesAsync();
                }
                return new ApiSuccessResult<int>(appointment.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(AppointmentRequest request)
        {
            try
            {
                var check = await _context.Appointments.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();

                if (check == null ) throw new EShopException($"Cannot find a appointment with id: {request.Id}");

                var appointment = _mapper.Map<Appointment>(request);

                DateTime datetim1;
                if (DateTime.TryParseExact(request.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    appointment.Date = datetim1;
                }
                else
                {
                    appointment.Date = DateTime.Now;
                }

                appointment.ModifiedDate = DateTime.Now;

                _context.Appointments.Update(appointment);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appointment.Id);

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

        public async Task<ApiResult<int>> ChangeStatus(AppointmentRequest request)
        {
            try
            {
                var appointment = await _context.Appointments.Where(x => x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();
                if (appointment == null) throw new EShopException($"Cannot find a appointment with id: {request.Id}");
                appointment.Status = (AppointmentStatus)request.Status;
                _context.Appointments.Update(appointment);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appointment.Id);
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
                var appointments = await _context.Appointments.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (appointments == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                foreach(var item in appointments)
                {
                    _context.Appointment_Services.RemoveRange(item.Appointment_Services);
                }
                _context.Appointments.RemoveRange(appointments);

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
        public async Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageAppointmentPagingRequest request)
        {
            try
            {
                DateTime fDate, tDate, firstDayOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                if (!DateTime.TryParseExact(request.FromDate, "yyyy-MM-dd", null, DateTimeStyles.None, out fDate))
                {
                    fDate = firstDayOfMonth;
                }
                if (!DateTime.TryParseExact(request.ToDate, "yyyy-MM-dd", null, DateTimeStyles.None, out tDate))
                {
                    tDate = firstDayOfMonth.AddMonths(1).AddDays(-1).AddHours(23).AddMinutes(59);
                }

                //1. Select join

                var query = (from a in _context.Appointments
                         where fDate <= a.Date && a.Date <= tDate
                         && (request.Status >= 0 ? a.Status == (AppointmentStatus)request.Status  : a.Status >= 0)
                         select new { a }
                            ).AsNoTracking();

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.a.Name.Contains(request.TextSearch)
                    || x.a.Code.Contains(request.TextSearch));

                //3.Sort

                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {
                        case "id":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.a.Id) :
                                query.OrderByDescending(x => x.a.Id);

                            break;

                        case "date":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.a.Date) :
                                query.OrderByDescending(x => x.a.Date);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.a.Name) :
                                query.OrderByDescending(x => x.a.Name);

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

                var data = await query.Select(x=> new AppointmentDto() {
                    Id = x.a.Id,
                    Name =  x.a.Name,
                    Status =  x.a.Status,
                    Date =  x.a.Date.ToString("yyyy-MM-ddTHH:mm:ss.sssZ"),
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<AppointmentDto>()
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
                return  new PagedResult<AppointmentDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<AppointmentDto>> GetById(AppointmentRequest request)
        {
            var appointment = await (from a in _context.Appointments
                                     join doctor in _context.AppUsers on a.DoctorId equals doctor.Id
                                     join patient in _context.AppUsers on a.PatientId equals patient.Id
                                     where a.Id == request.Id select new { a , doctor, patient}
                                     ).AsNoTracking().FirstOrDefaultAsync();

            var appointmentDto = _mapper.Map<AppointmentDto>(appointment.a);
            appointmentDto.DoctorFullName = appointment.doctor.FirstName + " " + appointment.doctor.LastName;   
            appointmentDto.PatientFullName = appointment.patient.FirstName + " " + appointment.patient.LastName;
            appointmentDto.PatientAvatar = (!string.IsNullOrEmpty(appointment.patient.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + appointment.patient.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]);
            appointmentDto.PatientAddress = appointment.patient.Address;
            appointmentDto.PatientEmail = appointment.patient.Email;
            appointmentDto.PatientPhone = appointment.patient.PhoneNumber;
            appointmentDto.PatientCode = appointment.patient.Code;

            var appointmentService = await _context.Appointment_Services.Where(x => x.AppointmentId == request.Id).AsNoTracking().ToListAsync();
            if (appointmentService != null && appointmentService.Count > 0)
            {
                appointmentDto.Appointment_Services = new List<Appointment_ServiceDto>();
                foreach(var item in appointmentService)
                {
                    var serviceDto = _mapper.Map<Appointment_ServiceDto>(item);
                    var service = await _context.Services.FindAsync(item.ServiceId);
                    var doctor = await _context.AppUsers.FindAsync(item.DoctorId);
                    serviceDto.DoctorFullName = doctor.FirstName + " " + doctor.LastName;
                    serviceDto.ServiceName = service.Name;
                    appointmentDto.Appointment_Services.Add(serviceDto);
                }
            }

            return new ApiSuccessResult<AppointmentDto>(appointmentDto);
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            try
            {
                await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.UserConstants.ImageImagePath] + "/" + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.UserConstants.ImageImagePath] + "/" + fileName);
        }
    }
}