using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.Clinics;
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
using SnailApp.ViewModels.System.User_Clinics;

namespace SnailApp.ApiIntegration
{
    public interface IClinicApiClient
    {
        Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ClinicRequest request);
        Task<ApiResult<ClinicDto>> GetById(ClinicRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);


        Task<PagedResult<User_ClinicDto>> GetUserByClinicIdManageListPaging(ManageUser_ClinicPagingRequest request);
        Task<ApiResult<int>> AddUserToClinic(User_ClinicDto request);
        Task<ApiResult<int>> DeleteUserFromClinic(User_ClinicDeleteRequest request);
        Task<List<User_ClinicDto>> GetClinicByUser(ManageUser_ClinicPagingRequest request);

    }
    public class ClinicApiClient : BaseApiClient, IClinicApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ClinicApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        //public async Task<ApiResult<int>> AddOrUpdateAsync(ClinicRequest request)
        //{
        //    return await BaseAddOrUpdateAsync($"/api/clinics/addorupdate", request);
        //}

        public async Task<ApiResult<int>> AddOrUpdateAsync(ClinicRequest request)
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

                if (request.Logo != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.Logo.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.Logo.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "Logo", request.Logo.FileName);
                }

                requestContent.Add(new StringContent(request.SortOrder.ToString()), "SortOrder");
                if(request.Code != null) requestContent.Add(new StringContent(request.Code), "Code");
                if(request.Name != null) requestContent.Add(new StringContent(request.Name), "Name");
                if(request.StartDate != null) requestContent.Add(new StringContent(request.StartDate), "StartDate");
                if(request.ExpirationDate != null) requestContent.Add(new StringContent(request.ExpirationDate), "ExpirationDate");
                requestContent.Add(new StringContent(request.CreatedUserId.ToString()), "CreatedUserId");
                requestContent.Add(new StringContent(request.ModifiedUserId.ToString()), "ModifiedUserId");
                if(request.PrimaryColor != null) requestContent.Add(new StringContent(request.PrimaryColor), "PrimaryColor");
                if(request.SecondaryColor != null) requestContent.Add(new StringContent(request.SecondaryColor), "SecondaryColor");
                if(request.Introduction != null) requestContent.Add(new StringContent(request.Introduction), "Introduction");
                if(request.Address != null) requestContent.Add(new StringContent(request.Address), "Address");
                if(request.Email != null) requestContent.Add(new StringContent(request.Email), "Email");
                if(request.Phone != null) requestContent.Add(new StringContent(request.Phone), "Phone");
                if(request.GoogleScript != null) requestContent.Add(new StringContent(request.GoogleScript), "GoogleScript");
                if(request.FacebookPixel != null) requestContent.Add(new StringContent(request.FacebookPixel), "FacebookPixel");
                if(request.FacebookChat != null) requestContent.Add(new StringContent(request.FacebookChat), "FacebookChat");
                if(request.Firebase_apiKey != null) requestContent.Add(new StringContent(request.Firebase_apiKey), "Firebase_apiKey");
                if(request.Firebase_authDomain != null) requestContent.Add(new StringContent(request.Firebase_authDomain), "Firebase_authDomain");
                if(request.Firebase_projectId != null) requestContent.Add(new StringContent(request.Firebase_projectId), "Firebase_projectId");
                if(request.Firebase_storageBucket != null) requestContent.Add(new StringContent(request.Firebase_storageBucket), "Firebase_storageBucket");
                if(request.Firebase_messagingSenderId != null) requestContent.Add(new StringContent(request.Firebase_messagingSenderId), "Firebase_messagingSenderId");
                if(request.Firebase_appId != null) requestContent.Add(new StringContent(request.Firebase_appId), "Firebase_appId");
                if(request.Firebase_measurementId != null) requestContent.Add(new StringContent(request.Firebase_measurementId), "Firebase_measurementId");
                if(request.ClinicDomain != null) requestContent.Add(new StringContent(request.ClinicDomain), "ClinicDomain");
                if(request.FacebookAppname != null) requestContent.Add(new StringContent(request.FacebookAppname), "FacebookAppname");
                if(request.FacebookAppid != null) requestContent.Add(new StringContent(request.FacebookAppid), "FacebookAppid");
                if(request.FacebookAppsecret != null) requestContent.Add(new StringContent(request.FacebookAppsecret), "FacebookAppsecret");
                requestContent.Add(new StringContent(request.FacebookLogin.ToString()), "FacebookLogin");
                requestContent.Add(new StringContent(request.GoogleLogin.ToString()), "GoogleLogin");
                if(request.GoogleAppname != null) requestContent.Add(new StringContent(request.GoogleAppname), "GoogleAppname");
                if(request.GoogleApikey != null) requestContent.Add(new StringContent(request.GoogleApikey), "GoogleApikey");
                if(request.GoogleClientid != null) requestContent.Add(new StringContent(request.GoogleClientid), "GoogleClientid");
                if(request.GoogleClientsecret != null) requestContent.Add(new StringContent(request.GoogleClientsecret), "GoogleClientsecret");
                requestContent.Add(new StringContent(request.Status.ToString()), "Status");
                var response = await client.PostAsync($"api/clinics/addorupdate", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<int>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<PagedResult<ClinicDto>> GetManageListPaging(ManageClinicPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ClinicDto>>(
                $"/api/clinics/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" + 
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}" ): "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }
     
        public async Task<ApiResult<ClinicDto>> GetById(ClinicRequest request)
        {
            var data = await GetAsync<ApiResult<ClinicDto>>($"/api/clinics/ClinicId?Id={request.Id}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/clinics/{string.Join("|", request.Ids)}");
        }

        public async Task<ApiResult<int>> AddUserToClinic(User_ClinicDto request)
        {
            return await BaseAddOrUpdateAsync($"/api/clinics/addusertoclinic", request);
        }

        public async Task<PagedResult<User_ClinicDto>> GetUserByClinicIdManageListPaging(ManageUser_ClinicPagingRequest request)
        {
            var data = await GetAsync<PagedResult<User_ClinicDto>>(
                $"/api/clinics/GetUserByClinicIdManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&ClinicId={request.ClinicId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }

        public async Task<ApiResult<int>> DeleteUserFromClinic(User_ClinicDeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/clinics/deleteuserfromclinic/{string.Join("|", request.Ids)}");
        }


        public async Task<List<User_ClinicDto>> GetClinicByUser(ManageUser_ClinicPagingRequest request)
        {
            var data = await GetAsync<List<User_ClinicDto>>(
                $"/api/clinics/GetClinicByUser?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&UserId={request.UserId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));
            return data;
        }

    }
}
