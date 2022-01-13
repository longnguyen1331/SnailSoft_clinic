using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Doctor_Services;

namespace SnailApp.ApiIntegration
{
    public interface IDoctor_ServiceApiClient
    {
        Task<PagedResult<Doctor_ServiceDto>> GetManageServiceByUserListPaging(ManageDoctor_ServicePagingRequest request);
        Task<PagedResult<Doctor_ServiceDto>> GetManageUserByServiceListPaging(ManageDoctor_ServicePagingRequest request);
        Task<PagedResult<Doctor_ServiceDto>> GetUserFilterService(ManageDoctor_ServicePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(Doctor_ServiceRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class Doctor_ServiceApiClient : BaseApiClient, IDoctor_ServiceApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public Doctor_ServiceApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

      
        public async Task<ApiResult<int>> AddOrUpdateAsync(Doctor_ServiceRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/doctor_services/addorupdate", request);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<Doctor_ServiceDto>> GetManageServiceByUserListPaging(ManageDoctor_ServicePagingRequest request)
        {
            var data = await GetAsync<PagedResult<Doctor_ServiceDto>>(
                $"/api/doctor_services/GetManageServiceByUserListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&ClinicId={request.ClinicId}" +
                $"&DoctorId={request.DoctorId}" +
                $"&ServiceId={request.ServiceId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }

        public async Task<PagedResult<Doctor_ServiceDto>> GetManageUserByServiceListPaging(ManageDoctor_ServicePagingRequest request)
        {
            var data = await GetAsync<PagedResult<Doctor_ServiceDto>>(
                $"/api/doctor_services/GetManageUserByServiceListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&ClinicId={request.ClinicId}" +
                $"&DoctorId={request.DoctorId}" +
                $"&ServiceId={request.ServiceId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }

        public async Task<PagedResult<Doctor_ServiceDto>> GetUserFilterService(ManageDoctor_ServicePagingRequest request)
        {
            var data = await GetAsync<PagedResult<Doctor_ServiceDto>>(
                $"/api/doctor_services/GetUserFilterService?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&ClinicId={request.ClinicId}" +
                $"&DoctorId={request.DoctorId}" +
                $"&ServiceId={request.ServiceId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/doctor_services/{string.Join("|", request.Ids)}");
        }

    
    }
}
