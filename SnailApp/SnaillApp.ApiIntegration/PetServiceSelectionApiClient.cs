using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Catalog.PetServiceSelections;
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
    public interface IPetServiceSelectionApiClient
    {
        Task<ApiResult<List<PetServiceSelectionDto>>> GetAll(ManagePetServiceSelectionPagingRequest request);
        Task<ApiResult<List<PetServiceSelectionDto>>> GetPublicAll(ManagePetServiceSelectionPagingRequest request);
        Task<PagedResult<PetServiceSelectionDto>> GetManageListPaging(ManagePetServiceSelectionPagingRequest request);
        Task<ApiResult<int>> AddOrUpdateAsync(PetServiceSelectionRequest request);

        Task<ApiResult<PetServiceSelectionDto>> GetById(PetServiceSelectionRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
    }
    public class PetServiceSelectionApiClient : BaseApiClient, IPetServiceSelectionApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public PetServiceSelectionApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<ApiResult<List<PetServiceSelectionDto>>> GetAll(ManagePetServiceSelectionPagingRequest request)
        {
            return await GetListAsync<PetServiceSelectionDto>($"/api/petserviceselections/getall?languageId={request.LanguageId}");
        }
        public async Task<ApiResult<List<PetServiceSelectionDto>>> GetPublicAll(ManagePetServiceSelectionPagingRequest request)
        {
            return await GetListAsync<PetServiceSelectionDto>($"/api/petserviceselections/getpublicall?languageId={request.LanguageId}");
        }
        public async Task<ApiResult<int>> AddOrUpdateAsync(PetServiceSelectionRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/petserviceselections/addorupdate", request);
        }
        public async Task<PagedResult<PetServiceSelectionDto>> GetManageListPaging(ManagePetServiceSelectionPagingRequest request)
        {
            var data = await GetAsync<PagedResult<PetServiceSelectionDto>>(
                $"/api/petServiceSelections/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

        public async Task<ApiResult<PetServiceSelectionDto>> GetById(PetServiceSelectionRequest request)
        {
            var data = await GetAsync<ApiResult<PetServiceSelectionDto>>($"/api/petserviceselections/getbyid?Id={request.Id}&LanguageId={request.LanguageId}");

            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/petserviceselections/{string.Join("|", request.Ids)}");
        }
    }
}
