using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.ApiIntegration
{
    public interface IAppointmentApiClient
    {
        Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageAppointmentPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(AppointmentRequest request);
        Task<ApiResult<AppointmentDto>> GetById(AppointmentRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AppointmentApiClient : BaseApiClient, IAppointmentApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppointmentApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

      
        public async Task<ApiResult<int>> AddOrUpdateAsync(AppointmentRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/appointments/addorupdate", request);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageAppointmentPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppointmentDto>>(
                $"/api/appointments/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&ClinicId={request.ClinicId}" +
                $"&ToDate={request.ToDate}" +
                $"&FromDate={request.FromDate}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
     
        public async Task<ApiResult<AppointmentDto>> GetById(AppointmentRequest request)
        {
            var data = await GetAsync<ApiResult<AppointmentDto>>($"/api/appointments/AppointmentId?Id={request.Id}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appointments/{string.Join("|", request.Ids)}");
        }

    
    }
}
