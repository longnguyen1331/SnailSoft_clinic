using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.ApiIntegration
{
    public interface IAppointmentPaymentApiClient
    {
        Task<ApiResult<int>> AddOrUpdateAsync(AppointmentPaymentRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AppointmentPaymentApiClient : BaseApiClient, IAppointmentPaymentApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppointmentPaymentApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

      
        public async Task<ApiResult<int>> AddOrUpdateAsync(AppointmentPaymentRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/appointmentPayments/addorupdate", request);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appointmentPayments/{string.Join("|", request.Ids)}");
        }

    
    }
}
