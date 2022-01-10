using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.HR.Payrolls;
using SnailApp.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ApiIntegration
{
    public interface IUserApiClient
    {
        Task<ApiResult<string>> Authenticate(LoginRequest request);
        Task<PagedResult<UserDto>> GetStaffManageListPaging(ManageUserPagingRequest request);
        Task<ApiResult<string>> AddOrUpdateStaffSecurity(UserRequest request);
        Task<ApiResult<string>> AddOrUpdateStaffProfileDetail(UserRequest request);
        Task<ApiResult<int>> DeleteByIds(UserDeleteRequest request);
        Task<ApiResult<UserDto>> GetAllRoleByUserId(UserRoleRequest request);
        Task<ApiResult<UserDto>> GetStaffProfileDetailByUserId(UserRequest request);
        Task<ApiResult<UserDto>> GetStaffSecurityByUserId(UserRequest request);
        Task<ApiResult<string>> DeleteAvatarByUserIdAsync(int userId);
        Task<ApiResult<int>> ChangePassword(ChangePasswordRequest rq);
    }
    public class UserApiClient : BaseApiClient, IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync("/api/users/authenticate", httpContent);
            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<string>>(await response.Content.ReadAsStringAsync());
            }

            return JsonConvert.DeserializeObject<ApiErrorResult<string>>(await response.Content.ReadAsStringAsync());
        }
        public async Task<ApiResult<int>> DeleteByIds(UserDeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/users/{string.Join("|", request.Ids)}");
        }
        public async Task<PagedResult<UserDto>> GetStaffManageListPaging(ManageUserPagingRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var url = $"/api/users/GetStaffManageListPaging?pageIndex={request.PageIndex}&pageSize={request.PageSize}&textSearch={request.TextSearch}&languageId={request.LanguageId}";
            if (request.Type.HasValue)
            {
                url += "&Type=" + request.Type.Value;
            }

            if (request.ClinicId.HasValue)
            {
                url += "&ClinicId=" + request.ClinicId.Value;
            }
            var response = await client.GetAsync(url);
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<PagedResult<UserDto>>(body);
            return users;
        }
 
     
        public async Task<ApiResult<string>> AddOrUpdateStaffSecurity(UserRequest request)
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

                string strPayload = JsonConvert.SerializeObject(request);
                HttpContent content = new StringContent(strPayload, Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"api/users/addorupdatestaffsecurity", content);
                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>() { IsSuccessed = false, Message = ex.Message };
            }
        }
  
        public async Task<ApiResult<string>> AddOrUpdateStaffProfileDetail(UserRequest request)
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
                    requestContent.Add(new StringContent(request.Id), "id");
                }


                if (request.Avatar != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.Avatar.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.Avatar.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "Avatar", request.Avatar.FileName);
                }


                if (!string.IsNullOrEmpty(request.FirstName))
                {
                    requestContent.Add(new StringContent(request.FirstName), "FirstName");
                }

                if (!string.IsNullOrEmpty(request.LastName))
                {
                    requestContent.Add(new StringContent(request.LastName), "LastName");
                }

                if (!string.IsNullOrEmpty(request.Dob))
                {
                    requestContent.Add(new StringContent(request.Dob), "Dob");
                }

                if (!string.IsNullOrEmpty(request.PhoneNumber))
                {
                    requestContent.Add(new StringContent(request.PhoneNumber), "PhoneNumber");
                }

                if (!string.IsNullOrEmpty(request.Email))
                {
                    requestContent.Add(new StringContent(request.Email), "Email");
                }

                requestContent.Add(new StringContent(request.GenderId != null ? request.GenderId.Value.ToString() : "-1"), "GenderId");
                requestContent.Add(new StringContent(request.IsActive.ToString()), "IsActive");

                if (!string.IsNullOrEmpty(request.AppRoleCodes))
                {
                    requestContent.Add(new StringContent(request.AppRoleCodes), "AppRoleCodes");
                }

                if (!string.IsNullOrEmpty(request.Address))
                {
                    requestContent.Add(new StringContent(request.Address), "Address");
                }

                if (!string.IsNullOrEmpty(request.CreatedUserId))
                {
                    requestContent.Add(new StringContent(request.CreatedUserId), "CreatedUserId");
                }

                if (!string.IsNullOrEmpty(request.Password))
                {
                    requestContent.Add(new StringContent(request.Password), "Password");
                }

                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    requestContent.Add(new StringContent(request.ModifiedUserId), "ModifiedUserId");
                }

                if (!string.IsNullOrEmpty(request.Biography))
                {
                    requestContent.Add(new StringContent(request.Biography), "Biography");
                }

                if (!string.IsNullOrEmpty(request.Skills))
                {
                    requestContent.Add(new StringContent(request.Skills), "Skills");
                }

                if (request.Type.HasValue)
                {
                    requestContent.Add(new StringContent(request.Type.Value.ToString()), "Type");
                }

                if (request.ClinicId.HasValue)
                {
                    requestContent.Add(new StringContent(request.ClinicId.Value.ToString()), "ClinicId");
                }
                if (request.ProvinceId.HasValue)
                {
                    requestContent.Add(new StringContent(request.ProvinceId.Value.ToString()), "ProvinceId");
                }

                if (request.DistrictId.HasValue)
                {
                    requestContent.Add(new StringContent(request.DistrictId.Value.ToString()), "DistrictId");
                }

                if (request.WardId.HasValue)
                {
                    requestContent.Add(new StringContent(request.WardId.Value.ToString()), "WardId");
                }

                if (request.BloodId.HasValue)
                {
                    requestContent.Add(new StringContent(request.BloodId.Value.ToString()), "BloodId");
                }

                if (!string.IsNullOrEmpty(request.Proifle))
                {
                    requestContent.Add(new StringContent(request.Proifle), "Proifle");
                }

                var response = await client.PostAsync($"api/users/addorupdatestaff", requestContent);
                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>() { IsSuccessed = false, Message = ex.Message };
            }
        }
        public async Task<ApiResult<UserDto>> GetAllRoleByUserId(UserRoleRequest request)
        {
            var data = await GetAsync<ApiResult<UserDto>>($"/api/users/getrolesbyuserid?UserId={request.UserId}" +
                (request.LanguageId != null ? $"&LanguageId={ request.LanguageId}" : string.Empty)
            );

            return data;
        }
        public async Task<ApiResult<UserDto>> GetStaffProfileDetailByUserId(UserRequest request)
        {
            return await GetAsync<ApiResult<UserDto>>($"/api/users/getstaffprofiledetailbyuserid?id={request.Id}&LanguageId={ request.LanguageId}");
        }
        public async Task<ApiResult<UserDto>> GetStaffSecurityByUserId(UserRequest request)
        {
            return await GetAsync<ApiResult<UserDto>>($"/api/users/getstaffsecuritybyuserid?Id={request.Id}&LanguageId={ request.LanguageId}");
        }

        public async Task<ApiResult<int>> ChangePassword(ChangePasswordRequest request)
        {
            var sessions = _httpContextAccessor
               .HttpContext
               .Session
               .GetString(SystemConstants.AppConstants.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration[SystemConstants.AppConstants.BaseAddress]);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            string strPayload = JsonConvert.SerializeObject(request);
            HttpContent content = new StringContent(strPayload, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"api/users/changepassword", content);
            return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());

        }

        public async Task<ApiResult<string>> DeleteAvatarByUserIdAsync(int userId)
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

                var response = await client.DeleteAsync($"/api/users/deleteavatarbyuserid/{userId}");
                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
    }
}