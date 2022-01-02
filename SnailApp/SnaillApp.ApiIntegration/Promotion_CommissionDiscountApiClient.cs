using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Sales.Promotion_CommissionDiscounts;
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
    public interface IPromotion_CommissionDiscountApiClient
    {
        Task<PagedResult<Promotion_CommissionDiscountDto>> GetManageListPaging(ManagePromotion_CommissionDiscountPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(Promotion_CommissionDiscountRequest request);

        Task<ApiResult<Promotion_CommissionDiscountDto>> GetById(Promotion_CommissionDiscountRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class Promotion_CommissionDiscountApiClient : BaseApiClient, IPromotion_CommissionDiscountApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public Promotion_CommissionDiscountApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(Promotion_CommissionDiscountRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/promotion_commissiondiscounts/addorupdate", request);
        }

        public async Task<PagedResult<Promotion_CommissionDiscountDto>> GetManageListPaging(ManagePromotion_CommissionDiscountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<Promotion_CommissionDiscountDto>>(
                $"/api/promotion_commissiondiscounts/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : "") +
                (request.PromotionId != null ? $"&PromotionId={request.PromotionId.Value}" : ""));

            return data;
        }
        public async Task<PagedResult<Promotion_CommissionDiscountDto>> GetAll(ManagePromotion_CommissionDiscountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<Promotion_CommissionDiscountDto>>(
                $"/api/promotion_commissiondiscounts/getall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<Promotion_CommissionDiscountDto>> GetById(Promotion_CommissionDiscountRequest request)
        {
            var data = await GetAsync<ApiResult<Promotion_CommissionDiscountDto>>($"/api/promotion_commissiondiscounts/getbyid?Id={request.Id}&LanguageId{request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/promotion_commissiondiscounts/{string.Join("|", request.Ids)}");
        }
    }
}
