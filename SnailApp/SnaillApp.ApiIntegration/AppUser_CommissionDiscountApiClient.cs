using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Sales.AppUser_CommissionDiscounts;
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

namespace SnailApp.ApiIntegration
{
    public interface IAppUser_CommissionDiscountApiClient
    {
        Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListPaging(ManageAppUser_CommissionDiscountPagingRequest request);
        Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListDetailPaging(ManageAppUser_CommissionDiscountPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(AppUser_CommissionDiscountRequest request);
        Task<ApiResult<AppUser_CommissionDiscountDto>> GetById(AppUser_CommissionDiscountRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);    }
    public class AppUser_CommissionDiscountApiClient : BaseApiClient, IAppUser_CommissionDiscountApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public AppUser_CommissionDiscountApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(AppUser_CommissionDiscountRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/appUser_commissiondiscounts/addorupdate", request);
        }

        public async Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListPaging(ManageAppUser_CommissionDiscountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUser_CommissionDiscountDto>>(
                $"/api/appUser_commissiondiscounts/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : "") +
                (!string.IsNullOrEmpty(request.AppUserId) ? $"&AppUserId={request.AppUserId}" : ""));

            return data;
        }
        public async Task<PagedResult<AppUser_CommissionDiscountDto>> GetManageListDetailPaging(ManageAppUser_CommissionDiscountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUser_CommissionDiscountDto>>(
                $"/api/appUser_commissiondiscounts/GetManageListDetailPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : "") +
                (!string.IsNullOrEmpty(request.AppUserId) ? $"&AppUserId={request.AppUserId}" : "") +
                (!string.IsNullOrEmpty(request.FilterByFromDate) ? $"&FilterByFromDate={request.FilterByFromDate}" : "") +
                (!string.IsNullOrEmpty(request.FilterByToDate) ? $"&FilterByToDate={request.FilterByToDate}" : ""));
            
            return data;
        }        
        public async Task<PagedResult<AppUser_CommissionDiscountDto>> GetAll(ManageAppUser_CommissionDiscountPagingRequest request)
        {
            var data = await GetAsync<PagedResult<AppUser_CommissionDiscountDto>>(
                $"/api/appUser_commissiondiscounts/getall?LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }
        public async Task<ApiResult<AppUser_CommissionDiscountDto>> GetById(AppUser_CommissionDiscountRequest request)
        {
            var data = await GetAsync<ApiResult<AppUser_CommissionDiscountDto>>($"/api/appUser_commissiondiscounts/getbyid?Id={request.Id}&LanguageId{request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/appUser_commissiondiscounts/{string.Join("|", request.Ids)}");
        }
    }
}
