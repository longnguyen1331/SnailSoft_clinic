﻿using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.ExaminationsResults;
using SnailApp.ViewModels.Catalog.Appointments;

namespace SnailApp.ApiIntegration
{
    public interface IExaminationsResultApiClient
    {
        Task<PagedResult<AppointmentDto>> GetManageListPaging(ManageExaminationsResulttPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ExaminationsResultRequest request);
        Task<ApiResult<ExaminationsResultDto>> GetById(ExaminationsResultRequest request);
        Task<ApiResult<ExaminationsResultDto>> GetByAppointmentId(ExaminationsResultRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
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

      
        public async Task<ApiResult<int>> AddOrUpdateAsync(ExaminationsResultRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/examinationsResults/addorupdate", request);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>() { IsSuccessed = false, Message = ex.Message };
            }
        }

        public async Task<ApiResult<int>> ChangeStatus(ExaminationsResultRequest request)
        {
            try
            {
                return await BaseAddOrUpdateAsync($"/api/examinationsResults/changeStatus", request);
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
            var data = await GetAsync<ApiResult<ExaminationsResultDto>>($"/api/examinationsResults/appointmentId?Id={request.Id}");
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
