using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Services;

namespace SnailApp.ApiIntegration
{
    public interface IServiceApiClient
    {
        Task<PagedResult<ServiceDto>> GetManageListPaging(ManageServicePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ServiceRequest request);
        Task<ApiResult<ServiceDto>> GetById(ServiceRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class ServiceApiClient : BaseApiClient, IServiceApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ServiceApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

      
        public async Task<ApiResult<int>> AddOrUpdateAsync(ServiceRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/services/addorupdate", request);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<ServiceDto>> GetManageListPaging(ManageServicePagingRequest request)
        {
            var data = await GetAsync<PagedResult<ServiceDto>>(
                $"/api/services/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&ClinicId={request.ClinicId}" + 
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
     
        public async Task<ApiResult<ServiceDto>> GetById(ServiceRequest request)
        {
            var data = await GetAsync<ApiResult<ServiceDto>>($"/api/services/ServiceId?Id={request.Id}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/services/{string.Join("|", request.Ids)}");
        }

    
    }
}
