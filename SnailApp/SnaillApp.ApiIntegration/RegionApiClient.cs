using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Regions;

namespace SnailApp.ApiIntegration
{
    public interface IRegionApiClient
    {
        Task<PagedResult<RegionDto>> GetManageListPaging(ManageRegionPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(RegionRequest request);
        Task<ApiResult<RegionDto>> GetById(RegionRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class RegionApiClient : BaseApiClient, IRegionApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public RegionApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(RegionRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/regions/addorupdate", request);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<RegionDto>> GetManageListPaging(ManageRegionPagingRequest request)
        {
            var data = await GetAsync<PagedResult<RegionDto>>(
                $"/api/regions/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&ParentId={request.ParentId}" + 
                $"&Level={request.Level}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
     
        public async Task<ApiResult<RegionDto>> GetById(RegionRequest request)
        {
            var data = await GetAsync<ApiResult<RegionDto>>($"/api/regions/RegionId?Id={request.Id}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/regions/{string.Join("|", request.Ids)}");
        }

    
    }
}
