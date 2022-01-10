using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.ServiceTypes;
using SnailApp.Utilities.Constants;
using System.Net.Http.Headers;
using System.IO;
using Newtonsoft.Json;

namespace SnailApp.ApiIntegration
{
    public interface IServiceTypeApiClient
    {
        Task<PagedResult<ServiceTypeDto>> GetManageListFilterPaging(ManageServiceTypePagingRequest request);
        Task<PagedResult<ServiceTypeDto>> GetManageListPaging(ManageServiceTypePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ServiceTypeRequest request);
        Task<ApiResult<ServiceTypeDto>> GetById(ServiceTypeRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    
    public class ServiceTypeApiClient : BaseApiClient, IServiceTypeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ServiceTypeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

      

        public async Task<ApiResult<int>> AddOrUpdateAsync(ServiceTypeRequest request)
        {
            try
            {
                var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppConstants.Token);

                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration[SystemConstants.AppConstants.BaseAddress]);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

                var requestContent = new MultipartFormDataContent();
                requestContent.Add(new StringContent(request.Id.ToString()), "id");


                if (request.Image != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.Image.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.Image.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "Image", request.Image.FileName);
                }

                requestContent.Add(new StringContent(request.SortOrder.ToString()), "SortOrder");
                requestContent.Add(new StringContent(request.ClinicId.ToString()), "ClinicId");
                if (!string.IsNullOrEmpty(request.Name))
                {
                    requestContent.Add(new StringContent(request.Name), "Name");
                }

                requestContent.Add(new StringContent(request.IsVisibled.ToString()), "IsVisibled");

                var response = await client.PostAsync($"api/serviceTypes/addorupdate", requestContent);
                return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }
        public async Task<PagedResult<ServiceTypeDto>> GetManageListFilterPaging(ManageServiceTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<ServiceTypeDto>>(
                $"/api/serviceTypes/GetManageListFilterPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&ClinicId={request.ClinicId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
        public async Task<PagedResult<ServiceTypeDto>> GetManageListPaging(ManageServiceTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<ServiceTypeDto>>(
                $"/api/serviceTypes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&ClinicId={request.ClinicId}" + 
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
        
        public async Task<ApiResult<ServiceTypeDto>> GetById(ServiceTypeRequest request)
        {
            var data = await GetAsync<ApiResult<ServiceTypeDto>>($"/api/serviceTypes/ServiceTypeId?Id={request.Id}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/serviceTypes/{string.Join("|", request.Ids)}");
        }

    
    }
}
