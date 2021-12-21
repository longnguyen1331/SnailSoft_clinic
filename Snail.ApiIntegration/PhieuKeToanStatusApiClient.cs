using Snail.Utilities.Constants;
using Snail.ViewModels.System.Statuses.PhieuKeToanStatus;
using Snail.ViewModels.Common;
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
    public interface IPhieuKeToanStatusApiClient
    {
        Task<PagedResult<PhieuKeToanStatusDto>> GetManageListPaging(ManagePhieuKeToanStatusPagingRequest request);
        Task<PagedResult<PhieuKeToanStatusDto>> GetAll(ManagePhieuKeToanStatusPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(PhieuKeToanStatusRequest request);

        Task<ApiResult<PhieuKeToanStatusDto>> GetById(int phieuKeToanStatusId, int languageId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PhieuKeToanStatusApiClient : BaseApiClient, IPhieuKeToanStatusApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PhieuKeToanStatusApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(PhieuKeToanStatusRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/phieuKeToanStatuses/addorupdate", request);
        }

        public async Task<PagedResult<PhieuKeToanStatusDto>> GetManageListPaging(ManagePhieuKeToanStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PhieuKeToanStatusDto>>(
                $"/api/phieuKeToanStatuses/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<PhieuKeToanStatusDto>> GetAll(ManagePhieuKeToanStatusPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PhieuKeToanStatusDto>>(
                $"/api/phieuKeToanStatuses/GetAll?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<PhieuKeToanStatusDto>> GetById(int phieuKeToanStatusId, int languageId)
        {
            var data = await GetAsync<ApiResult<PhieuKeToanStatusDto>>($"/api/phieuKeToanStatuses/{phieuKeToanStatusId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/phieuKeToanStatuses/{string.Join("|", request.Ids)}");
        }
    }
}
