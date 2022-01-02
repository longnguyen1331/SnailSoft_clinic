using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Manufacturers;
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
    public interface IManufacturerApiClient
    {

        Task<PagedResult<ManufacturerDto>> GetManageListPaging(ManageManufacturerPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ManufacturerRequest request);
        Task<ApiResult<ManufacturerDto>> GetById(int manufacturerId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class ManufacturerApiClient : BaseApiClient, IManufacturerApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ManufacturerApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(ManufacturerRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/manufacturers/addorupdate", request);
        }
        public async Task<PagedResult<ManufacturerDto>> GetManageListPaging(ManageManufacturerPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ManufacturerDto>>(
                $"/api/manufacturers/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<ManufacturerDto>> GetById(int manufacturerId, int languageId)
        {
            var data = await GetAsync<ApiResult<ManufacturerDto>>($"/api/manufacturers/{manufacturerId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/manufacturers/{string.Join("|", request.Ids)}");
        }
    }
}
