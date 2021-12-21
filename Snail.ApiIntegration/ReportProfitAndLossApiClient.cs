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
    public interface IReportProfitAndLossApiClient
    {
        Task<PagedResult<ReportProfitAndLossDto>> GetReport(ManageReportProfitAndLossPagingRequest request);
    }
    public class ReportProfitAndLossApiClient : BaseApiClient, IReportProfitAndLossApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ReportProfitAndLossApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<PagedResult<ReportProfitAndLossDto>> GetReport(ManageReportProfitAndLossPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ReportProfitAndLossDto>>(
                $"/api/ReportProfitAndLosss/GetReport?StoreId={request.StoreId}" +
                $"&FromDate={request.FromDate}" +
                $"&PageSize={request.PageSize}" +
                $"&PageIndex={request.PageIndex}" +
                $"&FromDatePast={request.FromDatePast}" +
                $"&ToDatePast={request.ToDatePast}" +
                $"&ToDate={request.ToDate}");

            return data;
        }
       
    }
}
