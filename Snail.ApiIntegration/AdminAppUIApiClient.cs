using Snail.ViewModels.Common;
using Snail.ViewModels.Utilities.UI.AdminApp;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Snail.ApiIntegration
{
    public interface IAdminAppUIApiClient
    {
        Task<ApiResult<AdminAppLoginDto>> GetLoginObjects();
        Task<ApiResult<AdminAppHeaderDto>> GetHeaderObjects(AdminAppHeaderRequest request);
        Task<ApiResult<AdminAppLeftSideBarDto>> GetLeftSideBarObjects(AdminAppLeftSideBarRequest request);
    }
    public class AdminAppUIApiClient : BaseApiClient, IAdminAppUIApiClient
    {
        public AdminAppUIApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor,
                                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<ApiResult<AdminAppHeaderDto>> GetHeaderObjects(AdminAppHeaderRequest request)
        {
            return await GetAsync<ApiResult<AdminAppHeaderDto>>(
                $"/api/AdminAppUIs/getHeaderObjects?userName={request.UserName}"
            );
        }
        public async Task<ApiResult<AdminAppLoginDto>> GetLoginObjects()
        {
            return await GetAsync<ApiResult<AdminAppLoginDto>>(
                $"/api/AdminAppUIs/getLoginObjects"
            );
        }
        public async Task<ApiResult<AdminAppLeftSideBarDto>> GetLeftSideBarObjects(AdminAppLeftSideBarRequest request)
        {
            return await GetAsync<ApiResult<AdminAppLeftSideBarDto>>(
                $"/api/AdminAppUIs/getLeftSideBarObjects?languageId={request.LanguageId}&UserId={request.UserId}"
            );
        }
    }
}
