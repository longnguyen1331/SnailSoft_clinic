using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using System.Globalization;
using SnailApp.Application.Common;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.Catalog.Appointments;
using SnailApp.ViewModels.Enums;

namespace SnailApp.Application.Catalog.AppointmentPayments
{
    public interface IAppointmentPaymentService
    {
        Task<PagedResult<AppointmentPaymentDto>> GetManageListPaging(ManageAppointmentPagingRequest request);
        Task<ApiResult<int>> CreateAsync(AppointmentPaymentRequest request);
        Task<ApiResult<int>> UpdateAsync(AppointmentPaymentRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AppointmentPaymentDto>> GetById(AppointmentPaymentRequest request);
    }

    public class AppointmentPaymentService : IAppointmentPaymentService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AppointmentPaymentService(ClinicDbContext context,
            IConfiguration configuration,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _configuration = configuration;
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(AppointmentPaymentRequest request)
        {
            try
            {
                var appointment = await _context.Appointments.FindAsync(request.AppointmentId);
                var appointmentPayment = _mapper.Map<AppointmentPayment>(request);

                DateTime datetim1;
                if (DateTime.TryParseExact(request.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    appointmentPayment.Date = datetim1;
                }
                else
                {
                    appointmentPayment.Date = DateTime.Now;
                }

                appointmentPayment.CreatedDate = DateTime.Now;
                appointmentPayment.ModifiedDate = DateTime.Now;
                appointment.Status = ViewModels.Enums.AppointmentStatus.Checkout;
                _context.AppointmentPayments.Add(appointmentPayment);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appointmentPayment.Id);
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
                var appointmentPayments = await _context.AppointmentPayments.Where(m => request.Ids.Contains(m.Id)).AsNoTracking().ToListAsync();

                if (appointmentPayments == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");
                //_context.AppointmentPayments.RemoveRange(appointmentPayments);
                foreach(var item in appointmentPayments)
                {
                    var appointment = await _context.Appointments.FindAsync(item.AppointmentId);
                    appointment.Status = AppointmentStatus.Booking;
                }
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
        public async Task<PagedResult<AppointmentPaymentDto>> GetManageListPaging(ManageAppointmentPagingRequest request)
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

                var query = (from p in _context.AppointmentPayments
                             join a in _context.Appointments on p.AppointmentId equals a.Id
                             join patient in _context.AppUsers on a.PatientId equals patient.Id
                             join doctor in _context.AppUsers on a.DoctorId equals doctor.Id
                             where fDate <= a.Date && a.Date <= tDate
                             && request.ClinicId == a.ClinicId
                             && (request.Status >= 0 ? p.Status == request.Status : p.Status >= 0)
                             select new { p, a, patient, doctor }
                            ).AsNoTracking();

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.a.Name.Contains(request.TextSearch)
                    || (x.patient.FirstName + " " + x.patient.LastName).Contains(request.TextSearch)
                    || (x.doctor.FirstName + " " + x.doctor.LastName).Contains(request.TextSearch)
                    || (x.patient.Code).Contains(request.TextSearch)
                    || (x.patient.Email).Contains(request.TextSearch)
                    || (x.patient.PhoneNumber).Contains(request.TextSearch)
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

                var data = await query.Select(x => new AppointmentPaymentDto()
                {
                    Id = x.p.Id,
                    DoctorFullName = x.doctor.FirstName + " " + x.doctor.LastName,
                    PatientFullName = x.patient.FirstName + " " + x.patient.LastName,
                    PatientAvatar = (!string.IsNullOrEmpty(x.patient.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + x.patient.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]),
                    PatientCode = x.patient.Code,
                    PatientEmail = x.patient.Email,
                    PatientAddress = x.patient.Address,
                    PatientPhoneNumber = x.patient.PhoneNumber,
                    Status = x.p.Status,
                    Date = x.p.Date.ToString("yyyy-MM-dd HH:mm"),
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<AppointmentPaymentDto>()
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
                return new PagedResult<AppointmentPaymentDto>()
                {
                    TotalRecords = 0,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = null,
                    Message = ex.Message
                };
            }
        }
        public async Task<ApiResult<AppointmentPaymentDto>> GetById(AppointmentPaymentRequest request)
        {
            var appointment = await (from a_s in _context.AppointmentPayments
                                     join a in _context.Appointments on a_s.AppointmentId equals a.Id
                                     join patient in _context.AppUsers on a.PatientId equals patient.Id
                                     join doctor in _context.AppUsers on a.DoctorId equals doctor.Id
                                     where a_s.Id == request.Id
                                     select new { a, a_s, patient, doctor }
                                     ).AsNoTracking().FirstOrDefaultAsync();

            var appointmentDto = _mapper.Map<AppointmentPaymentDto>(appointment.a_s);
            appointmentDto.DoctorFullName = appointment.doctor.FirstName + " " + appointment.doctor.LastName;
            appointmentDto.PatientFullName = appointment.patient.FirstName + " " + appointment.patient.LastName;
            appointmentDto.PatientAvatar = (!string.IsNullOrEmpty(appointment.patient.Avatar) ? _configuration[SystemConstants.UserConstants.UserImagePath] + "/" + appointment.patient.Avatar : _configuration[SystemConstants.AppConstants.FileNoImagePerson]);
            appointmentDto.PatientCode = appointment.patient.Code;
            appointmentDto.PatientEmail = appointment.patient.Email;
            appointmentDto.PatientAddress = appointment.patient.Address;
            appointmentDto.PatientPhoneNumber = appointment.patient.PhoneNumber;
            appointmentDto.AppointmentStatus = appointment.a.Status;

            return new ApiSuccessResult<AppointmentPaymentDto>(appointmentDto);
        }
        public async Task<ApiResult<int>> UpdateAsync(AppointmentPaymentRequest request)
        {
            try
            {
                var appointment = await _context.Appointments.FindAsync(request.AppointmentId);
                var appointmentPayment = _mapper.Map<AppointmentPayment>(request);

                DateTime datetim1;
                if (DateTime.TryParseExact(request.Date, "yyyy-MM-dd", null, DateTimeStyles.None, out datetim1))
                {
                    appointmentPayment.Date = datetim1;
                }
                else
                {
                    appointmentPayment.Date = DateTime.Now;
                }

                appointmentPayment.ModifiedDate = DateTime.Now;
                appointment.Status = AppointmentStatus.Checkout;
                _context.AppointmentPayments.Update(appointmentPayment);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(appointmentPayment.Id);
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
    }
}