using Snail.Utilities.Constants;
using Snail.ViewModels.System.Statuses.SlideStatus;
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
    public interface ISlideStatusApiClient
    {
        Task<PagedResult<SlideStatusDto>> GetManageListPaging(ManageSlideStatusPagingRequest request);
        Task<PagedResult<SlideStatusDto>> GetAll(ManageSlideStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(SlideStatusRequest request);

        Task<ApiResult<SlideStatusDto>> GetById(int slideStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class SlideStatusApiClient : BaseApiClient, ISlideStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public SlideStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(SlideStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/slideStatuses/addorupdate", request);
        }

        public async Task<PagedResult<SlideStatusDto>> GetManageListPaging(ManageSlideStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<SlideStatusDto>>(
                $"/api/slideStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<SlideStatusDto>> GetAll(ManageSlideStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<SlideStatusDto>>(
                $"/api/slideStatuses/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<SlideStatusDto>> GetById(int slideStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<SlideStatusDto>>($"/api/slideStatuses/{slideStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/slideStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
