using Snail.Utilities.Constants;
using Snail.ViewModels.Catalog.PostTypes;
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
    public interface IPostTypeApiClient
    {
        Task<ApiResult<List<PostTypeDto>>> GetAll(ManagePostTypePagingRequest request);
        Task<PagedResult<PostTypeDto>> GetManageListPaging(ManagePostTypePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(PostTypeRequest request);

        Task<ApiResult<PostTypeDto>> GetById(PostTypeRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PostTypeApiClient : BaseApiClient, IPostTypeApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PostTypeApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<List<PostTypeDto>>> GetAll(ManagePostTypePagingRequest request)
        {
            return await GetListAsync<PostTypeDto>($"/api/posttypes/getall?languageId={request.LanguageId}");
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(PostTypeRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/posttypes/addorupdate", request);
        }
        public async Task<PagedResult<PostTypeDto>> GetManageListPaging(ManagePostTypePagingRequest request)
        {
            var data = await GetAsync<PagedResult<PostTypeDto>>(
                $"/api/postTypes/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<PostTypeDto>> GetById(PostTypeRequest request)
        {
            var data = await GetAsync<ApiResult<PostTypeDto>>($"/api/posttypes/getbyid?Id={request.Id}&LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/posttypes/{string.Join("|", request.Ids)}");
        }
    }
}
