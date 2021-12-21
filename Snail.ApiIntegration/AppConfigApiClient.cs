using Snail.Utilities.Constants;
using Snail.ViewModels.System.AppConfigs;
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
    public interface IAppConfigApiClient
    {
        Task<PagedResult<AppConfigDto>> GetManageListPaging(ManageAppConfigPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(AppConfigRequest request);

        Task<ApiResult<AppConfigDto>> GetById(int appConfigId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AppConfigApiClient : BaseApiClient, IAppConfigApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppConfigApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(AppConfigRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/appconfigs/addorupdate", request);
        }

        public async Task<PagedResult<AppConfigDto>> GetManageListPaging(ManageAppConfigPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppConfigDto>>(
                $"/api/appConfigs/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<AppConfigDto>> GetById(int appConfigId)
        {
            var data = await GetAsync<ApiResult<AppConfigDto>>($"/api/appConfigs/{appConfigId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appConfigs/{string.Join("|", request.Ids)}");
        }
    }
}
