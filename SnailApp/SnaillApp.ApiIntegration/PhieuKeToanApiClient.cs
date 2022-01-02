using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
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
using SnailApp.ViewModels.Accountants.PhieuKeToanChiTiets;

namespace SnailApp.ApiIntegration
{
    public interface IPhieuKeToanApiClient
    {
        Task<PagedResult<PhieuKeToanDto>> GetManageListCashBookPaging(ManagePhieuKeToanPagingRequest request);
        Task<PagedResult<PhieuKeToanDto>> GetManageListPaging(ManagePhieuKeToanPagingRequest request);
        Task<PagedResult<PhieuKeToanChiTietDto>> GetManageListDetailPaging(ManagePhieuKeToanPagingRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(PhieuKeToanRequest request);
        Task<ApiResult<int>> UpdateDescriptionAsync(Guid userId, int id, string des);

        Task<ApiResult<PhieuKeToanDto>> GetById(int phieuKeToanId);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PhieuKeToanApiClient : BaseApiClient, IPhieuKeToanApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PhieuKeToanApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(PhieuKeToanRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/phieuKeToans/addorupdate", request);
        }

        public async Task<ApiResult<int>> UpdateDescriptionAsync(Guid userId, int id, string des)
        {
            PhieuKeToanRequest request = new PhieuKeToanRequest() { 
                ModifiedUserId = userId,
                Id = id,
                Description = des
            };
            return await BaseAddOrUpdateAsync($"/api/phieuKeToans/updateDescriptionById", request);
        }


        public async Task<PagedResult<PhieuKeToanDto>> GetManageListPaging(ManagePhieuKeToanPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PhieuKeToanDto>>(
                $"/api/phieuKeToans/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&StoreId={request.StoreId}" +
                $"&CustomerId={request.CustomerId}" +
                $"&FromDate={request.FromDate}" +
                $"&SearchBy={request.SearchBy}" +
                $"&Todate={request.ToDate}" +
                $"&Type={request.Type}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<PagedResult<PhieuKeToanDto>> GetManageListCashBookPaging(ManagePhieuKeToanPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PhieuKeToanDto>>(
                $"/api/phieuKeToans/GetManageListCashBookPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&CustomerId={request.CustomerId}" +
                  $"&FromDate={request.FromDate}" +
                $"&Todate={request.ToDate}" +
                $"&StoreId={request.StoreId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<PagedResult<PhieuKeToanChiTietDto>> GetManageListDetailPaging(ManagePhieuKeToanPagingRequest request)
        {
            try
            {

                var data = await GetAsync<PagedResult<PhieuKeToanChiTietDto>>(
                    $"/api/phieuKeToans/GetManageListDetailPaging?pageIndex={request.PageIndex}" +
                    $"&pageSize={request.PageSize}" +
                    $"&StoreId={request.StoreId}" +
                    $"&PhieuKeToanId={request.PhieuKeToanId}" +
                    $"&Type={request.Type}" +
                    (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                    (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

                return data;

            }
            catch (Exception)
            {
                return null;

            }
        }




        public async Task<ApiResult<PhieuKeToanDto>> GetById(int phieuKeToanId)
        {
            var data = await GetAsync<ApiResult<PhieuKeToanDto>>($"/api/phieuKeToans/{phieuKeToanId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/phieuKeToans/{string.Join("|", request.Ids)}");
        }
    }
}
