using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.System.Statuses.OrderStatus;
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
    public interface IOrderStatusApiClient
    {
        Task<PagedResult<OrderStatusDto>> GetManageListPaging(ManageOrderStatusPagingRequest request);
        Task<PagedResult<OrderStatusDto>> GetAll(ManageOrderStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(OrderStatusRequest request);

        Task<ApiResult<OrderStatusDto>> GetById(int orderStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class OrderStatusApiClient : BaseApiClient, IOrderStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public OrderStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(OrderStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/orderStatuses/addorupdate", request);
        }

        public async Task<PagedResult<OrderStatusDto>> GetManageListPaging(ManageOrderStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<OrderStatusDto>>(
                $"/api/OrderStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<OrderStatusDto>> GetAll(ManageOrderStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<OrderStatusDto>>(
                $"/api/orderStatuses/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<OrderStatusDto>> GetById(int orderStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<OrderStatusDto>>($"/api/orderStatuses/{orderStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/orderStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
