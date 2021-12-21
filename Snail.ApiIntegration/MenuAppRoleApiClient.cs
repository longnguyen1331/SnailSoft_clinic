using Snail.Utilities.Constants;
using Snail.ViewModels.Common;
using Snail.ViewModels.System.MenuAppRoles;
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
    public interface IMenuAppRoleApiClient
    {
        Task<ApiResult<List<MenuAppRoleDto>>> GetAll(ManageMenuAppRolePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(MenuAppRoleRequest request);
    }
    public class MenuAppRoleApiClient : BaseApiClient, IMenuAppRoleApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public MenuAppRoleApiClient(IHttpClientFactory httpClientFactory,
                    IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(MenuAppRoleRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/menuapproles/addorupdate", request);
        }
        public async Task<ApiResult<List<MenuAppRoleDto>>> GetAll(ManageMenuAppRolePagingRequest request)
        {
            var data = await GetListAsync<MenuAppRoleDto>(
                $"/api/menuapproles/getall?" +
                (!string.IsNullOrEmpty(request.AppRoleId) ? $"AppRoleId={request.AppRoleId}" : "") +
                (request.MenuId != null ? $"MenuId={request.MenuId.Value}" : "") +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
    }
}
