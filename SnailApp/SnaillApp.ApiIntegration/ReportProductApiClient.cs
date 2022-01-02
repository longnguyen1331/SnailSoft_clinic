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
    public interface IReportProductApiClient
    {
        Task<PagedResult<ReportWarehouseDto>> GetReport(ManageReportWarehousePagingRequest request);
        Task<PagedResult<ReportWarehouseDto>> GetTotalReport(ManageReportWarehousePagingRequest request);
    }
    public class ReportProductApiClient : BaseApiClient, IReportProductApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ReportProductApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

       
        public async Task<PagedResult<ReportWarehouseDto>> GetReport(ManageReportWarehousePagingRequest request)
        {
            var data = await GetAsync<PagedResult<ReportWarehouseDto>>(
                $"/api/ReportProducts/GetReport?StoreId={request.StoreId}" +
                $"&LanguageId={request.LanguageId}" +
                $"&PageIndex={request.PageIndex}" +
                $"&PageSize={request.PageSize}" +
                $"&FromDate={request.FromDate}" +
                $"&ToDate={request.ToDate}");

            return data;
        }

        public async Task<PagedResult<ReportWarehouseDto>> GetTotalReport(ManageReportWarehousePagingRequest request)
        {
            var data = await GetAsync<PagedResult<ReportWarehouseDto>>(
                $"/api/ReportProducts/GetTotalReport?StoreId={request.StoreId}" +
                $"&LanguageId={request.LanguageId}" +
                $"&PageIndex={request.PageIndex}" +
                $"&PageSize={request.PageSize}" +
                $"&FromDate={request.FromDate}" +
                $"&ToDate={request.ToDate}");

            return data;
        }

    }
}
