using Snail.Utilities.Constants;
using Snail.ViewModels.System.DocTemplates;
using Snail.ViewModels.Common;
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
    public interface IDocTemplateApiClient
    {
        Task<PagedResult<DocTemplateDto>> GetManageListPaging(ManageDocTemplatePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(DocTemplateRequest request);
        Task<ApiResult<DocTemplateDto>> GetById(DocTemplateRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);

        Task<DocTemplateDto> GetContentByDocTemplateTypeCode(DocTemplateRequest rq);

    }
    public class DocTemplateApiClient : BaseApiClient, IDocTemplateApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public DocTemplateApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(DocTemplateRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/docTemplates/addorupdate", request);
        }
        public async Task<PagedResult<DocTemplateDto>> GetManageListPaging(ManageDocTemplatePagingRequest request)
        {
            var data = await GetAsync<PagedResult<DocTemplateDto>>(
                $"/api/docTemplates/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}&LanguageId={request.LanguageId}" +
                (request.DocTemplateTypeId != null ? ($"&DocTemplateTypeId={request.DocTemplateTypeId}") : "") +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<DocTemplateDto> GetContentByDocTemplateTypeCode(DocTemplateRequest rq)
        {
            var data = await GetAsync<DocTemplateDto>(
                $"/api/docTemplates/GetContentByDocTemplateTypeCode?DocTemplateCode={rq.DocTemplateCode}&StoreId={rq.StoreId}");
            return data;
        }

        public async Task<ApiResult<DocTemplateDto>> GetById(DocTemplateRequest request)
        {
            var data = await GetAsync<ApiResult<DocTemplateDto>>($"/api/docTemplates/getbyid?Id={request.Id}&LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/docTemplates/{string.Join("|", request.Ids)}");
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

                var response = await client.PostAsync($"/api/doctemplates/ckeditoruploadfile", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
            
        }
    }
}
