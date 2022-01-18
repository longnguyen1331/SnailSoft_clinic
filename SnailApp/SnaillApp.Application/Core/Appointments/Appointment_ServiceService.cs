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

namespace SnailApp.Application.Catalog.Appointment_Services
{
    public interface IAppointment_ServiceService
    {
        Task<ApiResult<int>> CreateAsync(Appointment_ServiceRequest request);
        Task<ApiResult<int>> UpdateAsync(Appointment_ServiceRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<Appointment_ServiceDto>> GetById(Appointment_ServiceRequest request);
        Task<PagedResult<Appointment_ServiceDto>> GetManageListPaging(ManageAppointment_ServicePagingRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);
    }

    public class Appointment_ServiceService : IAppointment_ServiceService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public Appointment_ServiceService(ClinicDbContext context,
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

        public async Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile)
        {
            try
            {
                return new ApiSuccessResult<string>(_configuration[SystemConstants.AppointmentServiceConstants.AppointmentServicePath] + "/" + (await this.SaveFile(uploadFile)));
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> CreateAsync(Appointment_ServiceRequest request)
        {
            try
            {
                var appointment = _mapper.Map<Appointment_Service>(request);

                DateTime datetim1;
                if (DateTime.TryParseExact(request.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    appointment.Date = datetim1;
                }
                else
                {
                    appointment.Date = DateTime.Now;
                }


                if (request.ServiceFile != null)
                {
                    appointment.ServiceFile = await this.SaveFile(request.ServiceFile);
                }

                appointment.CreatedDate = DateTime.Now;
                appointment.ModifiedDate = DateTime.Now;
                _context.Appointment_Services.Add(appointment);
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

        public async Task<ApiResult<int>> UpdateAsync(Appointment_ServiceRequest request)
        {
            try
            {
                var check = await _context.Appointment_Services.Where(x=>x.Id == request.Id).AsNoTracking().FirstOrDefaultAsync();

                if (check == null ) throw new EShopException($"Cannot find a appointmentservice with id: {request.Id}");

                check.IsDefault = request.IsDefault;
                check.ServiceResult = request.ServiceResult;
                //DateTime datetim1;
                //if (DateTime.TryParseExact(request.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                //{
                //    check.Date = datetim1;
                //}
                //else
                //{
                //    check.Date = DateTime.Now;
                //}

                if (request.ServiceFile != null)
                {
                    if (!string.IsNullOrEmpty(check.ServiceFile))
                    {
                        await DeleteFile(check.ServiceFile);
                    }

                    check.ServiceFile = await this.SaveFile(request.ServiceFile);
                }
                else
                {
                    check.ServiceFile = check.ServiceFile;
                }

                check.ModifiedDate = DateTime.Now;
                _context.Appointment_Services.Update(check);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(check.Id);

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
                var appointments = await _context.Appointment_Services.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (appointments == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Appointment_Services.RemoveRange(appointments);

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
        public async Task<PagedResult<Appointment_ServiceDto>> GetManageListPaging(ManageAppointment_ServicePagingRequest request)
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

                var query = (
                                from a_s in _context.Appointment_Services
                                join a in _context.Appointments on a_s.AppointmentId equals a.Id
                                join s in _context.Services on a_s.ServiceId equals s.Id
                                join u in _context.AppUsers on a_s.DoctorId equals u.Id
                                join p in _context.AppUsers on a.PatientId equals p.Id
                                 where fDate <= a_s.Date && a_s.Date <= tDate
                                 && request.ClinicId == a.ClinicId
                                 && (request.Status.HasValue ? a.IsDefault == request.Status.Value : (a.IsDefault == true || a.IsDefault == false))
                                select new { a, a_s,u, s,p }
                            ).AsNoTracking();

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.a.Name.Contains(request.TextSearch)
                    || (x.p.FirstName + " " + x.p.LastName).Contains(request.TextSearch)
                    || (x.u.FirstName + " " + x.u.LastName).Contains(request.TextSearch)
                    || (x.s.Name).Contains(request.TextSearch)
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

                        case "serviceName":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.a.Name) :
                                query.OrderByDescending(x => x.s.Name);

                            break;


                        case "doctorFullName":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.u.FirstName + " " + x.u.LastName) :
                                query.OrderByDescending(x => x.u.FirstName + " " + x.u.LastName);

                            break;

                        case "patientFullName":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.p.FirstName + " " + x.p.LastName) :
                                query.OrderByDescending(x => x.p.FirstName + " " + x.p.LastName);

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

                var data = await query.Select(x=> new Appointment_ServiceDto() {
                    Id = x.a_s.Id,
                    Name =  x.a.Name,
                    IsDefault =  x.a_s.IsDefault,
                    ServiceName =  x.s.Name,
                    DoctorFullName =  x.u.FirstName + " " + x.u.LastName,
                    PatientFullName =  x.p.FirstName + " " + x.p.LastName,
                    Date = x.a_s.Date.ToString("yyyy-MM-dd HH:mm"),
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<Appointment_ServiceDto>()
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
                return  new PagedResult<Appointment_ServiceDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<Appointment_ServiceDto>> GetById(Appointment_ServiceRequest request)
        {
            var appointment = await (from a_s in _context.Appointment_Services
                                     join s in _context.Services on a_s.ServiceId equals s.Id
                                     join a in _context.Appointments on a_s.AppointmentId equals a.Id
                                     join doctor in _context.AppUsers on a.DoctorId equals doctor.Id
                                     join patient in _context.AppUsers on a.PatientId equals patient.Id
                                     where a_s.Id == request.Id select new { a_s, a ,s, doctor, patient}
                                     ).AsNoTracking().FirstOrDefaultAsync();

            var appointmentDto = _mapper.Map<Appointment_ServiceDto>(appointment.a_s);
            appointmentDto.DoctorFullName = appointment.doctor.FirstName + " " + appointment.doctor.LastName;   
            appointmentDto.PatientFullName = appointment.patient.FirstName + " " + appointment.patient.LastName;
            appointmentDto.PatientAvatar = (!string.IsNullOrEmpty(appointment.patient.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + appointment.patient.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]);
            appointmentDto.PatientAddress = appointment.patient.Address;
            appointmentDto.PatientEmail = appointment.patient.Email;
            appointmentDto.PatientPhone = appointment.patient.PhoneNumber;
            appointmentDto.PatientCode = appointment.patient.Code;
            appointmentDto.ServiceName = appointment.s.Name;
            appointmentDto.ServiceFile = !string.IsNullOrEmpty(appointmentDto.ServiceFile) ?  _configuration[SystemConstants.AppointmentServiceConstants.AppointmentServicePath] + "/" + appointmentDto.ServiceFile : "";

            return new ApiSuccessResult<Appointment_ServiceDto>(appointmentDto);
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            try
            {
                await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.AppointmentServiceConstants.AppointmentServicePath] + "/" + fileName);
                return fileName;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.AppointmentServiceConstants.AppointmentServicePath] + "/" + fileName);
        }
    }
}