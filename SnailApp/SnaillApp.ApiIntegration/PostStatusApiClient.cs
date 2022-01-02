using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.System.Statuses.PostStatus;
using SnailApp.ViewModels.Common;
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

namespace SnailApp.ApiIntegration
{
    public interface IPostStatusApiClient
    {
        Task<PagedResult<PostStatusDto>> GetManageListPaging(ManagePostStatusPagingRequest request);
        Task<PagedResult<PostStatusDto>> GetAll(ManagePostStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(PostStatusRequest request);

        Task<ApiResult<PostStatusDto>> GetById(int postStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PostStatusApiClient : BaseApiClient, IPostStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PostStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(PostStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/postStatuses/addorupdate", request);
        }

        public async Task<PagedResult<PostStatusDto>> GetManageListPaging(ManagePostStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PostStatusDto>>(
                $"/api/postStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<PostStatusDto>> GetAll(ManagePostStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PostStatusDto>>(
                $"/api/postStatuses/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<PostStatusDto>> GetById(int postStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<PostStatusDto>>($"/api/postStatuses/{postStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/postStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
