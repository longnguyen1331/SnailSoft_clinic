using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Attributes;
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

    public interface IAttributeApiClient
    {
        Task<PagedResult<AttributeDto>> GetManageListPaging(ManageAttributePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(AttributeRequest request);

        Task<ApiResult<AttributeDto>> GetById(int attributeId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AttributeApiClient : BaseApiClient, IAttributeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AttributeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(AttributeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/attributes/addorupdate", request);
        }
        public async Task<PagedResult<AttributeDto>> GetManageListPaging(ManageAttributePagingRequest request)
        {
            var data = await GetAsync<PagedResult<AttributeDto>>(
                $"/api/attributes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<AttributeDto>> GetById(int attributeId, int languageId)
        {
            var data = await GetAsync<ApiResult<AttributeDto>>($"/api/attributes/{attributeId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/attributes/{string.Join("|", request.Ids)}");
        }
    }
}
