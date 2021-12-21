using Snail.Utilities.Constants;
using Snail.ViewModels.Sales.CommissionDiscounts;
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
    public interface ICommissionDiscountApiClient
    {
        Task<PagedResult<CommissionDiscountDto>> GetManageListPaging(ManageCommissionDiscountPagingRequest request);
        Task<PagedResult<CommissionDiscountDto>> GetAll(ManageCommissionDiscountPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(CommissionDiscountRequest request);

        Task<ApiResult<CommissionDiscountDto>> GetById(CommissionDiscountRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class CommissionDiscountApiClient : BaseApiClient, ICommissionDiscountApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CommissionDiscountApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(CommissionDiscountRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/commissiondiscounts/addorupdate", request);
        }

        public async Task<PagedResult<CommissionDiscountDto>> GetManageListPaging(ManageCommissionDiscountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<CommissionDiscountDto>>(
                $"/api/commissionDiscounts/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<CommissionDiscountDto>> GetAll(ManageCommissionDiscountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<CommissionDiscountDto>>(
                $"/api/commissionDiscounts/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<CommissionDiscountDto>> GetById(CommissionDiscountRequest request)
        {
            var data = await GetAsync<ApiResult<CommissionDiscountDto>>($"/api/commissionDiscounts/Id={request.Id}/LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/commissionDiscounts/{string.Join("|", request.Ids)}");
        }
    }
}
