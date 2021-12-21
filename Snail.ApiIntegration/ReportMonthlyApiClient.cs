using Snail.Utilities.Constants;
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
using Snail.ViewModels.Accountants.PhieuKeToans;

namespace Snail.ApiIntegration
{
    public interface IReportMonthlyApiClient
    {
        Task<PagedResult<ReportMonthlyDto>> GetReport(ManageReportMonthlyPagingRequest request);
    }
    public class ReportMonthlyApiClient : BaseApiClient, IReportMonthlyApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ReportMonthlyApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<PagedResult<ReportMonthlyDto>> GetReport(ManageReportMonthlyPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ReportMonthlyDto>>(
                $"/api/ReportMonthlys/GetReport?StoreId={request.StoreId}" +
                $"&Year={request.Year}");

            return data;
        }
       
    }
}
