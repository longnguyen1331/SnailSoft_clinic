using Snail.Utilities.Constants;
using Snail.ViewModels.System.Statuses.ProductTypeStatus;
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
    public interface IProductTypeStatusApiClient
    {
        Task<PagedResult<ProductTypeStatusDto>> GetManageListPaging(ManageProductTypeStatusPagingRequest request);
        Task<PagedResult<ProductTypeStatusDto>> GetAll(ManageProductTypeStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(ProductTypeStatusRequest request);

        Task<ApiResult<ProductTypeStatusDto>> GetById(int productTypeStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class ProductTypeStatusApiClient : BaseApiClient, IProductTypeStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductTypeStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(ProductTypeStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/productTypeStatuses/addorupdate", request);
        }

        public async Task<PagedResult<ProductTypeStatusDto>> GetManageListPaging(ManageProductTypeStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductTypeStatusDto>>(
                $"/api/productTypeStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<ProductTypeStatusDto>> GetAll(ManageProductTypeStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductTypeStatusDto>>(
                $"/api/productTypeStatuses/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<ProductTypeStatusDto>> GetById(int productTypeStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<ProductTypeStatusDto>>($"/api/productTypeStatuses/{productTypeStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/productTypeStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
