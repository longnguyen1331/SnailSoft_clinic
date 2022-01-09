using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.System.Languages;
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
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageDto>>> GetAll();
        Task<PagedResult<LanguageDto>> GetManageListPaging(ManageLanguagePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(LanguageRequest request);
        Task<ApiResult<LanguageDto>> GetById(int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class LanguageApiClient : BaseApiClient, ILanguageApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public LanguageApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(LanguageRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/languages/addorupdate", request);
        }
        public async Task<ApiResult<List<LanguageDto>>> GetAll()
        {
            return await GetAsync<ApiResult<List<LanguageDto>>>("/api/languages");
        }
        public async Task<PagedResult<LanguageDto>> GetManageListPaging(ManageLanguagePagingRequest request)
        {
            var data = await GetAsync<PagedResult<LanguageDto>>(
                $"/api/languages/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<LanguageDto>> GetById(int languageId)
        {
            var data = await GetAsync<ApiResult<LanguageDto>>($"/api/languages/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/languages/{string.Join("|", request.Ids)}");
        }
    }
}