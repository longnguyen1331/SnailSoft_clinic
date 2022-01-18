using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.Appointments;
using SnailApp.Utilities.Constants;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace SnailApp.ApiIntegration
{
    public interface IAppointment_ServiceApiClient
    {
        Task<PagedResult<Appointment_ServiceDto>> GetManageListPaging(ManageAppointment_ServicePagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(Appointment_ServiceRequest request);
        Task<ApiResult<Appointment_ServiceDto>> GetById(Appointment_ServiceRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);
    }
    public class Appointment_ServiceApiClient : BaseApiClient, IAppointment_ServiceApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public Appointment_ServiceApiClient(IHttpClientFactory httpClientFactory,
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

                var response = await client.PostAsync($"/api/appointment_Services/ckeditoruploadfile", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(Appointment_ServiceRequest request)
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
                if (request.ServiceResult != null) requestContent.Add(new StringContent(request.ServiceResult), "ServiceResult");
                if (request.Date != null) requestContent.Add(new StringContent(request.Date), "Date");
                requestContent.Add(new StringContent(request.CreatedUserId.ToString()), "CreatedUserId");
                requestContent.Add(new StringContent(request.ModifiedUserId.ToString()), "ModifiedUserId");
                requestContent.Add(new StringContent(request.IsDefault.ToString()), "IsDefault");
                
                if (request.ServiceFile != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.ServiceFile.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.ServiceFile.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "ServiceFile", request.ServiceFile.FileName);
                }

                var response = await client.PostAsync($"api/appointment_Services/addorupdate", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<Appointment_ServiceDto>> GetManageListPaging(ManageAppointment_ServicePagingRequest request)
        {
            var data = await GetAsync<PagedResult<Appointment_ServiceDto>>(
                $"/api/appointment_Services/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                $"&ClinicId={request.ClinicId}" +
                $"&ToDate={request.ToDate}" +
                $"&FromDate={request.FromDate}" +
                $"&Status={request.Status}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
   
        public async Task<ApiResult<Appointment_ServiceDto>> GetById(Appointment_ServiceRequest request)
        {
            var data = await GetAsync<ApiResult<Appointment_ServiceDto>>($"/api/appointment_Services/GetById?Id={request.Id}");
            return data;
        }
        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appointment_Services/{string.Join("|", request.Ids)}");
        }

    
    }
}
