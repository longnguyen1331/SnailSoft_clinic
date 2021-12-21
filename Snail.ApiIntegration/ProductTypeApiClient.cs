using Snail.Utilities.Constants;
using Snail.ViewModels.Catalog.ProductTypes;
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
    public interface IProductTypeApiClient
    {
        Task<ApiResult<List<ProductTypeDto>>> GetAll(int languageId);
        Task<PagedResult<ProductTypeDto>> GetManageListPaging(ManageProductTypePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ProductTypeRequest request);

        Task<ApiResult<ProductTypeDto>> GetById(int productTypeId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class ProductTypeApiClient : BaseApiClient, IProductTypeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductTypeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<List<ProductTypeDto>>> GetAll(int languageId)
        {
            return await GetListAsync<ProductTypeDto>("/api/productTypes/GetAll?languageId=" + languageId);
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(ProductTypeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/productTypes/addorupdate", request);
        }
        public async Task<PagedResult<ProductTypeDto>> GetManageListPaging(ManageProductTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductTypeDto>>(
                $"/api/productTypes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                $"&StoreId={request.StoreId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<ProductTypeDto>> GetById(int productTypeId, int languageId)
        {
            var data = await GetAsync<ApiResult<ProductTypeDto>>($"/api/productTypes/{productTypeId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/productTypes/{string.Join("|", request.Ids)}");
        }
    }
}