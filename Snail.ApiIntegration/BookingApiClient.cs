using Snail.Utilities.Constants;
using Snail.ViewModels.Sales.Bookings;
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
    public interface IBookingApiClient
    {
        Task<PagedResult<BookingDto>> GetManageListPaging(ManageBookingPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(BookingRequest request);

        Task<ApiResult<BookingDto>> GetById(BookingRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<int>> PublicAddOrUpdateAsync(BookingRequest request);
    }
    public class BookingApiClient : BaseApiClient, IBookingApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public BookingApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(BookingRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/bookings/addorupdate", request);
        }
        public async Task<ApiResult<int>> PublicAddOrUpdateAsync(BookingRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/bookings/publicaddorupdate", request);
        }
        
        public async Task<PagedResult<BookingDto>> GetManageListPaging(ManageBookingPagingRequest request)
        {
            var data = await GetAsync<PagedResult<BookingDto>>(
                $"/api/bookings/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<BookingDto>> GetById(BookingRequest request)
        {
            var data = await GetAsync<ApiResult<BookingDto>>($"/api/bookings/getbyid?Id={request.Id}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/bookings/{string.Join("|", request.Ids)}");
        }
    }
}
