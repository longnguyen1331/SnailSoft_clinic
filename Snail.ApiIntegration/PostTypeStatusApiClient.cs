using Snail.Utilities.Constants;
using Snail.ViewModels.System.Statuses.PostTypeStatus;
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
    public interface IPostTypeStatusApiClient
    {
        Task<PagedResult<PostTypeStatusDto>> GetManageListPaging(ManagePostTypeStatusPagingRequest request);
        Task<PagedResult<PostTypeStatusDto>> GetAll(ManagePostTypeStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(PostTypeStatusRequest request);

        Task<ApiResult<PostTypeStatusDto>> GetById(int postTypeStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PostTypeStatusApiClient : BaseApiClient, IPostTypeStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PostTypeStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(PostTypeStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/postTypeStatuses/addorupdate", request);
        }

        public async Task<PagedResult<PostTypeStatusDto>> GetManageListPaging(ManagePostTypeStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PostTypeStatusDto>>(
                $"/api/postTypeStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<PostTypeStatusDto>> GetAll(ManagePostTypeStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PostTypeStatusDto>>(
                $"/api/postTypeStatuses/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<PostTypeStatusDto>> GetById(int postTypeStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<PostTypeStatusDto>>($"/api/postTypeStatuses/{postTypeStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/postTypeStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
