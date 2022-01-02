using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Products;
using SnailApp.ViewModels.Catalog.ProductSKUs;
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
    public interface IProductSKUApiClient
    {
        Task<PagedResult<ProductSKUDto>> GetManageListPaging(ManageProductSKUPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ProductSKURequest request);
        Task<ApiResult<ProductSKUDto>> GetById(int productSKUId);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class ProductSKUApiClient : BaseApiClient, IProductSKUApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductSKUApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(ProductSKURequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/productSKUs/addorupdate", request);
        }
        public async Task<PagedResult<ProductSKUDto>> GetManageListPaging(ManageProductSKUPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductSKUDto>>(
                $"/api/productSKUs/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&ProductId={request.ProductId}" +
                $"&LanguageId={request.LanguageId}" +
                $"&StoreId={request.StoreId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<ProductSKUDto>> GetById(int productSKUId)
        {
            var data = await GetAsync<ApiResult<ProductSKUDto>>($"/api/productSKUs/{productSKUId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/productSKUs/{string.Join("|", request.Ids)}");
        }



    }
}