using BHSNetCoreLib;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Catalog.Attributes;
using SnailApp.ViewModels.Catalog.AttributeValues;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnailApp.Application.Catalog.AttributeValues
{
    public interface IAttributeValueService
    {
        Task<ApiResult<List<AttributeValueDto>>> GetAll(ManageAttributeValuePagingRequest request);
        Task<PagedResult<AttributeValueDto>> GetManageListPaging(ManageAttributeValuePagingRequest request);
        Task<ApiResult<int>> CreateAsync(AttributeValueRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AttributeValueDto>> GetById(int attributeId, int languageId);
        Task<ApiResult<int>> UpdateAsync(AttributeValueRequest request);
    }
    public class AttributeValueService : IAttributeValueService
    {
        private readonly ClinicDbContext _context;

        public AttributeValueService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<AttributeValueDto>>> GetAll(ManageAttributeValuePagingRequest request)
        {
            var query = from av in _context.AttributeValues
                        join avt in _context.AttributeValueTranslations on av.Id equals avt.AttributeValueId
                        join a in _context.Attributes on av.AttributeId equals a.Id
                        join at in _context.AttributeTranslations on av.Id equals at.AttributeId
                        where avt.LanguageId == request.LanguageId
                        select new { a, avt,av, at };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.avt.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<AttributeValueDto>>(await query.Select(x => new AttributeValueDto()
            {
                Id = x.av.Id,
                Name = x.avt.Name,
                AttributeId = x.a.Id,
                AttributeName = x.at.Name,
                Description = x.a.Description
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(AttributeValueRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<AttributeValueTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new AttributeValueTranslation()
                    {
                        Name = request.Name,
                        SeoDescription = StringUtil.ToUrlFormat(request.Name),
                        SeoAlias = StringUtil.ToUrlFormat(request.Name),
                        SeoTitle = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new AttributeValueTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        SeoDescription = SystemConstants.AppConstants.NA,
                        SeoAlias = SystemConstants.AppConstants.NA,
                        SeoTitle = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var attributeValue = new Data.Entities.AttributeValue()
            {
                Description = request.Description,
                AttributeId = request.AttributeId,
                CreatedUserId = Guid.Parse(request.CreatedUserId),
                AttributeValueTranslations = translations
            };

            _context.AttributeValues.Add(attributeValue);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(attributeValue.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var attributes = await _context.AttributeValues.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (attributes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> attributeIds = attributes.Select(m => m.Id).ToList();
                var attributeTranslations = _context.AttributeTranslations.Where(m => attributeIds.Contains(m.AttributeId)).ToList();
                if (attributeTranslations != null)
                {
                    _context.AttributeTranslations.RemoveRange(attributeTranslations);
                }

                _context.AttributeValues.RemoveRange(attributes);

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

        public async Task<PagedResult<AttributeValueDto>> GetManageListPaging(ManageAttributeValuePagingRequest request)
        {
            //1. Select join
            var query = from av in _context.AttributeValues
                        join avt in _context.AttributeValueTranslations on av.Id equals avt.AttributeValueId
                        join at in _context.AttributeTranslations on av.AttributeId equals at.AttributeId
                        where avt.LanguageId == request.LanguageId &&
                        at.LanguageId == request.LanguageId
                        select new { 
                            Id = av.Id, 
                            Name = avt.Name, 
                            AttributeName = at.Name,
                            AttributeId = av.AttributeId,
                            Description = av.Description,
                            CreatedDate = av.CreatedDate,
                            LanguageId = avt.LanguageId
                        };

                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.Name.Contains(request.TextSearch));

                if (request.AttributeId.HasValue)
                    query = query.Where(x => x.AttributeId == request.AttributeId.Value);


                //3. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
                }


            var data = await query.Select(x => new AttributeValueDto()
            {
                Id = x.Id,
                Name = x.Name,
                AttributeName = x.AttributeName,
                AttributeId = x.AttributeId,
                Description = x.Description,
                CreatedDate = x.CreatedDate,
                LanguageId = x.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<AttributeValueDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<AttributeValueDto>> GetById(int attributeId, int languageId)
        {
            var attribute = await _context.AttributeValues.FindAsync(attributeId);
            var attributeTranslation = await _context.AttributeValueTranslations.FirstOrDefaultAsync(x => x.AttributeValueId == attributeId
                                                                                                            && x.LanguageId == languageId);

            var AttributeValueDto = new AttributeValueDto()
            {
                Id = attribute.Id,
                CreatedDate = attribute.CreatedDate,
                LanguageId = attributeTranslation.LanguageId,
                Name = attributeTranslation != null ? attributeTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<AttributeValueDto>(AttributeValueDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(AttributeValueRequest request)
        {
            var attributeValue = await _context.AttributeValues.FindAsync(request.Id);
            var attributeValueTranslations = await _context.AttributeValueTranslations.FirstOrDefaultAsync(x => x.AttributeValueId == request.Id
            && x.LanguageId == request.LanguageId);

            if (attributeValue == null || attributeValueTranslations == null) throw new EShopException($"Cannot find a attribute value with id: {request.Id}");

            attributeValueTranslations.Name = request.Name;
            attributeValueTranslations.SeoAlias = StringUtil.ToUrlFormat(request.Name);
            attributeValueTranslations.SeoDescription = request.SeoDescription;
            attributeValueTranslations.SeoTitle = request.SeoTitle;
            attributeValueTranslations.Description = request.Description;

            attributeValue.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            attributeValue.Description = request.Description;
            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}