using Snail.Utilities.Constants;
using Snail.ViewModels.Catalog.PaperSizes;
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
    public interface IPaperSizeApiClient
    {
        Task<PagedResult<PaperSizeDto>> GetManageListPaging(ManagePaperSizePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(PaperSizeRequest request);

        Task<ApiResult<PaperSizeDto>> GetById(int paperSizeId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PaperSizeApiClient : BaseApiClient, IPaperSizeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PaperSizeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(PaperSizeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/paperSizes/addorupdate", request);
        }
        public async Task<PagedResult<PaperSizeDto>> GetManageListPaging(ManagePaperSizePagingRequest request)
        {
            var data = await GetAsync<PagedResult<PaperSizeDto>>(
                $"/api/paperSizes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<PaperSizeDto>> GetById(int paperSizeId)
        {
            var data = await GetAsync<ApiResult<PaperSizeDto>>($"/api/paperSizes/{paperSizeId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/paperSizes/{string.Join("|", request.Ids)}");
        }
    }
}
