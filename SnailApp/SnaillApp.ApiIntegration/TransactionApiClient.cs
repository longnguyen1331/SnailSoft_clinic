using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Sales.Transactions;
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
    public interface ITransactionApiClient
    {
        Task<PagedResult<TransactionDto>> GetManageListPaging(ManageTransactionPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(TransactionRequest request);

        Task<ApiResult<TransactionDto>> GetById(int transactionId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class TransactionApiClient : BaseApiClient, ITransactionApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public TransactionApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(TransactionRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/transactions/addorupdate", request);
        }
        public async Task<PagedResult<TransactionDto>> GetManageListPaging(ManageTransactionPagingRequest request)
        {
            var data = await GetAsync<PagedResult<TransactionDto>>(
                $"/api/transactions/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<TransactionDto>> GetById(int transactionId)
        {
            var data = await GetAsync<ApiResult<TransactionDto>>($"/api/transactions/{transactionId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/transactions/{string.Join("|", request.Ids)}");
        }
    }
}
