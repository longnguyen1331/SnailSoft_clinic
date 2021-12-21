using Snail.Utilities.Constants;
using Snail.ViewModels.Common;
using Snail.ViewModels.HR.AppUser_BasicSalaries;
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
    public interface IAppUser_BasicSalaryApiClient
    {
        Task<PagedResult<AppUser_BasicSalaryDto>> GetManageListPaging(ManageAppUser_BasicSalaryPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(AppUser_BasicSalaryRequest request);

        Task<ApiResult<AppUser_BasicSalaryDto>> GetById(AppUser_BasicSalaryRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class AppUser_BasicSalaryApiClient : BaseApiClient, IAppUser_BasicSalaryApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppUser_BasicSalaryApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(AppUser_BasicSalaryRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/appUser_basicsalaries/addorupdate", request);
        }

        public async Task<PagedResult<AppUser_BasicSalaryDto>> GetManageListPaging(ManageAppUser_BasicSalaryPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUser_BasicSalaryDto>>(
                $"/api/appUser_basicsalaries/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : "") +
                (!string.IsNullOrEmpty(request.AppUserId) ? $"&AppUserId={request.AppUserId}" : ""));

            return data;
        }
        public async Task<PagedResult<AppUser_BasicSalaryDto>> GetAll(ManageAppUser_BasicSalaryPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUser_BasicSalaryDto>>(
                $"/api/appUser_basicsalaries/getall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<AppUser_BasicSalaryDto>> GetById(AppUser_BasicSalaryRequest request)
        {
            var data = await GetAsync<ApiResult<AppUser_BasicSalaryDto>>($"/api/appUser_basicsalaries/getbyid?Id={request.Id}&LanguageId{request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appUser_basicsalaries/{string.Join("|", request.Ids)}");
        }
    }
}
