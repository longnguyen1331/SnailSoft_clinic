using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Clinics;
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
    public interface IClinicApiClient
    {
        Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ClinicRequest request);
        Task<ApiResult<ClinicDto>> GetById(ClinicRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class ClinicApiClient : BaseApiClient, IClinicApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ClinicApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(ClinicRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/clinics/addorupdate", request);
        }

        public async Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ClinicDto>>(
                $"/api/clinics/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
     
        public async Task<ApiResult<ClinicDto>> GetById(ClinicRequest request)
        {
            var data = await GetAsync<ApiResult<ClinicDto>>($"/api/clinics/ClinicId?Id={request.Id}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/clinics/{string.Join("|", request.Ids)}");
        }
    }
}
