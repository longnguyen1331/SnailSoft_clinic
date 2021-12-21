using Snail.Utilities.Constants;
using Snail.ViewModels.Common;
using Snail.ViewModels.System.AppUser_AppUserTypes;
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
    public interface IAppUser_AppUserTypeApiClient
    {
        Task<ApiResult<List<AppUser_AppUserTypeDto>>> GetAll(ManageAppUser_AppUserTypePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(AppUser_AppUserTypeRequest request);
    }
    public class AppUser_AppUserTypeApiClient : BaseApiClient, IAppUser_AppUserTypeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppUser_AppUserTypeApiClient(IHttpClientFactory httpClientFactory,
                    IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(AppUser_AppUserTypeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/menuapproles/addorupdate", request);
        }
        public async Task<ApiResult<List<AppUser_AppUserTypeDto>>> GetAll(ManageAppUser_AppUserTypePagingRequest request)
        {
            var data = await GetListAsync<AppUser_AppUserTypeDto>(
                $"/api/menuapproles/getall?" +
                (!string.IsNullOrEmpty(request.AppUserId) ? $"AppUserId={request.AppUserId}" : "") +
                (request.AppUserTypeId != null ? $"AppUserTypeId={request.AppUserTypeId.Value}" : "") +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
    }
}
