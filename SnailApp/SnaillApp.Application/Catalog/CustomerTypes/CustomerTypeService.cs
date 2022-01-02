using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.CustomerTypes;

namespace SnailApp.Application.Catalog.CustomerTypes
{
    public interface ICustomerTypeService
    {
        Task<ApiResult<List<CustomerTypeDto>>> GetAll(ManageCustomerTypePagingRequest request);
        Task<PagedResult<CustomerTypeDto>> GetManageListPaging(ManageCustomerTypePagingRequest request);
        Task<ApiResult<int>> CreateAsync(CustomerTypeRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<CustomerTypeDto>> GetById(int customerTypeId, int languageId);
        Task<ApiResult<int>> UpdateAsync(CustomerTypeRequest request);
    }
    public class CustomerTypeService : ICustomerTypeService
    {
        private readonly EShopDbContext _context;

        public CustomerTypeService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<CustomerTypeDto>>> GetAll(ManageCustomerTypePagingRequest request)
        {
            var query = from c in _context.CustomerTypes
                        join ct in _context.CustomerTypeTranslations on c.Id equals ct.CustomerTypeId
                        where ct.LanguageId == request.LanguageId
                        select new { c, ct };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.ct.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<CustomerTypeDto>>(await query.Select(x => new CustomerTypeDto()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                Description = x.c.Description
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(CustomerTypeRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<CustomerTypeTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new CustomerTypeTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new CustomerTypeTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var customerType = new CustomerType()
            {
                Description = request.Description,
                CreatedUserId = Guid.Parse(request.CreatedUserId),
                CustomerTypeTranslations = translations
            };

            _context.CustomerTypes.Add(customerType);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(customerType.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var customerTypes = await _context.CustomerTypes.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (customerTypes == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> customerTypeIds = customerTypes.Select(m => m.Id).ToList();
                var customerTypeTranslations = _context.CustomerTypeTranslations.Where(m => customerTypeIds.Contains(m.CustomerTypeId)).ToList();
                if (customerTypeTranslations != null)
                {
                    _context.CustomerTypeTranslations.RemoveRange(customerTypeTranslations);
                }

                _context.CustomerTypes.RemoveRange(customerTypes);

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

        public async Task<PagedResult<CustomerTypeDto>> GetManageListPaging(ManageCustomerTypePagingRequest request)
        {
            //1. Select join
            var query = from c in _context.CustomerTypes
                        join ct in _context.CustomerTypeTranslations on c.Id equals ct.CustomerTypeId into cct
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
            var data = await query.Select(x => new CustomerTypeDto()
            {
                Id = x.c.Id,
                Name = x.ct.Name,
                Description = x.c.Description,
                CreatedDate = x.c.CreatedDate,
                LanguageId = x.ct.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<CustomerTypeDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<CustomerTypeDto>> GetById(int customerTypeId, int languageId)
        {
            var customerType = await _context.CustomerTypes.FindAsync(customerTypeId);
            var customerTypeTranslation = await _context.CustomerTypeTranslations.FirstOrDefaultAsync(x => x.CustomerTypeId == customerTypeId
                                                                                                            && x.LanguageId == languageId);

            var customerTypeDto = new CustomerTypeDto()
            {
                Id = customerType.Id,
                CreatedDate = customerType.CreatedDate,
                LanguageId = customerTypeTranslation.LanguageId,
                Name = customerTypeTranslation != null ? customerTypeTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<CustomerTypeDto>(customerTypeDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(CustomerTypeRequest request)
        {
            var customerType = await _context.CustomerTypes.FindAsync(request.Id);
            var customerTypeTranslations = await _context.CustomerTypeTranslations.FirstOrDefaultAsync(x => x.CustomerTypeId == request.Id
            && x.LanguageId == request.LanguageId);

            if (customerType == null || customerTypeTranslations == null) throw new EShopException($"Cannot find a customerType with id: {request.Id}");

            customerTypeTranslations.Name = request.Name;
            customerType.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            customerType.Description = request.Description;
            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}