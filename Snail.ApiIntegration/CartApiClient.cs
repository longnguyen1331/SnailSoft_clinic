using Snail.Utilities.Constants;
using Snail.ViewModels.Sales.Carts;
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
    public interface ICartApiClient
    {
        Task<PagedResult<CartDto>> GetManageListPaging(ManageCartPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(CartRequest request);
        Task<ApiResult<CartDto>> GetById(int cartId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class CartApiClient : BaseApiClient, ICartApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CartApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(CartRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/carts/addorupdate", request);
        }
        public async Task<PagedResult<CartDto>> GetManageListPaging(ManageCartPagingRequest request)
        {
            var data = await GetAsync<PagedResult<CartDto>>(
                $"/api/carts/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<CartDto>> GetById(int cartId)
        {
            var data = await GetAsync<ApiResult<CartDto>>($"/api/carts/{cartId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/carts/{string.Join("|", request.Ids)}");
        }
    }
}
