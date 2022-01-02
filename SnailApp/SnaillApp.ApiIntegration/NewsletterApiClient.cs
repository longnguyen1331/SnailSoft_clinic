using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.News.Newsletters;
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
    public interface INewsletterApiClient
    {
        Task<PagedResult<NewsletterDto>> GetManageListPaging(ManageNewsletterPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(NewsletterRequest request);

        Task<ApiResult<NewsletterDto>> GetById(NewsletterRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<int>> PublicAddOrUpdateAsync(NewsletterRequest request);
    }
    public class NewsletterApiClient : BaseApiClient, INewsletterApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public NewsletterApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(NewsletterRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/newsletters/addorupdate", request);
        }
        public async Task<ApiResult<int>> PublicAddOrUpdateAsync(NewsletterRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/newsletters/publicaddorupdate", request);
        }
        public async Task<PagedResult<NewsletterDto>> GetManageListPaging(ManageNewsletterPagingRequest request)
        {
            var data = await GetAsync<PagedResult<NewsletterDto>>(
                $"/api/newsletters/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<NewsletterDto>> GetById(NewsletterRequest request)
        {
            var data = await GetAsync<ApiResult<NewsletterDto>>($"/api/newsletters/getbyid?Id={request.Id}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/newsletters/{string.Join("|", request.Ids)}");
        }
    }
}
