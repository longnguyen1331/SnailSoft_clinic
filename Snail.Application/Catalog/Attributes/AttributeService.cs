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
using Snail.ViewModels.Catalog.Attributes;

namespace Snail.Application.Catalog.Attributes
{
    public interface IAttributeService
    {
        Task<ApiResult<List<AttributeDto>>> GetAll(ManageAttributePagingRequest request);
        Task<PagedResult<AttributeDto>> GetManageListPaging(ManageAttributePagingRequest request);
        Task<ApiResult<int>> CreateAsync(AttributeRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AttributeDto>> GetById(int attributeId, int languageId);
        Task<ApiResult<int>> UpdateAsync(AttributeRequest request);
    }
    public class AttributeService : IAttributeService
    {
        private readonly EShopDbContext _context;

        public AttributeService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<AttributeDto>>> GetAll(ManageAttributePagingRequest request)
        {
            var query = from c in _context.Attributes
                        join ct in _context.AttributeTranslations on c.Id equals ct.AttributeId
                        where ct.LanguageId == request.LanguageId
                        select new { c, ct };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.ct.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<AttributeDto>>(await query.Select(x => new AttributeDto()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                Description = x.c.Description
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(AttributeRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<AttributeTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new AttributeTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new AttributeTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var attribute = new Data.Entities.Attribute()
            {
                Description = request.Description,
                CreatedUserId = Guid.Parse(request.CreatedUserId),
                AttributeTranslations = translations
            };

            _context.Attributes.Add(attribute);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(attribute.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var attributes = await _context.Attributes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (attributes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> attributeIds = attributes.Select(m => m.Id).ToList();
                var attributeTranslations = _context.AttributeTranslations.Where(m => attributeIds.Contains(m.AttributeId)).ToList();
                if (attributeTranslations != null)
                {
                    _context.AttributeTranslations.RemoveRange(attributeTranslations);
                }

                _context.Attributes.RemoveRange(attributes);

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

        public async Task<PagedResult<AttributeDto>> GetManageListPaging(ManageAttributePagingRequest request)
        {
            //1. Select join
            var query = from c in _context.Attributes
                        join ct in _context.AttributeTranslations on c.Id equals ct.AttributeId into cct
                        from ct in cct.DefaultIfEmpty()
                        where ct.LanguageId == request.LanguageId
                        select new { c, ct };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.ct.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new AttributeDto()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                Description = x.c.Description,
                CreatedDate = x.c.CreatedDate,
                LanguageId = x.ct.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<AttributeDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<AttributeDto>> GetById(int attributeId, int languageId)
        {
            var attribute = await _context.Attributes.FindAsync(attributeId);
            var attributeTranslation = await _context.AttributeTranslations.FirstOrDefaultAsync(x => x.AttributeId == attributeId
                                                                                                            && x.LanguageId == languageId);

            var attributeDto = new AttributeDto()
            {
                Id = attribute.Id,
                CreatedDate = attribute.CreatedDate,
                LanguageId = attributeTranslation.LanguageId,
                Name = attributeTranslation != null ? attributeTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<AttributeDto>(attributeDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(AttributeRequest request)
        {
            var attribute = await _context.Attributes.FindAsync(request.Id);
            var attributeTranslations = await _context.AttributeTranslations.FirstOrDefaultAsync(x => x.AttributeId == request.Id
            && x.LanguageId == request.LanguageId);

            if (attribute == null || attributeTranslations == null) throw new EShopException($"Cannot find a attribute with id: {request.Id}");

            attributeTranslations.Name = request.Name;
            attribute.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            attribute.Description = request.Description;
            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}