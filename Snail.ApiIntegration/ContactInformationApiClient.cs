using Snail.Utilities.Constants;
using Snail.ViewModels.System.ContactInformation;
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
    public interface IContactInformationApiClient
    {
        Task<PagedResult<ContactInformationDto>> GetManageListPaging(ManageContactInformationPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(ContactInformationRequest request);
        Task<ApiResult<ContactInformationDto>> GetById(ContactInformationRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ContactInformationDto>> GetPublicDefault();
    }
    public class ContactInformationApiClient : BaseApiClient, IContactInformationApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ContactInformationApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(ContactInformationRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/contactInformation/addorupdate", request);
        }
        public async Task<PagedResult<ContactInformationDto>> GetManageListPaging(ManageContactInformationPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ContactInformationDto>>(
                $"/api/contactInformation/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<ContactInformationDto>> GetById(ContactInformationRequest request)
        {
            return await GetAsync<ApiResult<ContactInformationDto>>($"/api/contactInformation/getbyid?Id={request.Id}");
        }
        public async Task<ApiResult<ContactInformationDto>> GetPublicDefault()
        {
            return await GetAsync<ApiResult<ContactInformationDto>>($"/api/contactInformation/GetDefault");
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/contactInformation/{string.Join("|", request.Ids)}");
        }
    }
}
