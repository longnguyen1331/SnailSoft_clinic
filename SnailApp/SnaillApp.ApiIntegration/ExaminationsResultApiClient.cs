using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.ExaminationsResults;
using SnailApp.ViewModels.Catalog.Appointments;
using SnailApp.Utilities.Constants;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace SnailApp.ApiIntegration
{
    public interface IExaminationsResultApiClient
    {
        Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageExaminationsResulttPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ExaminationsResultRequest request);
        Task<ApiResult<ExaminationsResultDto>> GetById(ExaminationsResultRequest request);
        Task<ApiResult<ExaminationsResultDto>> GetByAppointmentId(ExaminationsResultRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);
    }
    public class ExaminationsResultApiClient : BaseApiClient, IExaminationsResultApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ExaminationsResultApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
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

                var response = await client.PostAsync($"/api/examinationsResults/ckeditoruploadfile", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(ExaminationsResultRequest request)
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
                requestContent.Add(new StringContent(request.Id.ToString()), "Id");
                requestContent.Add(new StringContent(request.AppointmentId.ToString()), "AppointmentId");
                requestContent.Add(new StringContent(request.ClinicId.ToString()), "ClinicId");
                if (request.DoctorAdvice != null) requestContent.Add(new StringContent(request.DoctorAdvice), "DoctorAdvice");
                if (request.Results != null) requestContent.Add(new StringContent(request.Results), "Results");
                if (request.Re_Examination != null) requestContent.Add(new StringContent(request.Re_Examination), "Re_Examination");
                if (request.ExaminationDate != null) requestContent.Add(new StringContent(request.ExaminationDate), "ExaminationDate");
                requestContent.Add(new StringContent(request.CreatedUserId.ToString()), "CreatedUserId");
                requestContent.Add(new StringContent(request.ModifiedUserId.ToString()), "ModifiedUserId");

                if (request.Examination_File != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.Examination_File.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.Examination_File.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "Examination_File", request.Examination_File.FileName);
                }


                var response = await client.PostAsync($"api/examinationsResults/addorupdate", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageExaminationsResulttPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppointmentDto>>(
                $"/api/examinationsResults/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&DoctorId={request.DoctorId}" +
                $"&ClinicId={request.ClinicId}" +
                $"&ToDate={request.ToDate}" +
                $"&FromDate={request.FromDate}" +
                $"&Status={request.Status}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
        public async Task<ApiResult<ExaminationsResultDto>> GetByAppointmentId(ExaminationsResultRequest request)
        {
            var data = await GetAsync<ApiResult<ExaminationsResultDto>>($"/api/examinationsResults/AppointmentId?AppointmentId={request.AppointmentId}");
            return data;
        }
        public async Task<ApiResult<ExaminationsResultDto>> GetById(ExaminationsResultRequest request)
        {
            var data = await GetAsync<ApiResult<ExaminationsResultDto>>($"/api/examinationsResults/examinationsResultId?Id={request.Id}");
            return data;
        }
        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/examinationsResults/{string.Join("|", request.Ids)}");
        }

    
    }
}
