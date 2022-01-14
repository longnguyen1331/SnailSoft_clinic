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

namespace SnailApp.Application.Catalog.AppointmentPayments
{
    public interface IAppointmentPaymentService
    {
        Task<ApiResult<int>> CreateAsync(AppointmentPaymentRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }

    public class AppointmentPaymentService : IAppointmentPaymentService
    {
        private readonly ClinicDbContext _context;
        private readonly IMapper _mapper;

        public AppointmentPaymentService(ClinicDbContext context,
            IMapper mapper
            )
        {
            _mapper = mapper;
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
                var appointmentPayments = await _context.AppointmentPayments.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (appointmentPayments == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.AppointmentPayments.RemoveRange(appointmentPayments);

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
    }
}