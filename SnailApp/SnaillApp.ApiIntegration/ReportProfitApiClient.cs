using SnailApp.Utilities.Constants;
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
using SnailApp.ViewModels.Accountants.PhieuKeToans;

namespace SnailApp.ApiIntegration
{
    public interface IReportProfitApiClient
    {
        Task<PagedResult<ReportProfitDto>> GetReport(ManageReportProfitPagingRequest request);
    }
    public class ReportProfitApiClient : BaseApiClient, IReportProfitApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ReportProfitApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<PagedResult<ReportProfitDto>> GetReport(ManageReportProfitPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ReportProfitDto>>(
                $"/api/ReportProfits/GetReport?StoreId={request.StoreId}" +
                $"&FromDate={request.FromDate}" +
                $"&PageSize={request.PageSize}" +
                $"&PageIndex={request.PageIndex}" +
                $"&ToDate={request.ToDate}");

            return data;
        }
       
    }
}
