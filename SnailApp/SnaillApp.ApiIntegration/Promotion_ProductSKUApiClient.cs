using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Sales.Promotion_ProductSKUs;
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
    public interface IPromotion_ProductSKUApiClient
    {
        Task<PagedResult<Promotion_ProductSKUDto>> GetManageListPaging(ManagePromotion_ProductSKUPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(Promotion_ProductSKURequest request);

        Task<ApiResult<Promotion_ProductSKUDto>> GetById(Promotion_ProductSKURequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class Promotion_ProductSKUApiClient : BaseApiClient, IPromotion_ProductSKUApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public Promotion_ProductSKUApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(Promotion_ProductSKURequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/promotion_productskus/addorupdate", request);
        }

        public async Task<PagedResult<Promotion_ProductSKUDto>> GetManageListPaging(ManagePromotion_ProductSKUPagingRequest request)
        {
            var data = await GetAsync<PagedResult<Promotion_ProductSKUDto>>(
                $"/api/promotion_productskus/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : "") +
                (request.PromotionId != null ? $"&PromotionId={request.PromotionId.Value}" : ""));

            return data;
        }
        public async Task<PagedResult<Promotion_ProductSKUDto>> GetAll(ManagePromotion_ProductSKUPagingRequest request)
        {
            var data = await GetAsync<PagedResult<Promotion_ProductSKUDto>>(
                $"/api/promotion_productskus/getall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<Promotion_ProductSKUDto>> GetById(Promotion_ProductSKURequest request)
        {
            var data = await GetAsync<ApiResult<Promotion_ProductSKUDto>>($"/api/promotion_productskus/getbyid?Id={request.Id}&LanguageId{request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/promotion_productskus/{string.Join("|", request.Ids)}");
        }
    }
}
