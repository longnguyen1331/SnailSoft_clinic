using Snail.Utilities.Constants;
using Snail.ViewModels.System.Statuses.AppUserStatus;
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
    public interface IAppUserStatusApiClient
    {
        Task<PagedResult<AppUserStatusDto>> GetManageListPaging(ManageAppUserStatusPagingRequest request);
        Task<PagedResult<AppUserStatusDto>> GetAll(ManageAppUserStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(AppUserStatusRequest request);

        Task<ApiResult<AppUserStatusDto>> GetById(int appUserStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AppUserStatusApiClient : BaseApiClient, IAppUserStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppUserStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(AppUserStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/appUserStatuses/addorupdate", request);
        }

        public async Task<PagedResult<AppUserStatusDto>> GetManageListPaging(ManageAppUserStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUserStatusDto>>(
                $"/api/appUserStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<AppUserStatusDto>> GetAll(ManageAppUserStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUserStatusDto>>(
                $"/api/appUserStatuses/getall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<AppUserStatusDto>> GetById(int appUserStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<AppUserStatusDto>>($"/api/appUserStatuses/{appUserStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appUserStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
