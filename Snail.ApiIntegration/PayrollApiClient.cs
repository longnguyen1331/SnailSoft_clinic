using Snail.Utilities.Constants;
using Snail.ViewModels.HR.Payrolls;
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
    public interface IPayrollApiClient
    {
        Task<PagedResult<PayrollDto>> GetManageListPaging(ManagePayrollPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(PayrollRequest request);
        Task<ApiResult<PayrollDto>> GetById(PayrollRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<int>> CalculatePayroll(PayrollRequest request);
    }
    public class PayrollApiClient : BaseApiClient, IPayrollApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PayrollApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(PayrollRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/payrolls/addorupdate", request);
        }
        public async Task<PagedResult<PayrollDto>> GetManageListPaging(ManagePayrollPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PayrollDto>>(
                $"/api/payrolls/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<PayrollDto>> GetById(PayrollRequest request)
        {
            var data = await GetAsync<ApiResult<PayrollDto>>($"/api/payrolls/getbyid?Id={request.Id}&LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/payrolls/{string.Join("|", request.Ids)}");
        }
        public async Task<ApiResult<int>> CalculatePayroll(PayrollRequest request)
        {
            try
            {
                var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppConstants.Token);

                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration[SystemConstants.AppConstants.BaseAddress]);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

                string strPayload = JsonConvert.SerializeObject(request);
                HttpContent content = new StringContent(strPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"/api/payrolls/calculatepayroll", content);
                return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        
    }
}
