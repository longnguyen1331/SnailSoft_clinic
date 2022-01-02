using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.CustomerTypes;
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

    public interface ICustomerTypeApiClient
    {
        Task<PagedResult<CustomerTypeDto>> GetManageListPaging(ManageCustomerTypePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(CustomerTypeRequest request);

        Task<ApiResult<CustomerTypeDto>> GetById(int customerTypeId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class CustomerTypeApiClient : BaseApiClient, ICustomerTypeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public CustomerTypeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(CustomerTypeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/customerTypes/addorupdate", request);
        }
        public async Task<PagedResult<CustomerTypeDto>> GetManageListPaging(ManageCustomerTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<CustomerTypeDto>>(
                $"/api/customerTypes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<CustomerTypeDto>> GetById(int customerTypeId, int languageId)
        {
            var data = await GetAsync<ApiResult<CustomerTypeDto>>($"/api/customerTypes/{customerTypeId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/customerTypes/{string.Join("|", request.Ids)}");
        }
    }
}
