using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.DocTemplates;
using SnailApp.ViewModels.Catalog.DocTemplateTypes;
using SnailApp.ViewModels.Catalog.PaperSizes;
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
using SnailApp.ViewModels.Catalog.Products;

namespace SnailApp.Application.SystemApplication.DocTemplates
{
    public interface IDocTemplateService
    {
        Task<ApiResult<int>> CreateAsync(DocTemplateRequest request);
        Task<ApiResult<int>> UpdateAsync(DocTemplateRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<DocTemplateDto>> GetById(DocTemplateRequest request);
        Task<PagedResult<DocTemplateDto>> GetManageListPaging(ManageDocTemplatePagingRequest request);
        Task<DocTemplateDto> GetContentByDocTemplateTypeCode(DocTemplateRequest request);
        Task<DocTemplateDto> GetContentByDocTemplateTypeCodeAndSize(PrintQRCodeRequest request);
        Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile);
    }
    public class DocTemplateService : IDocTemplateService
    {
        private readonly ClinicDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public DocTemplateService(ClinicDbContext context, IFileStorageService storageService,
                                IConfiguration configuration)
        {
            _context = context;
            _storageService = storageService;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(DocTemplateRequest request)
        {
            if (request.IsDefault == true)
            {
                foreach (var item in await (_context.DocTemplates.Where(m => m.DocTemplateTypeId == request.DocTemplateTypeId).ToListAsync()))
                {
                    item.IsDefault = false;

                    _context.DocTemplates.Update(item);
                }
            }

            var docTemplate = new DocTemplate()
            {
                Content = request.Content,
                Name = request.Name,
                PaperSizeId = request.PaperSizeId,
                IsDefault = request.IsDefault,
                DocTemplateTypeId = request.DocTemplateTypeId,
                CreatedDate = DateTime.Now
            };

            _context.DocTemplates.Add(docTemplate);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(docTemplate.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(DocTemplateRequest request)
        {
            try
            {
                var docTemplate = await _context.DocTemplates.FindAsync(request.Id);

                if (docTemplate == null) throw new EShopException($"Cannot find a DocTemplate with id: {request.Id}");

                if (request.IsDefault == true)
                {
                    foreach (var item in await (_context.DocTemplates.Where(m => m.DocTemplateTypeId == request.DocTemplateTypeId).ToListAsync()))
                    {
                        item.IsDefault = false;

                        _context.DocTemplates.Update(item);
                    }
                }

                docTemplate.Content = request.Content;
                docTemplate.Name = request.Name;
                docTemplate.PaperSizeId = request.PaperSizeId;
                docTemplate.IsDefault = request.IsDefault;
                docTemplate.DocTemplateTypeId = request.DocTemplateTypeId;
                docTemplate.ModifiedDate = DateTime.Now;

                _context.DocTemplates.Update(docTemplate);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(docTemplate.Id);

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

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var docTemplates = await _context.DocTemplates.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (docTemplates == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.DocTemplates.RemoveRange(docTemplates);

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

        public async Task<PagedResult<DocTemplateDto>> GetManageListPaging(ManageDocTemplatePagingRequest request)
        {
            //1. Select join
            var query = from d in _context.DocTemplates
                        join dt in _context.DocTemplateTypes on d.DocTemplateTypeId equals dt.Id into d_dt
                        from dt in d_dt.DefaultIfEmpty()
                        select new { d, dt };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.d.Name.Contains(request.TextSearch));
            }

            if (request.DocTemplateTypeId != null)
            {
                query = query.Where(x => x.d.DocTemplateTypeId == request.DocTemplateTypeId.Value);
            }

            //3.Sort
            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.d.Id) :
                            query.OrderByDescending(x => x.d.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.d.Code) :
                            query.OrderByDescending(x => x.d.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.d.Name) :
                            query.OrderByDescending(x => x.d.Name);

                        break;

                    default: break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
            }

            var data = await query.Select(x => new DocTemplateDto()
            {
                Id = x.d.Id,
                Name = x.d.Name,
                IsDefault = x.d.IsDefault
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<DocTemplateDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<DocTemplateDto> GetContentByDocTemplateTypeCode(DocTemplateRequest request)
        {
            //1. Select join
            var query = from d in _context.DocTemplates
                        join dt in _context.DocTemplateTypes on d.DocTemplateTypeId equals dt.Id into d_dt
                        from dt in d_dt.DefaultIfEmpty()
                        where dt.Code == request.DocTemplateCode
                        && d.IsDefault == true
                        select new { d, dt };

            var data = await query.Select(x => new DocTemplateDto()
            {
                Id = x.d.Id,
                Content = x.d.Content
            }).AsNoTracking().FirstOrDefaultAsync();
            
            var store = from d in _context.Stores
                        join dt in _context.StoreTranslations on d.Id equals dt.StoreId into d_dt
                        from dt in d_dt.DefaultIfEmpty()
                        where d.Id == request.StoreId
                        select new { d, dt };

            data.StoreAddress = await store.Select(x => x.dt.Address).AsNoTracking().FirstOrDefaultAsync();
            data.StoreName = await store.Select(x => x.dt.Name).AsNoTracking().FirstOrDefaultAsync();
            data.StorePhone = await store.Select(x => x.d.Phone).AsNoTracking().FirstOrDefaultAsync();

            return data;
        }

        public async Task<DocTemplateDto> GetContentByDocTemplateTypeCodeAndSize(PrintQRCodeRequest request)
        {
            //1. Select join
            var query = from d in _context.DocTemplates
                        join dt in _context.DocTemplateTypes on d.DocTemplateTypeId equals dt.Id into d_dt
                        from dt in d_dt.DefaultIfEmpty()
                        where dt.Code == request.Code
                        && d.PaperSize.Name == request.SizeName
                        select new { d, dt };

            var data = await query.Select(x => new DocTemplateDto()
            {
                Id = x.d.Id,
                Content = x.d.Content
            }).AsNoTracking().FirstOrDefaultAsync();

            var store = from d in _context.Stores
                        join dt in _context.StoreTranslations on d.Id equals dt.StoreId into d_dt
                        from dt in d_dt.DefaultIfEmpty()
                        where d.Id == request.StoreId
                        select new { d, dt };
            data.StoreAddress = await store.Select(x => x.dt.Address).AsNoTracking().FirstOrDefaultAsync();
            data.StoreName = await store.Select(x => x.dt.Name).AsNoTracking().FirstOrDefaultAsync();
            data.StorePhone = await store.Select(x => x.d.Phone).AsNoTracking().FirstOrDefaultAsync();
            return data;
        }

        public async Task<ApiResult<DocTemplateDto>> GetById(DocTemplateRequest request)
        {
            try
            {
                var docTemplate = await (from d in _context.DocTemplates
                                         join dt in _context.DocTemplateTypes on d.DocTemplateTypeId equals dt.Id into d_dt
                                         from dt in d_dt.DefaultIfEmpty()
                                             join dtt in _context.DocTemplateTypeTranslations on dt.Id equals dtt.DocTemplateTypeId into dt_dtt
                                             from dtt in dt_dtt.DefaultIfEmpty()
                                         join p in _context.PaperSizes on d.PaperSizeId equals p.Id into d_p
                                         from p in d_p.DefaultIfEmpty()
                                         where dtt.LanguageId == request.LanguageId && d.Id == request.Id
                                         select new DocTemplateDto()
                                         {
                                             Id = d.Id,
                                             Content = d.Content,
                                             Name = d.Name,
                                             PaperSize = new PaperSizeDto()
                                             {
                                                 Id = p.Id,
                                                 Name = p.Name,
                                                 Value = p.Value
                                             },
                                             IsDefault = d.IsDefault,
                                             DocTemplateType = new DocTemplateTypeDto()
                                             {
                                                 Id = dt.Id,
                                                 Name = dtt.Name
                                             }
                                         }).AsNoTracking().FirstOrDefaultAsync();
                return new ApiSuccessResult<DocTemplateDto>(docTemplate);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<DocTemplateDto>(ex.Message);
            }
        }
        public async Task<ApiResult<string>> CKEditorUploadFile(IFormFile uploadFile)
        {
            try
            {
                return new ApiSuccessResult<string>(await this.SaveFile(uploadFile));
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = _configuration[SystemConstants.AppConstants.DocTemplateUploadFile] + "/" + $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return fileName;
        }
    }
}