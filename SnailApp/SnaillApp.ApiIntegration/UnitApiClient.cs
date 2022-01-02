using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Units;
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
    public interface IUnitApiClient
    {
         Task<PagedResult<UnitDto>> GetManageListPaging(ManageUnitPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(UnitRequest request);

        Task<ApiResult<UnitDto>> GetById(int unitId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class UnitApiClient : BaseApiClient, IUnitApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public UnitApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(UnitRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/units/addorupdate", request);
        }
        public async Task<PagedResult<UnitDto>> GetManageListPaging(ManageUnitPagingRequest request)
        {
            var data = await GetAsync<PagedResult<UnitDto>>(
                $"/api/units/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<UnitDto>> GetById(int unitId, int languageId)
        {
            var data = await GetAsync<ApiResult<UnitDto>>($"/api/units/{unitId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/units/{string.Join("|", request.Ids)}");
        }
    }
}
