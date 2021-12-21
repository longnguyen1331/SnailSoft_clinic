using Snail.Utilities.Constants;
using Snail.ViewModels.HR.PayrollDetails;
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
    public interface IPayrollDetailApiClient
    {
        Task<PagedResult<PayrollDetailDto>> GetManageListPaging(ManagePayrollDetailPagingRequest request);
    }
    public class PayrollDetailApiClient : BaseApiClient, IPayrollDetailApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PayrollDetailApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<PagedResult<PayrollDetailDto>> GetManageListPaging(ManagePayrollDetailPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PayrollDetailDto>>(
                $"/api/payrollDetails/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : "") +
                (!string.IsNullOrEmpty(request.AppUserId) ? $"&AppUserId={request.AppUserId}" : "") +
                (request.PayrollId != null ? $"&PayrollId={request.PayrollId.Value}" : ""));

            return data;
        }
    }
}
