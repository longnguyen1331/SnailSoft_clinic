using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SnailApp.ApiIntegration
{
    public interface IBloodApiClient
    {
        Task<PagedResult<BaseDto>> GetManageListPaging(PagingRequestBase request);
        Task<ApiResult<int>> AddOrUpdateAsync(BaseRequest request);
        Task<ApiResult<BaseDto>> GetById(BaseRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class BloodApiClient : BaseApiClient, IBloodApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public BloodApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

      
        public async Task<ApiResult<int>> AddOrUpdateAsync(BaseRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/bloods/addorupdate", request);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<BaseDto>> GetManageListPaging(PagingRequestBase request)
        {
            var data = await GetAsync<PagedResult<BaseDto>>(
                $"/api/bloods/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
     
        public async Task<ApiResult<BaseDto>> GetById(BaseRequest request)
        {
            var data = await GetAsync<ApiResult<BaseDto>>($"/api/bloods/BloodId?Id={request.Id}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/bloods/{string.Join("|", request.Ids)}");
        }

    
    }
}
