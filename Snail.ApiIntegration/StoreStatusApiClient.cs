using Snail.Utilities.Constants;
using Snail.ViewModels.System.Statuses.StoreStatus;
using Snail.ViewModels.Common;
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
    class StoreStoreStatusApiClient
    {
    }
    public interface IStoreStatusApiClient
    {
        Task<PagedResult<StoreStatusDto>> GetManageListPaging(ManageStoreStatusPagingRequest request);
        Task<PagedResult<StoreStatusDto>> GetAll(ManageStoreStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(StoreStatusRequest request);

        Task<ApiResult<StoreStatusDto>> GetById(int storeStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class StoreStatusApiClient : BaseApiClient, IStoreStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public StoreStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(StoreStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/storeStatuses/addorupdate", request);
        }

        public async Task<PagedResult<StoreStatusDto>> GetManageListPaging(ManageStoreStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<StoreStatusDto>>(
                $"api/StoreStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<StoreStatusDto>> GetAll(ManageStoreStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<StoreStatusDto>>(
                $"/api/storeStatuses/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<StoreStatusDto>> GetById(int storeStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<StoreStatusDto>>($"/api/storeStatuses/{storeStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/storeStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
