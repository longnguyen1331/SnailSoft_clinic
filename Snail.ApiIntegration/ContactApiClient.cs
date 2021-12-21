using Snail.Utilities.Constants;
using Snail.ViewModels.Sales.Contacts;
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
    public interface IContactApiClient
    {
        Task<PagedResult<ContactDto>> GetManageListPaging(ManageContactPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ContactRequest request);

        Task<ApiResult<ContactDto>> GetById(ContactRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<int>> PublicAddOrUpdateAsync(ContactRequest request);
    }
    public class ContactApiClient : BaseApiClient, IContactApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ContactApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(ContactRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/contacts/addorupdate", request);
        }
        public async Task<ApiResult<int>> PublicAddOrUpdateAsync(ContactRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/contacts/publicaddorupdate", request);
        }
        public async Task<PagedResult<ContactDto>> GetManageListPaging(ManageContactPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ContactDto>>(
                $"/api/contacts/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<ContactDto>> GetById(ContactRequest request)
        {
            var data = await GetAsync<ApiResult<ContactDto>>($"/api/contacts/getbyid?Id={request.Id}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/contacts/{string.Join("|", request.Ids)}");
        }
    }
}
