using Snail.ViewModels.Website.WebsiteMenus;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Snail.ApiIntegration
{
    public interface IWebsiteMenuApiClient
    {
        Task<ApiResult<List<WebsiteMenuDto>>> GetAll(ManageWebsiteMenuPagingRequest request);
        Task<PagedResult<WebsiteMenuDto>> GetManageListPaging(ManageWebsiteMenuPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(WebsiteMenuRequest request);
        Task<ApiResult<WebsiteMenuDto>> GetById(WebsiteMenuRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class WebsiteMenuApiClient : BaseApiClient, IWebsiteMenuApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public WebsiteMenuApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<List<WebsiteMenuDto>>> GetAll(ManageWebsiteMenuPagingRequest request)
        {
            var data = await GetListAsync<WebsiteMenuDto>(
                $"/api/websiteMenus/getall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(WebsiteMenuRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/websiteMenus/addorupdate", request);
        }
        public async Task<PagedResult<WebsiteMenuDto>> GetManageListPaging(ManageWebsiteMenuPagingRequest request)
        {
            var data = await GetAsync<PagedResult<WebsiteMenuDto>>(
                $"/api/websiteMenus/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<WebsiteMenuDto>> GetById(WebsiteMenuRequest request)
        {
            var data = await GetAsync<ApiResult<WebsiteMenuDto>>($"/api/websiteMenus/getbyid?Id={request.Id}&LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/websiteMenus/{string.Join("|", request.Ids)}");
        }
    }
}
