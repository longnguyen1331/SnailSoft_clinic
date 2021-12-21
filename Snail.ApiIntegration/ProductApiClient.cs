using Snail.Utilities.Constants;
using Snail.ViewModels.Catalog.ProductImages;
using Snail.ViewModels.Catalog.Products;
using Snail.ViewModels.Catalog.ProductSKUs;
using Snail.ViewModels.Common;
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
    public interface IProductApiClient
    {
        Task<PagedResult<ProductDto>> GetProductPagings(ManageProductPagingRequest request);

        Task<ApiResult<bool>> ProductTypeAssign(int productId, ProductTypeAssignRequest request);

        Task<ProductDto> GetProductById(int productId, int languageId);

        Task<ApiResult<List<ProductDto>>> GetFeaturedProducts(int languageId, int take);

        Task<ApiResult<List<ProductDto>>> GetLatestProducts(int languageId, int take);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<int>> AddOrUpdateAsync(ProductRequest request);

        Task<PagedResult<ProductDto>> GetManageListPaging(ManageProductPagingRequest request);
        Task<List<ProductSKU_AttributeValueDto>> GetSKU_AttributeById(int id, int languageId);
        Task<ApiResult<ProductImageDto>> UploadFile(IFormFile uploadFile);
        Task<ApiResult<string>> ImportExcel(ProductImportRequest request);
        Task<ApiResult<List<ProductSKUDto>>> ImportExcelPrint(ProductImportRequest request);
        Task<ApiResult<string>> PrintQRCode(PrintQRCodeRequest request);
        Task<bool> DeleteFileQRCode(string link);
        
    }
    public class ProductApiClient : BaseApiClient, IProductApiClient
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public ProductApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<ProductSKU_AttributeValueDto>> GetSKU_AttributeById(int id, int languageId)
        {
            var data = await GetAsync<List<ProductSKU_AttributeValueDto>>(
              $"/api/products/GetAttributeById?productId={id}" +
              $"&LanguageId={languageId}");

            return data;
        }

        public async Task<ApiResult<int>> AddOrUpdateAsync(ProductRequest request)
        {
            return await BaseAddOrUpdateAsync($"/api/products/addorupdate", request);
        }


        public async Task<ApiResult<string>> PrintQRCode(PrintQRCodeRequest request)
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
                var response = await client.PostAsync($"/api/products/PrintQRCode", content);
                return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }

        public async Task<bool> DeleteFileQRCode(string link)
        {
            try
            {
                var data = await GetAsync<bool>(
                $"/api/products/DeleteFileQRCode?link={link}");

                return data;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<PagedResult<ProductDto>> GetManageListPaging(ManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductDto>>(
                $"/api/products/GetManageListPaging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&LanguageId={request.LanguageId}" +
                $"&StoreId={request.StoreId}" +
                (!string.IsNullOrEmpty(request.OrderCol) ? ($"&OrderCol={request.OrderCol}" + $"&OrderDir={request.OrderDir}") : "") +
                (!string.IsNullOrEmpty(request.TextSearch) ? $"&TextSearch={request.TextSearch}" : ""));

            return data;
        }

      


        public async Task<PagedResult<ProductDto>> GetProductPagings(ManageProductPagingRequest request)
        {
            var data = await GetAsync<PagedResult<ProductDto>>(
                $"/api/products/paging?pageIndex={request.PageIndex}" +
                $"&pageSize={request.PageSize}" +
                $"&keyword={request.TextSearch}&languageId={request.LanguageId}&categoryId={request.ProductTypeId}");

            return data;
        }

        public async Task<ApiResult<bool>> ProductTypeAssign(int productId, ProductTypeAssignRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var sessions = _httpContextAccessor.HttpContext.Session.GetString("Token");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", sessions);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PutAsync($"/api/products/{productId}/categories", httpContent);
            var result = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);

            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }

        public async Task<ProductDto> GetProductById(int productId, int languageId)
        {
            var data = await GetAsync<ProductDto>($"/api/products/{productId}/{languageId}");

            return data;
        }

        public async Task<ApiResult<List<ProductDto>>> GetFeaturedProducts(int languageId, int take)
        {
            var data = await GetListAsync<ProductDto>($"/api/products/featured/{languageId}/{take}");
            return data;
        }

        public async Task<ApiResult<List<ProductDto>>> GetLatestProducts(int languageId, int take)
        {
            var data = await GetListAsync<ProductDto>($"/api/products/latest/{languageId}/{take}");
            return data;
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            return await BaseDeleteByIds($"/api/products/{string.Join("|", request.Ids)}");
        }


        public async Task<ApiResult<ProductImageDto>> UploadFile(IFormFile uploadFile)
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

                var response = await client.PostAsync($"/api/products/uploadfile", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<ProductImageDto>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<ProductImageDto>(ex.Message);
            }

        }


        public async Task<ApiResult<string>> ImportExcel(ProductImportRequest request)
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
                client.Timeout = new TimeSpan(0, 0, 10, 0, 0);

                var requestContent = new MultipartFormDataContent();

                if (request.File != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.File.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.File.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "File", request.File.FileName);
                }

                if (!string.IsNullOrEmpty(request.CreatedUserId.ToString()))
                {
                    requestContent.Add(new StringContent(request.CreatedUserId.ToString()), "CreatedUserId");
                }

                if (!string.IsNullOrEmpty(request.StoreId.ToString()))
                {
                    requestContent.Add(new StringContent(request.StoreId.ToString()), "StoreId");
                }

                if (!string.IsNullOrEmpty(request.LanguageId.ToString()))
                {
                    requestContent.Add(new StringContent(request.LanguageId.ToString()), "LanguageId");
                }


                var response = await client.PostAsync($"/api/products/importexcel", requestContent);

                 return JsonConvert.DeserializeObject<ApiResult<string>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }

        }


        public async Task<ApiResult<List<ProductSKUDto>>> ImportExcelPrint(ProductImportRequest request)
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
                client.Timeout = new TimeSpan(0, 0, 10, 0, 0);

                var requestContent = new MultipartFormDataContent();

                if (request.File != null)
                {
                    byte[] data;
                    using (var br = new BinaryReader(request.File.OpenReadStream()))
                    {
                        data = br.ReadBytes((int)request.File.OpenReadStream().Length);
                    }
                    ByteArrayContent bytes = new ByteArrayContent(data);
                    requestContent.Add(bytes, "File", request.File.FileName);
                }

                if (!string.IsNullOrEmpty(request.CreatedUserId.ToString()))
                {
                    requestContent.Add(new StringContent(request.CreatedUserId.ToString()), "CreatedUserId");
                }

                if (!string.IsNullOrEmpty(request.StoreId.ToString()))
                {
                    requestContent.Add(new StringContent(request.StoreId.ToString()), "StoreId");
                }

                if (!string.IsNullOrEmpty(request.LanguageId.ToString()))
                {
                    requestContent.Add(new StringContent(request.LanguageId.ToString()), "LanguageId");
                }


                var response = await client.PostAsync($"/api/products/importexcelprint", requestContent);

                return JsonConvert.DeserializeObject<ApiResult<List<ProductSKUDto>>>(await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<List<ProductSKUDto>>(ex.Message);
            }

        }
    }
}