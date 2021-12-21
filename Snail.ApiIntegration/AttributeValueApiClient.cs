using Snail.Utilities.Constants;
using Snail.ViewModels.Catalog.AttributeValues;
using Snail.ViewModels.Common;
using Snail.ViewModels.Catalog.ProductTypes;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;
using Snail.ViewModels.Catalog.Attributes;

namespace Snail.ApiIntegration
{

    public interface IAttributeValueApiClient
    {
        Task<PagedResult<AttributeValueDto>> GetManageListPaging(ManageAttributeValuePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(AttributeValueRequest request);

        Task<ApiResult<AttributeValueDto>> GetById(int attributeId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AttributeValueApiClient : BaseApiClient, IAttributeValueApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AttributeValueApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(AttributeValueRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/attributevalues/addorupdate", request);
        }
        public async Task<PagedResult<AttributeValueDto>> GetManageListPaging(ManageAttributeValuePagingRequest request)
        {
            var data = await GetAsync<PagedResult<AttributeValueDto>>(
                $"/api/attributevalues/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&AttributeId={request.AttributeId}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<AttributeValueDto>> GetById(int attributeId, int languageId)
        {
            var data = await GetAsync<ApiResult<AttributeValueDto>>($"/api/attributevalues/{attributeId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/attributevalues/{string.Join("|", request.Ids)}");
        }
    }
}
