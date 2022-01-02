using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Sales.Promotions;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.ProductTypes;
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
    public interface IPromotionApiClient
    {
        Task<PagedResult<PromotionDto>> GetManageListPaging(ManagePromotionPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateBasicInfoAsync(PromotionRequest request);
        Task<ApiResult<PromotionDto>> GetBasicInfoAsyncById(PromotionRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PromotionApiClient : BaseApiClient, IPromotionApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PromotionApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateBasicInfoAsync(PromotionRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/promotions/addOrupdatebasicinfo", request);
        }
        public async Task<PagedResult<PromotionDto>> GetManageListPaging(ManagePromotionPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PromotionDto>>(
                $"/api/promotions/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<PromotionDto>> GetBasicInfoAsyncById(PromotionRequest request)
        {
            return await GetAsync<ApiResult<PromotionDto>>($"/api/promotions/getbasicinfoasyncbyid?id={request.Id}&LanguageId={request.LanguageId}");
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/promotions/{string.Join("|", request.Ids)}");
        }
    }
}
