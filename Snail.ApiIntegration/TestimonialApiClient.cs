using Snail.Utilities.Constants;
using Snail.ViewModels.News.Testimonials;
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
    public interface ITestimonialApiClient
    {
        Task<PagedResult<TestimonialDto>> GetManageListPaging(ManageTestimonialPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(TestimonialRequest request);
        Task<ApiResult<TestimonialDto>> GetById(TestimonialRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<List<TestimonialDto>>> GetPublicAll(ManageTestimonialPagingRequest request);
        Task<ApiResult<string>> DeleteImageByTestimonialId(int testimonialId);
    }
    public class TestimonialApiClient : BaseApiClient, ITestimonialApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public TestimonialApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(TestimonialRequest request)
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

                if (request.Image != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.Image.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.Image.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "image", request.Image.FileName);
                }

                if (!string.IsNullOrEmpty(request.Code))
                {
                    requestContent.Add(new StringContent(request.Code), "code");
                }

                if (!string.IsNullOrEmpty(request.Name))
                {
                    requestContent.Add(new StringContent(request.Name), "name");
                }

                if (!string.IsNullOrEmpty(request.Description))
                {
                    requestContent.Add(new StringContent(request.Description), "description");
                }

                if (!string.IsNullOrEmpty(request.CreatedUserId))
                {
                    requestContent.Add(new StringContent(request.CreatedUserId), "createdUserId");
                }

                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    requestContent.Add(new StringContent(request.ModifiedUserId), "modifiedUserId");
                }

                var response = await client.PostAsync($"/api/testimonials/addorupdate", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<PagedResult<TestimonialDto>> GetManageListPaging(ManageTestimonialPagingRequest request)
        {
            var data = await GetAsync<PagedResult<TestimonialDto>>(
                $"/api/testimonials/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<TestimonialDto>> GetById(TestimonialRequest request)
        {
            var data = await GetAsync<ApiResult<TestimonialDto>>($"/api/testimonials/getbyid?Id={request.Id}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/testimonials/{string.Join("|", request.Ids)}");
        }
        public async Task<ApiResult<List<TestimonialDto>>> GetPublicAll(ManageTestimonialPagingRequest request)
        {
            var data = await GetListAsync<TestimonialDto>(
                $"/api/testimonials/getpublicall?" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : ""));

            return data;
        }
        public async Task<ApiResult<string>> DeleteImageByTestimonialId(int testimonialId)
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

                var response = await client.DeleteAsync($"/api/testimonials/deleteimagebytestimonialid/{testimonialId}");
                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
    }
}
