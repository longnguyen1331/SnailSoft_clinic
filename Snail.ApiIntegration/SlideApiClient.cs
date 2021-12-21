using Snail.Utilities.Constants;
using Snail.ViewModels.Utilities.Slides;
using Snail.ViewModels.Common;
using Snail.ViewModels.Catalog.ProductTypes;
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
    public interface ISlideApiClient
    {
        Task<PagedResult<SlideDto>> GetManageListPaging(ManageSlidePagingRequest request);
        Task<ApiResult<List<SlideDto>>> GetPublicAll(PublicSlidePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(SlideRequest request);
        Task<ApiResult<SlideDto>> GetById(SlideRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class SlideApiClient : BaseApiClient, ISlideApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public SlideApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(SlideRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/slides/addorupdate", request);
        }

        public async Task<PagedResult<SlideDto>> GetManageListPaging(ManageSlidePagingRequest request)
        {
            var data = await GetAsync<PagedResult<SlideDto>>(
                $"/api/slides/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<List<SlideDto>>> GetPublicAll(PublicSlidePagingRequest request)
        {
            var data = await GetPublicAsync<ApiResult<List<SlideDto>>>(
                $"/api/slides/getpublicall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<SlideDto>> GetById(SlideRequest request)
        {
            var data = await GetAsync<ApiResult<SlideDto>>($"/api/slides/getbyid?slideId={request.Id}&languageId={request.LanguageId}");

            return data;
        }
        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/slides/{string.Join("|", request.Ids)}");
        }
    }
}