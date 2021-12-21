using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Snail.ViewModels.Catalog.DocTemplateTypes;

namespace Snail.Application.Catalog.DocTemplateTypes
{
    public interface IDocTemplateTypeService
    {
        Task<ApiResult<List<DocTemplateTypeDto>>> GetAll(ManageDocTemplateTypePagingRequest request);
        Task<PagedResult<DocTemplateTypeDto>> GetManageListPaging(ManageDocTemplateTypePagingRequest request);
        Task<ApiResult<int>> CreateAsync(DocTemplateTypeRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<DocTemplateTypeDto>> GetById(int docTemplateTypeId, int languageId);
        Task<ApiResult<int>> UpdateAsync(DocTemplateTypeRequest request);
    }
    public class DocTemplateTypeService : IDocTemplateTypeService
    {
        private readonly EShopDbContext _context;

        public DocTemplateTypeService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<DocTemplateTypeDto>>> GetAll(ManageDocTemplateTypePagingRequest request)
        {
            var query = from d in _context.DocTemplateTypes
                        join dt in _context.DocTemplateTypeTranslations on d.Id equals dt.DocTemplateTypeId
                        where dt.LanguageId == request.LanguageId
                        select new { d, dt };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.dt.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<DocTemplateTypeDto>>(await query.Select(x => new DocTemplateTypeDto()
            {
                Id = x.d.Id,
                Code = x.d.Code,
                Name = x.dt.Name
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(DocTemplateTypeRequest request)
        {
            try
            {
                var languages = _context.Languages;
                var translations = new List<DocTemplateTypeTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new DocTemplateTypeTranslation()
                        {
                            Name = request.Name,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new DocTemplateTypeTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }
                var docTemplateType = new DocTemplateType()
                {
                    Code = request.Code,
                    CreatedUserId = request.CreatedUserId,
                    DocTemplateTypeTranslations = translations
                };

                _context.DocTemplateTypes.Add(docTemplateType);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(docTemplateType.Id);
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
                var docTemplateTypes = await _context.DocTemplateTypes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (docTemplateTypes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> docTemplateTypeIds = docTemplateTypes.Select(m => m.Id).ToList();
                var docTemplateTypeTranslations = _context.DocTemplateTypeTranslations.Where(m => docTemplateTypeIds.Contains(m.DocTemplateTypeId.Value)).ToList();
                if (docTemplateTypeTranslations != null)
                {
                    _context.DocTemplateTypeTranslations.RemoveRange(docTemplateTypeTranslations);
                }

                _context.DocTemplateTypes.RemoveRange(docTemplateTypes);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<DocTemplateTypeDto>> GetManageListPaging(ManageDocTemplateTypePagingRequest request)
        {
            //1. Select join
            var query = from d in _context.DocTemplateTypes
                        join dt in _context.DocTemplateTypeTranslations on d.Id equals dt.DocTemplateTypeId into ddt
                        from dt in ddt.DefaultIfEmpty()
                        where dt.LanguageId == request.LanguageId
                        select new { d, dt };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.dt.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new DocTemplateTypeDto()
            {
                Id = x.d.Id,
                Code = x.d.Code,
                Name = x.dt.Name,
                CreatedDate = x.d.CreatedDate,
                LanguageId = x.dt.LanguageId.Value
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<DocTemplateTypeDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<DocTemplateTypeDto>> GetById(int docTemplateTypeId, int languageId)
        {
            var docTemplateType = await _context.DocTemplateTypes.FindAsync(docTemplateTypeId);
            var docTemplateTypeTranslation = await _context.DocTemplateTypeTranslations.FirstOrDefaultAsync(x => x.DocTemplateTypeId == docTemplateTypeId
                                                                                                            && x.LanguageId == languageId);

            var docTemplateTypeDto = new DocTemplateTypeDto()
            {
                Id = docTemplateType.Id,
                Code = docTemplateType.Code,
                Name = docTemplateTypeTranslation != null ? docTemplateTypeTranslation.Name : string.Empty,
                CreatedDate = docTemplateType.CreatedDate,
                LanguageId = docTemplateTypeTranslation.LanguageId.Value,
                
            };

            return new ApiSuccessResult<DocTemplateTypeDto>(docTemplateTypeDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(DocTemplateTypeRequest request)
        {
            try
            {
                var docTemplateType = await _context.DocTemplateTypes.FindAsync(request.Id);
                var docTemplateTypeTranslations = await _context.DocTemplateTypeTranslations.FirstOrDefaultAsync(x => x.DocTemplateTypeId == request.Id
                && x.LanguageId == request.LanguageId);

                if (docTemplateType == null || docTemplateTypeTranslations == null) throw new EShopException($"Cannot find a docTemplateType with id: {request.Id}");

                docTemplateType.Code = request.Code;
                docTemplateTypeTranslations.Name = request.Name;
                docTemplateType.ModifiedUserId = request.ModifiedUserId;
                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }            
        }
    }
}
