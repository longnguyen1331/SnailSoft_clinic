using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Catalog.ProductImages;
using SnailApp.ViewModels.Catalog.Products;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using BHSNetCoreLib;
using Microsoft.Data.SqlClient;
using System.Data;
using SnailApp.Data.SqlHelper;
using Microsoft.AspNetCore.Hosting;
using SnailApp.ViewModels.Catalog.ProductSKUs;
using Microsoft.AspNetCore.Server.IISIntegration;
using OfficeOpenXml;
using SelectPdf;
using QRCoder;
using SnailApp.Application.SystemApplication.DocTemplates;
using SnailApp.ViewModels.System.DocTemplates;
using System.Drawing;

namespace SnailApp.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<ApiResult<int>> CreateAsync(ProductRequest request);

        Task<ApiResult<int>> UpdateAsync(ProductRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);


        Task<ProductDto> GetById(int productId, int languageId);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductDto>> GetManageListPaging(ManageProductPagingRequest request);
        Task<List<ProductSKU_AttributeValueDto>> GetSKU_AttributeById(int productId, int languageId);
        Task<ApiResult<ProductImageDto>> UploadFile(IFormFile uploadFile);
        Task<ApiResult<string>> ImportExcel(ProductImportRequest request);
        Task<ApiResult<List<ProductSKUDto>>> ImportExcelPrint(ProductImportRequest request);
        Task<ApiResult<string>> PrintQRCode(PrintQRCodeRequest request);
        Task<bool> DeleteFileQRCode(string link);
    }
    
    public class ProductService : IProductService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly IDocTemplateService _docTemplateService;
        
        public ProductService(EShopDbContext context,
                            IFileStorageService storageService,
                            IWebHostEnvironment hostEnvironment,
                                IConfiguration configuration,
                                IDocTemplateService docTemplateService)
        {
            _context = context;
            _storageService = storageService;
            _hostEnvironment = hostEnvironment;
            _configuration = configuration;
            _docTemplateService = docTemplateService;
        }

        public async Task<int> AddImage(int productId, ProductImageCreateRequest request)
        {
            var productImage = new ProductImage()
            {
                Caption = request.Caption,
                CreatedDate = DateTime.Now,
                IsDefault = request.IsDefault,
                ProductId = productId,
                SortOrder = request.SortOrder
            };

            if (request.ImageFile != null)
            {
                var image = await this.SaveFile(request.ImageFile);
                productImage.Image = image.ImagePath;
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Add(productImage);
            await _context.SaveChangesAsync();
            return productImage.Id;
        }

        public async Task AddViewcount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<ApiResult<int>> CreateAsync(ProductRequest request)
        {
            try
            {
                var languages = _context.Languages;
                var translations = new List<ProductTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new ProductTranslation()
                        {
                            Name = request.Name,
                            Description = StringUtil.ToUrlFormat(request.Description),
                            Details = StringUtil.ToUrlFormat(request.Name),
                            SeoDescription = StringUtil.ToUrlFormat(request.Name),
                            SeoAlias = StringUtil.ToUrlFormat(request.Name),
                            SeoTitle = request.Name,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new ProductTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            SeoDescription = SystemConstants.AppConstants.NA,
                            SeoAlias = SystemConstants.AppConstants.NA,
                            SeoTitle = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }

                var product = new Product()
                {
                    Code = !request.IsHasSKU ? GetLastestSKUCode(1) : string.Empty,
                    Image = request.Image,
                    Price = request.Price,
                    OriginalPrice = request.OriginalPrice,
                    Stock = request.Stock,
                    ViewCount = 0,
                    IsFeatured = request.IsFeatured,
                    IsPOS = request.IsPOS,
                    IsWeb = request.IsWeb,
                    AllowSellWhenNotEnough = request.AllowSellWhenNotEnough,
                    InventoryWarning = request.InventoryWarning,
                    Url = StringUtil.ToUrlFormat(request.Name),
                    ProductTitle = request.Name,
                    IsHasSKU = request.IsHasSKU,
                    CreatedDate = DateTime.Now,
                    CreatedUserId = Guid.Parse(request.CreatedUserId),
                    ManufactuerId = request.ManufactuerId > 0 ? request.ManufactuerId : null,
                    ProductTranslations = translations
                };

                product.ProductSKUs = new List<ProductSKU>();

                if (request.ProductSKU_AttributeValues != null
                    && request.ProductSKU_AttributeValues.Count() > 0)
                {
                    int stt = 1;
                    foreach (var item in request.ProductSKU_AttributeValues)
                    {
                        var arrItem = item.AttributeValueIds.Split(",");
                        List<ProductSKU_AttributeValue> pa = new List<ProductSKU_AttributeValue>();

                        foreach (var attribu in arrItem)
                        {
                            int attribuIntValue = int.Parse(attribu);
                            var attribute = await _context.AttributeValues.FindAsync(attribuIntValue);

                            pa.Add(new ProductSKU_AttributeValue()
                            {
                                AttributeValue = attribute
                            });

                        }

                        string skuCode = string.Empty;
                        if (!string.IsNullOrEmpty(item.ProductSKUCode) && !await CheckExitSKUCode(item.ProductSKUCode))
                        {
                            skuCode = item.ProductSKUCode;
                        }
                        else
                        {
                            skuCode = GetLastestSKUCode(stt);
                        }

                        product.ProductSKUs.Add(new ProductSKU()
                        {
                            Code = skuCode,
                            Name =  item.ProductSKUName,
                            Price = item.Price,
                            QtyInStock = item.QtyInStock,
                            BuyingPrice = item.BuyingPrice,
                            ProductSKU_AttributeValues = pa
                        });
                        stt++;
                    }
                }
                else
                {
                    product.ProductSKUs.Add(new ProductSKU()
                    {
                        Code = product.Code,
                        Name = request.Name,
                        Price = (double)product.OriginalPrice,
                        QtyInStock = request.Stock,
                        BuyingPrice = (double)request.Price,
                        ProductSKU_AttributeValues = null
                    });
                }

                if (request.ProductInType != null && request.ProductInType.Count > 0)
                {
                    product.ProductInProductTypes = new List<ProductInProductType>();
                    foreach (int item in request.ProductInType)
                    {
                        product.ProductInProductTypes.Add(new ProductInProductType()
                        {
                            ProductTypeId = item,
                        });
                    }
                }

                product.ProductImages = new List<ProductImage>();

                if (!string.IsNullOrEmpty(request.Image))
                {
                    product.ProductImages.Add(new ProductImage()
                    {
                        Image = request.Image,
                        IsDefault = true
                    });
                }

                if (request.ProductImages != null)
                {
                    foreach (var item in request.ProductImages)
                    {
                        ProductImage image = new ProductImage();

                        if (item != null)
                        {
                            image.Image = item.ImagePath;
                            image.FileSize = item.FileSize;
                            image.IsDefault = false;
                            product.ProductImages.Add(image);
                        }
                    }
                }

                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(product.Id);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var products = await _context.Products.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (products == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                foreach(var item in products)
                {
                    item.IsDeleted = true;
                }

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<List<ProductSKU_AttributeValueDto>> GetSKU_AttributeById(int productId, int languageId)
        {
            try
            {
                #region FromSqlStoredProcedureSqlParameter
                string sqlCommand = "exec usp_GetProductAttributeByParams @productId, @languageId";

                SqlParameter[] param = new SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "productId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = productId
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "languageId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = languageId
                    }
                };


                return await SQLHelper.ExecuteScalarAsync<ProductSKU_AttributeValueDto>(_context, sqlCommand,
                    x => new ProductSKU_AttributeValueDto
                    {
                        Id = (int)x[0],
                        Code = (string)x[1],
                        Name = (string)x[2],
                        Price = (double)x[3],
                        BuyingPrice = (double)x[4],
                        QtyInStock = (int)x[5],
                        AttributeValueIds = (string)x[6],
                        AttributeValueName = (string)x[7],
                        AttributeIds = (string)x[8],
                        AttributeNames = (string)x[9]
                    }, param);
                #endregion
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<PagedResult<ProductDto>> GetManageListPaging(ManageProductPagingRequest request)
        {
            var pagedResult = new PagedResult<ProductDto>()
            {
                PageSize = request.PageSize,
                PageIndex = request.PageIndex
            };

            try
            {
                string stringFilter = string.Empty, orderBy = string.Empty;

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    {
                        stringFilter += " (pt.Name LIKE N'%" + request.TextSearch.ToLower() + "%')";
                        stringFilter += " OR (p.Code LIKE N'%" + request.TextSearch.ToLower() + "%')";
                    }

                if(!string.IsNullOrEmpty(request.OrderCol))
                    {
                        switch (request.OrderCol)
                        {
                            case "Id":
                            case "Price":
                            case "OriginalPrice":
                            case "Name":
                            case "Code":
                                orderBy = request.OrderCol + " " + request.OrderDir;
                                break;

                            default:
                                orderBy = request.OrderCol + " " + request.OrderDir;
                                break;
                        }
                    }

                List<ProductDto> products = new List<ProductDto>();
                int totalRecord = 0;
                #region FromSqlStoredProcedureSqlParameter
                string sqlCommand = "exec usp_GetProductByParams @filters, @languageId, @orderBy, @pageSize, @pageNumber, @totalRows OUTPUT";

                SqlParameter[] param = new SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "filters",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = "WHERE  p.IsDeleted = 0 " +  (!string.IsNullOrEmpty(request.TextSearch) ? " AND " +  stringFilter : string.Empty)
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "languageId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.LanguageId
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "orderBy",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = orderBy
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "pageSize",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.PageSize
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "pageNumber",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = (request.PageIndex.Value -1) * request.PageSize
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "totalRows",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output,
                        Value = 0
                    }
                };
                products = await SQLHelper.ExecuteScalarAsync<ProductDto>(_context, sqlCommand, 
                    x => new ProductDto
                {
                        Id = (int)x[0],
                        Code = (string)x[1],
                        Name = (string)x[2],
                        ThumbnailImage = (string)x[3],
                        Stock = (int)x[4],
                        Price = (decimal)x[5],
                        OriginalPrice = (decimal)x[6],
                        ProductTypeName = (string)x[7],
                        ProductTypeIds = (string)x[8],
                        ManufactuerId = (int?)x[9],
                        ManufactuerName = (string)x[10],
                        IsHasSKU = (bool)x[11],
                        LowerPrice = (double)x[12],
                        HigherPrice = (double)x[13],
                        InventoryWarning = (int?)x[14],
                        AllowSellWhenNotEnough = (bool)x[15],
                        Description = (string)x[16],
                        ProductImages = (string)x[17],
                        ProductImageSizes = (string)x[18]
                    }, param);


                totalRecord = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, param);
                totalRecord = Int32.Parse(param[5].Value.ToString());
                #endregion



                //4. Select and projection
                pagedResult.TotalRecords = totalRecord;
                pagedResult.Items = products;

                return pagedResult;
            }
            catch (Exception ex)
            {
                pagedResult.Message = ex.Message;
                pagedResult.Items = null;

                return pagedResult;
            }
        }

        public async Task<ProductDto> GetById(int productId, int languageId)
        {


            List<ProductDto> products = new List<ProductDto>();
            int totalRecord = 0;
            #region FromSqlStoredProcedureSqlParameter
            string sqlCommand = "exec usp_GetProductByParams @filters, @languageId, @orderBy, @pageSize, @pageNumber, @totalRows OUTPUT";

            SqlParameter[] param = new SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "filters",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value =   " WHERE (p.Id = " + productId + " )"
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "languageId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = languageId
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "orderBy",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = "Id desc"
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "pageSize",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = 1
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "pageNumber",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = 0
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "totalRows",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output,
                        Value = 0
                    }
                };
                products = await SQLHelper.ExecuteScalarAsync<ProductDto>(_context, sqlCommand,
                    x => new ProductDto
                    {
                       Id = (int)x[0],
                        Code = (string)x[1],
                        Name = (string)x[2],
                        ThumbnailImage = (string)x[3],
                        Stock = (int)x[4],
                        Price = (decimal)x[5],
                        OriginalPrice = (decimal)x[6],
                        ProductTypeName = (string)x[7],
                        ProductTypeIds = (string)x[8],
                        ManufactuerId = (int?)x[9],
                        ManufactuerName = (string)x[10],
                        IsHasSKU = (bool)x[11],
                        LowerPrice = (double)x[12],
                        HigherPrice = (double)x[13],
                        InventoryWarning = (int?)x[14],
                        AllowSellWhenNotEnough = (bool)x[15],
                        Description = (string)x[16],
                        ProductImages = (string)x[17],
                        ProductImageSizes = (string)x[18]
                    }, param);


            totalRecord = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, param);

            #endregion


            return products.Count() > 0 ? products.FirstOrDefault() : null;
        }

        public async Task<ProductImageDto> GetImageById(int imageId)
        {
            var image = await _context.ProductImages.FindAsync(imageId);
            if (image == null)
                throw new EShopException($"Cannot find an image with id {imageId}");

            var viewModel = new ProductImageDto()
            {
                Caption = image.Caption,
                CreatedDate = image.CreatedDate,
                FileSize = image.FileSize,
                Id = image.Id,
                ImagePath = _configuration[SystemConstants.ProductConstants.ProductImagePath] + "/" + image.Image,
                IsDefault = image.IsDefault,
                ProductId = image.ProductId,
                SortOrder = image.SortOrder
            };
            return viewModel;
        }

        public async Task<ApiResult<int>> UpdateAsync(ProductRequest request)
        {
            try
            {
                var product = await _context.Products.FindAsync(request.Id);
                var productTranslations = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == request.Id
                && x.LanguageId == request.LanguageId);

                if (product == null || productTranslations == null) throw new EShopException($"Cannot find a product with id: {request.Id}");

                productTranslations.Name = request.Name;
                productTranslations.SeoAlias = StringUtil.ToUrlFormat(request.Name);
                productTranslations.SeoDescription = request.SeoDescription;
                productTranslations.SeoTitle = request.SeoTitle;
                productTranslations.Description = request.Description;
                productTranslations.Details = request.Details;

                product.Image = request.Image;
                product.Price = request.Price;
                product.OriginalPrice = request.OriginalPrice;
                product.Stock = request.Stock;
                product.IsFeatured = request.IsFeatured;
                product.IsPOS = request.IsPOS;
                product.IsWeb = request.IsWeb;
                product.AllowSellWhenNotEnough = request.AllowSellWhenNotEnough;
                product.InventoryWarning = request.InventoryWarning;
                product.Url = StringUtil.ToUrlFormat(request.Name);
                product.ProductTitle = request.Name;
                product.IsHasSKU = request.IsHasSKU;
                product.ModifiedDate = DateTime.Now;
                product.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                product.ManufactuerId = request.ManufactuerId > 0 ? request.ManufactuerId :null;
                //product.ProductAttributes = new List<ProductAttribute>();
                product.ProductInProductTypes = new List<ProductInProductType>();
                product.ProductImages = new List<ProductImage>();

                //Xóa thông tin chung ảnh ,productintype, product attribute
                string sqlCommand = "exec usp_DeleteProductRelationships @productId";
                int removeRecord = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, 
                    new Microsoft.Data.SqlClient.SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "productId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value =  product.Id
                    }});

             

                //ProductInProductTypes
                if (request.ProductInType != null && request.ProductInType.Count > 0)
                {
                    foreach (int item in request.ProductInType)
                    {
                        product.ProductInProductTypes.Add(new ProductInProductType()
                        {
                            ProductTypeId = item,
                        });
                    }
                }

                //ProductImages
                if (!string.IsNullOrEmpty(request.Image))
                {
                    product.ProductImages.Add(new ProductImage()
                    {
                        Image = request.Image,
                        IsDefault = true
                    });
                }


                if (request.ProductImages != null)
                {
                    foreach (var item in request.ProductImages)
                    {
                        ProductImage image = new ProductImage();

                        if (item != null)
                        {
                            image.Image = item.ImagePath;
                            image.FileSize = item.FileSize;
                            image.IsDefault = false;
                            product.ProductImages.Add(image);
                        }
                    }
                }




                product.ProductSKUs = new List<ProductSKU>();
                if (request.ProductSKU_AttributeValues != null
                    && request.ProductSKU_AttributeValues.Count() > 0)
                {
                    int stt = 1;
                    foreach (var item in request.ProductSKU_AttributeValues)
                    {
                        var arrItem = item.AttributeValueIds.Split(",");
                        List<ProductSKU_AttributeValue> pa = new List<ProductSKU_AttributeValue>();

                        foreach (var attribu in arrItem)
                        {
                            int attribuIntValue = int.Parse(attribu);
                            var attribute = await _context.AttributeValues.FindAsync(attribuIntValue);

                            pa.Add(new ProductSKU_AttributeValue()
                            {
                                AttributeValue = attribute
                            });

                        }

                        string skuCode = string.Empty;
                        if (!string.IsNullOrEmpty(item.ProductSKUCode) && !await CheckExitSKUCode(item.ProductSKUCode))
                        {
                            skuCode = item.ProductSKUCode;
                        }
                        else
                        {
                            skuCode = GetLastestSKUCode(stt);
                        }

                        product.ProductSKUs.Add(new ProductSKU()
                        {
                            Code = skuCode,
                            Name = item.ProductSKUName,
                            Price = item.Price,
                            QtyInStock = item.QtyInStock,
                            BuyingPrice = item.BuyingPrice,
                            ProductSKU_AttributeValues = pa
                        });
                        stt++;
                    }
                }
                else
                {
                    product.ProductSKUs.Add(new ProductSKU()
                    {
                        Code = product.Code,
                        Name = request.Name,
                        Price = (double)product.OriginalPrice,
                        QtyInStock = request.Stock,
                        BuyingPrice = (double)request.Price,
                        ProductSKU_AttributeValues = null
                    });
                }
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(product.Id);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }

        }

        public async Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request)
        {
            var productImage = await _context.ProductImages.FindAsync(imageId);
            if (productImage == null)
                throw new EShopException($"Cannot find an image with id {imageId}");

            if (request.ImageFile != null)
            {
                var image = await this.SaveFile(request.ImageFile);
                productImage.Image = image.ImagePath;
                productImage.FileSize = request.ImageFile.Length;
            }
            _context.ProductImages.Update(productImage);
            return await _context.SaveChangesAsync();
        }

       
        private async Task<ProductImageDto> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = _configuration[SystemConstants.AppConstants.UploadProduct] + "/" + $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);

            ProductImageDto image = new ProductImageDto();
            image.ImagePath = fileName;
            image.FileSize = file.Length; 
            return image;
        }

        private string GetLastestCode()
        {
            int count = 0;

            count = _context.Products.OrderByDescending(x => x.Id).FirstOrDefault()
                   != null ?
                    _context.Products.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1 : 1;
            string result = count.ToString();
            int length = result.Length;

            for (int i = 1; i <= 7 - length; i++)
            {
                result = "0" + result;
            }
            return "HH" + result;
        }


        private string GetLastestSKUCode(int stt)
        {
            int count = 0;

            count = _context.ProductSKUs.OrderByDescending(x => x.Id).FirstOrDefault()
                   != null ?
                    _context.ProductSKUs.OrderByDescending(x => x.Id).FirstOrDefault().Id + (stt > 1 ? stt: 1) : 1;
            string result = count.ToString();
            int length = result.Length;

            for (int i = 1; i <= 7 - length; i++)
            {
                result = "0" + result;
            }
            return "SP" + result;
        }


        private async Task<bool> CheckExitSKUCode(string code)
        {
            return await _context.ProductSKUs.Where(x =>x.Code.ToLower() == code.ToLower()).CountAsync() > 0;
        }

        public async Task<ApiResult<ProductImageDto>> UploadFile(IFormFile uploadFile)
        {
            try
            {
                return new ApiSuccessResult<ProductImageDto>(await this.SaveFile(uploadFile));
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
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                var stream = request.File.OpenReadStream();
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;
                    Product product = null;
                    var translations = new List<ProductTranslation>();
                    var languages = _context.Languages;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        product = new Product(); Manufacturer manufacturer = new Manufacturer(); 
                        ProductType productType = new ProductType(); Data.Entities.Attribute attribute = new Data.Entities.Attribute();
                        AttributeValue attributeValue = new AttributeValue();  int productTypeParentId =0;
                        string attrbuteValueNameJoin = string.Empty;
                        string productName = worksheet.Cells[row, 1].Value != null ? worksheet.Cells[row, 1].Value.ToString().Trim() : string.Empty;
                        string productCode = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty;
                        decimal price = worksheet.Cells[row, 3].Value != null ? decimal.Parse(worksheet.Cells[row, 3].Value.ToString().Trim()) : 0;
                        decimal buyingPrice = worksheet.Cells[row, 4].Value != null ? decimal.Parse(worksheet.Cells[row, 4].Value.ToString().Trim()) : 0;
                        int quantity = worksheet.Cells[row, 5].Value != null ? int.Parse(worksheet.Cells[row, 5].Value.ToString().Trim()) : 0;
                        int warning = worksheet.Cells[row, 6].Value != null ? int.Parse(worksheet.Cells[row, 6].Value.ToString().Trim()) : 0;
                        double vat = worksheet.Cells[row, 7].Value != null ? double.Parse(worksheet.Cells[row, 7].Value.ToString().Trim()) : 0;
                        string managerWarehouse = worksheet.Cells[row, 8].Value != null ? worksheet.Cells[row, 8].Value.ToString().Trim() : string.Empty;
                        string allowSellNotEnough = worksheet.Cells[row, 9].Value != null ? worksheet.Cells[row, 9].Value.ToString().Trim() : string.Empty;
                        string serial = worksheet.Cells[row, 10].Value != null ? worksheet.Cells[row, 10].Value.ToString().Trim() : string.Empty;
                        string attributeName = worksheet.Cells[row, 11].Value != null ? worksheet.Cells[row, 11].Value.ToString().Trim() : string.Empty;
                        string unit = worksheet.Cells[row, 12].Value != null ? worksheet.Cells[row, 12].Value.ToString().Trim() : string.Empty;
                        string productTypeName = worksheet.Cells[row, 13].Value != null ? worksheet.Cells[row, 13].Value.ToString().Trim() : string.Empty;
                        string productManufacturerName = worksheet.Cells[row, 14].Value != null ? worksheet.Cells[row, 14].Value.ToString().Trim() : string.Empty;
                        string isPos = worksheet.Cells[row, 15].Value != null ? worksheet.Cells[row, 15].Value.ToString().Trim() : string.Empty;

                        // kiểm tra product chính đã tạo
                        var checkProduct = _context.ProductTranslations.Where(x => x.Name == productName && x.IsDeleted == false).FirstOrDefault();
                        if (checkProduct == null)// nếu chưa tạo => tạo mới 
                        {
                            productTypeParentId = 0;
                            translations = new List<ProductTranslation>();
                            foreach (var language in languages)
                            {
                                if (language.IsDefault)
                                {
                                    translations.Add(new ProductTranslation()
                                    {
                                        Name = productName,
                                        Description = StringUtil.ToUrlFormat(productName),
                                        Details = StringUtil.ToUrlFormat(productName),
                                        SeoDescription = StringUtil.ToUrlFormat(productName),
                                        SeoAlias = StringUtil.ToUrlFormat(productName),
                                        SeoTitle = productName,
                                        LanguageId = language.Id
                                    });
                                }
                                else
                                {
                                    translations.Add(new ProductTranslation()
                                    {
                                        Name = SystemConstants.AppConstants.NA,
                                        SeoDescription = SystemConstants.AppConstants.NA,
                                        SeoAlias = SystemConstants.AppConstants.NA,
                                        SeoTitle = SystemConstants.AppConstants.NA,
                                        LanguageId = language.Id
                                    });
                                }
                            }

                            //producttype

                            var arrayProductTypeName = productTypeName.Split(">>");
                            for(int i = 0; i < arrayProductTypeName.Length -1 ; i++)
                            {

                                var checkProductType = _context.ProductTypeTranslations.Where(x => x.Name == arrayProductTypeName[i].Trim()).FirstOrDefault();
                                if (checkProductType == null)
                                {
                                    var pTypetranslations = new List<ProductTypeTranslation>();
                                    foreach (var language in languages)
                                    {
                                        if (language.IsDefault)
                                        {
                                            pTypetranslations.Add(new ProductTypeTranslation()
                                            {
                                                Name = productTypeName,
                                                SeoAlias = StringUtil.ToUrlFormat(productTypeName),
                                                SeoDescription = productTypeName,
                                                SeoTitle = productTypeName,
                                                LanguageId = language.Id
                                            });
                                        }
                                        else
                                        {
                                            pTypetranslations.Add(new ProductTypeTranslation()
                                            {
                                                Name = SystemConstants.AppConstants.NA,
                                                SeoAlias = StringUtil.ToUrlFormat(SystemConstants.AppConstants.NA),
                                                SeoDescription = SystemConstants.AppConstants.NA,
                                                SeoTitle = SystemConstants.AppConstants.NA,
                                                LanguageId = language.Id
                                            });
                                        }
                                    }
                                    productType = new ProductType()
                                    {
                                        ProductTypeTranslations = pTypetranslations,
                                        Store = await _context.Stores.FindAsync(request.StoreId),
                                        ParentId = productTypeParentId > 0 ? productTypeParentId : null,
                                        SortOrder = 1,
                                        CreatedUserId = request.CreatedUserId,
                                        ModifiedUserId = request.CreatedUserId,
                                        CreatedDate = DateTime.Now
                                    };
                                    _context.ProductTypes.Add(productType);
                                    await _context.SaveChangesAsync();
                                    productTypeParentId = productType.Id;
                                }
                                else
                                {
                                    productType = _context.ProductTypes.Find(checkProductType.ProductTypeId);
                                    productTypeParentId = productType.Id;
                                }
                            }


                            //Manufactuer
                            var checkManufactuer = _context.ManufacturerTranslations.Where(x => x.Name == productManufacturerName).FirstOrDefault();
                            if(checkManufactuer == null)
                            {
                                var manufacturerTranslations = new List<ManufacturerTranslation>();
                                foreach (var language in languages)
                                {
                                    if (language.IsDefault)
                                    {
                                        manufacturerTranslations.Add(new ManufacturerTranslation()
                                        {
                                            Name = productManufacturerName,
                                            LanguageId = language.Id
                                        });
                                    }
                                    else
                                    {
                                        manufacturerTranslations.Add(new ManufacturerTranslation()
                                        {
                                            Name = SystemConstants.AppConstants.NA,
                                            LanguageId = language.Id
                                        });
                                    }
                                }
                                manufacturer = new Manufacturer()
                                {
                                    CreatedUserId = request.CreatedUserId,
                                    ModifiedUserId = request.CreatedUserId,
                                    ManufacturerTranslations = manufacturerTranslations,
                                };
                                _context.Manufacturers.Add(manufacturer);
                                await _context.SaveChangesAsync();
                            }
                            else
                            {
                                manufacturer = _context.Manufacturers.Find(checkManufactuer.ManufacturerId);
                            }

                            product = new Product()
                            {
                                Code = !string.IsNullOrEmpty(attributeName) ? string.Empty : (!string.IsNullOrEmpty(productCode) ? productCode : GetLastestSKUCode(1)),
                                Price = buyingPrice,
                                OriginalPrice = price,
                                Stock = 0,
                                ViewCount = 0,
                                IsFeatured = true,
                                IsPOS = !string.IsNullOrEmpty(isPos) && isPos.ToLower() == "có" ? true : false,
                                AllowSellWhenNotEnough = !string.IsNullOrEmpty(allowSellNotEnough) && allowSellNotEnough.ToLower() == "có" ? true : false,
                                IsWeb = true,
                                InventoryWarning = warning,
                                Url = StringUtil.ToUrlFormat(productName),
                                ProductTitle = productName,
                                IsHasSKU = !string.IsNullOrEmpty(attributeName) ? true : false,
                                CreatedDate = DateTime.Now,
                                CreatedUserId = request.CreatedUserId,
                                ManufactuerId = manufacturer.Id,
                                ProductTranslations = translations,
                                IsDeleted = false
                            };
                            _context.Products.Add(product);
                            await _context.SaveChangesAsync();
                        }
                        else
                        {
                            product = _context.Products.Find(checkProduct.ProductId);
                        }


                        List<ProductSKU_AttributeValue> pa = new List<ProductSKU_AttributeValue>();
                        //cuối cùng thêm vào sku
                        if (!string.IsNullOrEmpty(attributeName))
                        {
                            var arrayAttribute = attributeName.Split('|');
                            //kiểm tra attribute đã có hay chưa
                            foreach (var item in arrayAttribute)
                            {
                                var attribute_value = item.Split(':');

                                string attr = attribute_value[0];
                                string value = attribute_value[1];
                                attrbuteValueNameJoin += "_" + value.Trim();

                                var checkAttr = _context.AttributeTranslations.Where(x => x.Name == attr).FirstOrDefault();
                                if (checkAttr != null)
                                {
                                    var checkVal = _context.AttributeValueTranslations.Where(x => x.Name == value && x.AttributeValue.AttributeId == checkAttr.AttributeId).FirstOrDefault();

                                    if (checkVal != null)
                                    {
                                        attributeValue = checkVal.AttributeValue;
                                    }
                                    else
                                    {
                                        var AttValueTranslations = new List<AttributeValueTranslation>();
                                        foreach (var language in languages)
                                        {
                                            if (language.IsDefault)
                                            {
                                                AttValueTranslations.Add(new AttributeValueTranslation()
                                                {
                                                    Name = value.Trim(),
                                                    LanguageId = language.Id
                                                });
                                            }
                                            else
                                            {
                                                AttValueTranslations.Add(new AttributeValueTranslation()
                                                {
                                                    Name = SystemConstants.AppConstants.NA,
                                                    LanguageId = language.Id
                                                });
                                            }
                                        }
                                        attributeValue = new Data.Entities.AttributeValue()
                                        {
                                            CreatedUserId = request.CreatedUserId,
                                            Attribute = checkAttr.Attribute,
                                            AttributeValueTranslations = AttValueTranslations
                                        };
                                        _context.AttributeValues.Add(attributeValue);
                                        await _context.SaveChangesAsync();
                                    }
                                }
                                else
                                {

                                    var AttTranslations = new List<AttributeTranslation>();
                                    foreach (var language in languages)
                                    {
                                        if (language.IsDefault)
                                        {
                                            AttTranslations.Add(new AttributeTranslation()
                                            {
                                                Name = attr.Trim(),
                                                LanguageId = language.Id
                                            });
                                        }
                                        else
                                        {
                                            AttTranslations.Add(new AttributeTranslation()
                                            {
                                                Name = SystemConstants.AppConstants.NA,
                                                LanguageId = language.Id
                                            });
                                        }
                                    }
                                    attribute = new Data.Entities.Attribute()
                                    {
                                        CreatedUserId = request.CreatedUserId,
                                        AttributeTranslations = AttTranslations
                                    };
                                    _context.Attributes.Add(attribute);
                                    await _context.SaveChangesAsync();

                                    var AttValueTranslations = new List<AttributeValueTranslation>();
                                    foreach (var language in languages)
                                    {
                                        if (language.IsDefault)
                                        {
                                            AttValueTranslations.Add(new AttributeValueTranslation()
                                            {
                                                Name = value.Trim(),
                                                LanguageId = language.Id
                                            });
                                        }
                                        else
                                        {
                                            AttValueTranslations.Add(new AttributeValueTranslation()
                                            {
                                                Name = SystemConstants.AppConstants.NA,
                                                LanguageId = language.Id
                                            });
                                        }
                                    }
                                    attributeValue = new Data.Entities.AttributeValue()
                                    {
                                        CreatedUserId = request.CreatedUserId,
                                        Attribute = attribute,
                                        AttributeValueTranslations = AttValueTranslations
                                    };
                                    _context.AttributeValues.Add(attributeValue);
                                    await _context.SaveChangesAsync();
                                }

                                pa.Add(new ProductSKU_AttributeValue()
                                {
                                    AttributeValue = attributeValue
                                });
                            }

                            if (product.ProductSKUs == null)
                            {
                                product.ProductSKUs = new List<ProductSKU>();
                                product.ProductSKUs.Add(new ProductSKU()
                                {
                                    Code = productCode,
                                    Name = productName + attrbuteValueNameJoin,
                                    Price = (double)product.OriginalPrice,
                                    QtyInStock = 0,
                                    BuyingPrice = (double)product.Price,
                                    ProductSKU_AttributeValues = pa
                                });
                                await _context.SaveChangesAsync();
                            }
                            else if (!product.ProductSKUs.Any(x => x.Code == productCode))
                            {
                                product.ProductSKUs.Add(new ProductSKU()
                                {
                                    Code = productCode,
                                    Name = productName + attrbuteValueNameJoin,
                                    Price = (double)product.OriginalPrice,
                                    QtyInStock = 0,
                                    BuyingPrice = (double)product.Price,
                                    ProductSKU_AttributeValues = pa
                                });
                                await _context.SaveChangesAsync();
                            }
                        }
                        else
                        {
                            if (product.ProductSKUs == null) product.ProductSKUs = new List<ProductSKU>();
                            product.ProductSKUs.Add(new ProductSKU()
                            {
                                Code = productCode,
                                Name = productName + attrbuteValueNameJoin,
                                Price = (double)price,
                                QtyInStock = 0,
                                BuyingPrice = (double)buyingPrice,
                                ProductSKU_AttributeValues = null
                            });

                            await _context.SaveChangesAsync();
                        }
                    }
                }

                return new ApiSuccessResult<string>("abc");
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }


        public async Task<ApiResult<List<ProductSKUDto>>> ImportExcelPrint(ProductImportRequest request)
        {
            var result = new List<ProductSKUDto>();
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.Commercial;
                var stream = request.File.OpenReadStream();
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        string productName = worksheet.Cells[row, 1].Value != null ? worksheet.Cells[row, 1].Value.ToString().Trim() : string.Empty;
                        string productCode = worksheet.Cells[row, 2].Value != null ? worksheet.Cells[row, 2].Value.ToString().Trim() : string.Empty;
                        int quantity = worksheet.Cells[row, 3].Value != null ? int.Parse(worksheet.Cells[row, 3].Value.ToString().Trim()) : 0;
                        var checkProduct= await _context.ProductSKUs.Where(x => x.Code == productCode || x.Name == productName && x.IsDeleted == false).FirstOrDefaultAsync();
                        if (checkProduct != null && quantity > 0)
                        {
                            result.Add(new ProductSKUDto() {Id = checkProduct.Id, Code = checkProduct.Code, Name = checkProduct.Name, QtyInStock = quantity , BuyingPrice = checkProduct.BuyingPrice});
                        }
                    }
                }

                return new ApiSuccessResult<List<ProductSKUDto>>(result);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<List<ProductSKUDto>>(ex.Message);
            }
        }


        public async Task<ApiResult<string>> PrintQRCode(PrintQRCodeRequest rq)
        {

            var docTemplateContent = await _docTemplateService.GetContentByDocTemplateTypeCodeAndSize(rq);
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            string htmlPrint = "";
            string res = string.Empty;
            int i = 0;



            string pdf_orientation = "Portrait";
            var pdfOrientation =
                (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation),
                pdf_orientation, true);

            int webPageWidth = 0;
            int webPageHeight = 0;

            // instantiate a html to pdf converter object
            HtmlToPdf converter = new HtmlToPdf();

            // set converter options
            if(rq.SizeName != "A4" && rq.SizeName != "A5")
            {
                foreach (var item in rq.ProductSkuPrints)
                {
                    string base64QR = string.Empty;
                    QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(item.ProductCode, QRCodeGenerator.ECCLevel.Q);
                    QRCode qRCode = new QRCode(qRCodeData);
                    Bitmap bitmap = qRCode.GetGraphic(15);
                    var bitmapBytes = ConvertBitmapToBytes(bitmap);
                    using (var ms = new MemoryStream())
                    {
                        bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        base64QR = Convert.ToBase64String(ms.GetBuffer());
                    }

                    for (int j = 1; j <= item.Qty; j++)
                    {
                        if(i == 0)
                        {
                            htmlPrint = "<table style='height:6cm; width:14cm;'><tbody><tr>";
                        }
                        i++;

                        
                        if (i % 2 == 0  && i > 1)
                        {
                            htmlPrint += "<td width='50%'>" + docTemplateContent.Content + "</td>";
                            htmlPrint += "</tr></tbody></table>";
                            if(i != rq.ProductSkuPrints.Sum(x => x.Qty))
                            {
                                res += "<div style='page-break-after: always;'>" + htmlPrint + "</div>";
                                htmlPrint = "<table style='height:6cm; width:14cm; '><tbody><tr>";
                            }
                            else
                            {
                                res += htmlPrint;
                            }
                        }
                        else if(rq.ProductSkuPrints.Sum(x => x.Qty) == 1 || (rq.ProductSkuPrints.Sum(x => x.Qty) ==i && i % 2 != 0) )
                        {
                            htmlPrint += "<td width='50%'>" + docTemplateContent.Content + "</td>";
                            htmlPrint += "<td width='50%'></td>";
                            htmlPrint += "</tr></tbody></table>";
                            if((rq.ProductSkuPrints.Sum(x => x.Qty) == i)){
                                res += htmlPrint;
                            }
                        }
                        else
                        {
                            htmlPrint += "<td width='50%'>" + docTemplateContent.Content + "</td>";
                        }
                    }


                    htmlPrint = htmlPrint.Replace("{{Price}}", CurrencyUtil.convertCurrencyVND(item.ProductPrice) + "đ");
                    htmlPrint = htmlPrint.Replace("{{ProductName}}", item.ProductName);
                    htmlPrint = htmlPrint.Replace("{{QRCode}}", "data:image/png;base64," + base64QR);
                    res = res.Replace("{{Price}}", CurrencyUtil.convertCurrencyVND(item.ProductPrice) + "đ");
                    res = res.Replace("{{ProductName}}", item.ProductName);
                    res = res.Replace("{{QRCode}}", "data:image/png;base64," + base64QR);
                }

                res = res.Replace("{{logo}}", rq.Logo);
                res = res.Replace("{{ten_cua_hang}}", rq.StoreName);

                converter.Options.MarginTop = 0;
                converter.Options.PdfPageSize = PdfPageSize.Custom;
                converter.Options.PdfPageCustomSize = new SizeF((float)192.24, (float)63.36);
                htmlPrint = res;
            }
            else
            {
                foreach (var item in rq.ProductSkuPrints)
                {
                    if (item.Qty > 1)
                    {
                        for (int j = 1; j <= item.Qty; j++)
                        {

                            if (i == 3)
                            {
                                htmlPrint = "<div style='page-break-after: always'>" + htmlPrint + "</div>";
                                i = 0;
                            }

                            htmlPrint += docTemplateContent.Content;
                            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(item.ProductCode, QRCodeGenerator.ECCLevel.Q);
                            QRCode qRCode = new QRCode(qRCodeData);
                            Bitmap bitmap = qRCode.GetGraphic(15);
                            var bitmapBytes = ConvertBitmapToBytes(bitmap);

                            htmlPrint = htmlPrint.Replace("{{logo}}", rq.Logo);
                            htmlPrint = htmlPrint.Replace("{{ten_cua_hang}}", rq.StoreName);
                            htmlPrint = htmlPrint.Replace("{{Price}}", CurrencyUtil.convertCurrencyVND(item.ProductPrice) + "đ");
                            htmlPrint = htmlPrint.Replace("{{ProductName}}", item.ProductName);

                            using (var ms = new MemoryStream())
                            {
                                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                string SigBase64 = Convert.ToBase64String(ms.GetBuffer());
                                htmlPrint = htmlPrint.Replace("{{QRCode}}", "data:image/png;base64," + SigBase64);
                            }
                            i++;
                        }
                    }
                    else
                    {
                        if (i == 3)
                        {
                            htmlPrint = "<div style='page-break-after: always'>" + htmlPrint + "</div>";
                            i = 0;
                        }

                        htmlPrint += docTemplateContent.Content;
                        QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(item.ProductCode, QRCodeGenerator.ECCLevel.Q);
                        QRCode qRCode = new QRCode(qRCodeData);
                        Bitmap bitmap = qRCode.GetGraphic(15);
                        var bitmapBytes = ConvertBitmapToBytes(bitmap);

                        htmlPrint = htmlPrint.Replace("{{logo}}", rq.Logo);
                        htmlPrint = htmlPrint.Replace("{{ten_cua_hang}}", rq.StoreName);
                        htmlPrint = htmlPrint.Replace("{{Price}}", CurrencyUtil.convertCurrencyVND(item.ProductPrice) + "đ");
                        htmlPrint = htmlPrint.Replace("{{ProductName}}", item.ProductName);

                        using (var ms = new MemoryStream())
                        {
                            bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            string SigBase64 = Convert.ToBase64String(ms.GetBuffer());
                            htmlPrint = htmlPrint.Replace("{{QRCode}}", "data:image/png;base64," + SigBase64);
                        }
                        i++;
                    }
                }

                string pdf_page_size = rq.SizeName;
                PdfPageSize pageSize = (PdfPageSize)Enum.Parse(typeof(PdfPageSize),
                    pdf_page_size, true);
                converter.Options.PdfPageSize = pageSize;
            }

            converter.Options.AllowContentHeightResize = true;
            converter.Options.PdfPageOrientation = pdfOrientation;
            converter.Options.WebPageWidth = webPageWidth;
            converter.Options.WebPageHeight = webPageHeight;
            // create a new pdf document converting an url
            
            SelectPdf.PdfDocument doc = converter.ConvertHtmlString(htmlPrint);

            byte[] pdf = doc.Save();
            doc.Close();

            return new ApiSuccessResult<string>(Convert.ToBase64String(pdf));
        }

        private byte[] ConvertBitmapToBytes(Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms,  System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFilePathNotCombineAsync(fileName);
        }

        public async Task<bool> DeleteFileQRCode(string link)
        {
            await DeleteFile(link);
            return true;
        }
    }
}