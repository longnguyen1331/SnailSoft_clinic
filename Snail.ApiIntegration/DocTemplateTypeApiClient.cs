using Snail.Utilities.Constants;
using Snail.ViewModels.Catalog.DocTemplateTypes;
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
    public interface IDocTemplateTypeApiClient
    {
        Task<PagedResult<DocTemplateTypeDto>> GetManageListPaging(ManageDocTemplateTypePagingRequest request);
        Task<PagedResult<DocTemplateTypeDto>> GetAll(ManageDocTemplateTypePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(DocTemplateTypeRequest request);

        Task<ApiResult<DocTemplateTypeDto>> GetById(int docTemplateTypeId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class DocTemplateTypeApiClient : BaseApiClient, IDocTemplateTypeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public DocTemplateTypeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(DocTemplateTypeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/docTemplateTypes/addorupdate", request);
        }

        public async Task<PagedResult<DocTemplateTypeDto>> GetManageListPaging(ManageDocTemplateTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<DocTemplateTypeDto>>(
                $"/api/docTemplateTypes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<DocTemplateTypeDto>> GetAll(ManageDocTemplateTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<DocTemplateTypeDto>>(
                $"/api/docTemplateTypes/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<DocTemplateTypeDto>> GetById(int docTemplateTypeId, int languageId)
        {
            var data = await GetAsync<ApiResult<DocTemplateTypeDto>>($"/api/docTemplateTypes/{docTemplateTypeId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/docTemplateTypes/{string.Join("|", request.Ids)}");
        }
    }
}
