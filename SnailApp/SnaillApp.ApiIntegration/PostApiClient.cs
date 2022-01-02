using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.News.Posts;
using SnailApp.ViewModels.Common;
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
    public interface IPostApiClient
    {
        Task<PagedResult<PostDto>> GetManageListPaging(ManagePostPagingRequest request);
        
        Task<ApiResult<int>> AddOrUpdateAsync(PostRequest request);
        Task<ApiResult<PostDto>> GetById(PostRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);
        Task<ApiResult<int>> RemoveImages(DeleteRequest request);
        Task<ApiResult<string>> DeleteThumbnailImageByPostId(int postId);
        Task<PagedResult<PostDto>> GetPublicListPaging(PublicPostPagingRequest request);
        Task<ApiResult<PublicPostDetailDto>> GetPublicById(PostRequest request);
    }
    public class PostApiClient : BaseApiClient, IPostApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PostApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(PostRequest request)
        {
            try
            {
                var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppConstants.Token);

                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration[SystemConstants.AppConstants.BaseAddress]);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

                var requestContent = new MultipartFormDataContent();

                if (request.Id != null)
                {
                    requestContent.Add(new StringContent(request.Id.Value.ToString()), "id");
                }

                if (request.ThumbnailImage != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.ThumbnailImage.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.ThumbnailImage.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "thumbnailImage", request.ThumbnailImage.FileName);
                }

                if (!string.IsNullOrEmpty(request.Name))
                {
                    requestContent.Add(new StringContent(request.Name), "name");
                }

                if (!string.IsNullOrEmpty(request.Author))
                {
                    requestContent.Add(new StringContent(request.Author), "author");
                }                

                if (!string.IsNullOrEmpty(request.Abstract))
                {
                    requestContent.Add(new StringContent(request.Abstract), "abstract");
                }

                if (!string.IsNullOrEmpty(request.Content))
                {
                    requestContent.Add(new StringContent(request.Content), "content");
                }

                if (!string.IsNullOrEmpty(request.SeoDescription))
                {
                    requestContent.Add(new StringContent(request.SeoDescription), "seoDescription");
                }

                if (!string.IsNullOrEmpty(request.SeoTitle))
                {
                    requestContent.Add(new StringContent(request.SeoTitle), "seoTitle");
                }

                if (!string.IsNullOrEmpty(request.SeoAlias))
                {
                    requestContent.Add(new StringContent(request.SeoAlias), "seoAlias");
                }

                if (request.PostTypeId != null)
                {
                    requestContent.Add(new StringContent(request.PostTypeId.Value.ToString()), "postTypeId");
                }

                if (request.PostStatusId != null)
                {
                    requestContent.Add(new StringContent(request.PostStatusId.Value.ToString()), "postStatusId");
                }

                if (!string.IsNullOrEmpty(request.CreatedUserId))
                {
                    requestContent.Add(new StringContent(request.CreatedUserId), "createdUserId");
                }

                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    requestContent.Add(new StringContent(request.ModifiedUserId), "modifiedUserId");
                }
                                
                requestContent.Add(new StringContent(request.LanguageId.ToString()), "languageId");

                var response = await client.PostAsync($"/api/posts/addorupdate", requestContent);
                
                return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<PagedResult<PostDto>> GetManageListPaging(ManagePostPagingRequest request)
        {
            return await GetAsync<PagedResult<PostDto>>(
                           $"/api/posts/GetManageListPaging?pageIndex={request.PageIndex}" +
                           $"&pageSize={request.PageSize}&LanguageId={request.LanguageId}" +
                           $"&PostTypeAlias={request.PostTypeAlias}" +
                           $"&PostTypeId={request.PostTypeId}" +
                           (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                           (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
        }

        public async Task<PagedResult<PostDto>> GetPublicListPaging(PublicPostPagingRequest request)
        {
            return await GetPublicAsync<PagedResult<PostDto>>(
                $"/api/posts/getpubliclistpaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&LanguageId={request.LanguageId}" +
                $"&PostTypeAlias={request.PostTypeAlias}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
        }
        public async Task<ApiResult<PostDto>> GetById(PostRequest request)
        {
            return await GetAsync<ApiResult<PostDto>>($"/api/posts/getbyid?Id={request.Id}&LanguageId={request.LanguageId}");
        }

        public async Task<ApiResult<PublicPostDetailDto>> GetPublicById(PostRequest request)
        {
            return await GetPublicAsync<ApiResult<PublicPostDetailDto>>($"/api/posts/getpublicbyid?Id={request.Id}&LanguageId={request.LanguageId}");
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/posts/{string.Join("|", request.Ids)}");
        }
        public async Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile)
        {
            try
            {
                var sessions = _httpContextAccessor
                .HttpContext
                .Session
                .GetString(SystemConstants.AppConstants.Token);

                var languageId = _httpContextAccessor.HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId);

                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration[SystemConstants.AppConstants.BaseAddress]);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

                var requestContent = new MultipartFormDataContent();

                if (uploadFile != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(uploadFile.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)uploadFile.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "uploadFile", uploadFile.FileName);
                }

                var response = await client.PostAsync($"/api/posts/ckeditoruploadfile", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> RemoveImages(DeleteRequest request)
        {
            try
            {
                return await BaseDeleteByIds($"/api/posts/removeimages/{string.Join("|", request.Ids)}");
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<ApiResult<string>> DeleteThumbnailImageByPostId(int postId)
        {
            try
            {
                var sessions = _httpContextAccessor
               .HttpContext
               .Session
               .GetString(SystemConstants.AppConstants.Token);
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_configuration[SystemConstants.AppConstants.BaseAddress]);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

                var response = await client.DeleteAsync($"/api/posts/deletethumbnailimagebypostid/{postId}");
                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
    }
}
