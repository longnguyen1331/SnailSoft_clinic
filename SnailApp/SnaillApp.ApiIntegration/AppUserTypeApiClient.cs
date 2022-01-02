using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.AppUserTypes;
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
    public interface IAppUserTypeApiClient
    {
        Task<ApiResult<List<AppUserTypeDto>>> GetAll(ManageAppUserTypePagingRequest request);
        Task<PagedResult<AppUserTypeDto>> GetManageListPaging(ManageAppUserTypePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(AppUserTypeRequest request);

        Task<ApiResult<AppUserTypeDto>> GetById(int appUserTypeId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AppUserTypeApiClient : BaseApiClient, IAppUserTypeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppUserTypeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<List<AppUserTypeDto>>> GetAll(ManageAppUserTypePagingRequest request)
        {
            return await GetListAsync<AppUserTypeDto>($"/api/categoryofposts/getAll?languageId={request.LanguageId}");
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(AppUserTypeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/appUserTypes/addorupdate", request);
        }
        public async Task<PagedResult<AppUserTypeDto>> GetManageListPaging(ManageAppUserTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUserTypeDto>>(
                $"/api/appUserTypes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<AppUserTypeDto>> GetById(int appUserTypeId, int languageId)
        {
            var data = await GetAsync<ApiResult<AppUserTypeDto>>($"/api/appUserTypes/{appUserTypeId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appUserTypes/{string.Join("|", request.Ids)}");
        }
    }
}
