using Snail.Utilities.Constants;
using Snail.ViewModels.Catalog.Stores;
using Snail.ViewModels.Common;
using Snail.ViewModels.Catalog.ProductTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ApiIntegration
{
    public interface IStoreApiClient
    {
        Task<PagedResult<StoreDto>> GetManageListPaging(ManageStorePagingRequest request);
        Task<PagedResult<StoreDto>> GetAll(ManageStorePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(StoreRequest request);

        Task<ApiResult<StoreDto>> GetById(StoreRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class StoreApiClient : BaseApiClient, IStoreApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public StoreApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(StoreRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/stores/addorupdate", request);
        }

        public async Task<PagedResult<StoreDto>> GetManageListPaging(ManageStorePagingRequest request)
        {
            var data = await GetAsync<PagedResult<StoreDto>>(
                $"/api/stores/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<StoreDto>> GetAll(ManageStorePagingRequest request)
        {
            var data = await GetAsync<PagedResult<StoreDto>>(
                $"/api/stores/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<StoreDto>> GetById(StoreRequest request)
        {
            var data = await GetAsync<ApiResult<StoreDto>>($"/api/stores/StoreId?Id={request.Id}&LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/stores/{string.Join("|", request.Ids)}");
        }
    }
}
