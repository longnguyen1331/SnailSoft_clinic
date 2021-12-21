using Snail.ViewModels.Common;
using Snail.ViewModels.Website.WebsiteUIs;
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
    public interface IWebsiteUIApiClient
    {
        Task<ApiResult<WebsiteUIDto>> GetTopHeaderObjects(WebsiteUIRequest request);
        Task<ApiResult<WebsiteUIDto>> GetFooterObjects(WebsiteUIRequest request);
    }
    public class WebsiteUIApiClient : BaseApiClient, IWebsiteUIApiClient
    {
        public WebsiteUIApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor,
                                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }
        public async Task<ApiResult<WebsiteUIDto>> GetTopHeaderObjects(WebsiteUIRequest request)
        {
            return await GetAsync<ApiResult<WebsiteUIDto>>($"/api/WebsiteUIs/GetTopHeaderObjects?LanguageId={request.LanguageId}");
        }
        public async Task<ApiResult<WebsiteUIDto>> GetFooterObjects(WebsiteUIRequest request)
        {
            return await GetAsync<ApiResult<WebsiteUIDto>>($"/api/WebsiteUIs/GetFooterObjects?LanguageId={request.LanguageId}");
        }
    }
}
