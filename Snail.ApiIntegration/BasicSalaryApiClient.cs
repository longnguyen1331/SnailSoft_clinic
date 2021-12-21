using Snail.ViewModels.HR.BasicSalaries;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Snail.ApiIntegration
{
    public interface IBasicSalaryApiClient
    {
        Task<PagedResult<BasicSalaryDto>> GetManageListPaging(ManageBasicSalaryPagingRequest request);
        Task<PagedResult<BasicSalaryDto>> GetAll(ManageBasicSalaryPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(BasicSalaryRequest request);
        Task<ApiResult<BasicSalaryDto>> GetById(BasicSalaryRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class BasicSalaryApiClient : BaseApiClient, IBasicSalaryApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public BasicSalaryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(BasicSalaryRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/basicsalaries/addorupdate", request);
        }

        public async Task<PagedResult<BasicSalaryDto>> GetManageListPaging(ManageBasicSalaryPagingRequest request)
        {
            var data = await GetAsync<PagedResult<BasicSalaryDto>>(
                $"/api/basicsalaries/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<PagedResult<BasicSalaryDto>> GetAll(ManageBasicSalaryPagingRequest request)
        {
            var data = await GetAsync<PagedResult<BasicSalaryDto>>(
                $"/api/basicsalaries/geall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<BasicSalaryDto>> GetById(BasicSalaryRequest request)
        {
            var data = await GetAsync<ApiResult<BasicSalaryDto>>($"/api/basicsalaries/Id=request.Id&LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/basicsalaries/{string.Join("|", request.Ids)}");
        }
    }
}
