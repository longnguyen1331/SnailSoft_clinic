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
    public interface IReportWarehouseApiClient
    {
        Task<PagedResult<ReportWarehouseDto>> GetReport(ManageReportWarehousePagingRequest request);
    }
    public class ReportWarehouseApiClient : BaseApiClient, IReportWarehouseApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ReportWarehouseApiClient(IHttpClientFactory httpClientFactory,
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
                $"/api/ReportWarehouses/GetReport?StoreId={request.StoreId}" +
                $"&PageIndex={request.PageIndex}" +
                $"&PageSize={request.PageSize}" +
                $"&ToDate={request.ToDate}");

            return data;
        }
       
    }
}
