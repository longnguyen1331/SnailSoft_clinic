using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Manufacturers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SnailApp.Application.Catalog.Manufacturers
{
    public interface IManufacturerService
    {
        Task<ApiResult<List<ManufacturerDto>>> GetAll(ManageManufacturerPagingRequest request);
        Task<PagedResult<ManufacturerDto>> GetManageListPaging(ManageManufacturerPagingRequest request);
        Task<ApiResult<int>> CreateAsync(ManufacturerRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ManufacturerDto>> GetById(int manufacturerId, int languageId);
        Task<ApiResult<int>> UpdateAsync(ManufacturerRequest request);
    }
    public class ManufacturerService : IManufacturerService
    {
        private readonly EShopDbContext _context;

        public ManufacturerService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<ManufacturerDto>>> GetAll(ManageManufacturerPagingRequest request)
        {
            var query = from m in _context.Manufacturers
                        join mt in _context.ManufacturerTranslations on m.Id equals mt.ManufacturerId
                        where mt.LanguageId == request.LanguageId
                        select new { m, mt };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.mt.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<ManufacturerDto>>(await query.Select(x => new ManufacturerDto()
            {
                Id = x.m.Id,
                Name = x.mt.Name
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(ManufacturerRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<ManufacturerTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new ManufacturerTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new ManufacturerTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var manufacturer = new Manufacturer()
            {
                CreatedUserId = Guid.Parse(request.CreatedUserId),
                ModifiedUserId = Guid.Parse(request.CreatedUserId),
                Description = request.Description,
                ManufacturerTranslations = translations,
            };

            _context.Manufacturers.Add(manufacturer);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(manufacturer.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var manufacturers = await _context.Manufacturers.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (manufacturers == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> manufacturerIds = manufacturers.Select(m => m.Id).ToList();
                var manufacturerTranslations = _context.ManufacturerTranslations.Where(m => manufacturerIds.Contains(m.ManufacturerId)).ToList();
                if (manufacturerTranslations != null)
                {
                    _context.ManufacturerTranslations.RemoveRange(manufacturerTranslations);
                }

                _context.Manufacturers.RemoveRange(manufacturers);

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

        public async Task<PagedResult<ManufacturerDto>> GetManageListPaging(ManageManufacturerPagingRequest request)
        {
                //1. Select join
                var query = from m in _context.Manufacturers
                            join mt in _context.ManufacturerTranslations on m.Id equals mt.ManufacturerId into mmt
                            from mt in mmt.DefaultIfEmpty()
                            where mt.LanguageId == request.LanguageId
                            select new { m, mt };
                //2. filter
                if (!string.IsNullOrEmpty(request.TextSearch))
                    query = query.Where(x => x.mt.Name.Contains(request.TextSearch));

                //3.Sort
                if (!string.IsNullOrEmpty(request.OrderCol))
                {
                    switch (request.OrderCol)
                    {

                        case "description":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.m.Description) :
                                query.OrderByDescending(x => x.m.Description);

                            break;

                        case "code":
                            query = (request.OrderDir == "asc") ?
                                query.OrderBy(x => x.m.Code) :
                                query.OrderByDescending(x => x.m.Code);

                            break;

                        case "name":
                            query = (request.OrderDir == "asc") ? query.OrderBy(x => x.mt.Name) :
                                query.OrderByDescending(x => x.mt.Name);

                            break;

                        default: break;
                    }
                }


                //4. Paging
                int totalRow = await query.CountAsync();

                if (request.PageIndex != null)
                {
                    query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
                }
                var data = await query.Select(x => new ManufacturerDto()
                {
                    Id = x.m.Id,
                    Name = x.mt.Name,
                    Description = x.m.Description,
                    DayOfActive = (DateTime.Now - x.m.CreatedDate).Days,
                    LanguageId = x.mt.LanguageId
                }).AsNoTracking().ToListAsync();

                //5. Select and projection
                var pagedResult = new PagedResult<ManufacturerDto>()
                {
                    TotalRecords = totalRow,
                    PageSize = request.PageSize,
                    PageIndex = request.PageIndex,
                    Items = data
                };
                return pagedResult;
       
        }

        public async Task<ApiResult<ManufacturerDto>> GetById(int manufacturerId, int languageId)
        {
            var manufacturer = await _context.Manufacturers.FindAsync(manufacturerId);
            var manufacturerTranslation = await _context.ManufacturerTranslations.FirstOrDefaultAsync(x => x.ManufacturerId == manufacturerId
                                                                                                            && x.LanguageId == languageId);

            var manufacturerDto = new ManufacturerDto()
            {
                Id = manufacturer.Id,
                CreatedDate = manufacturer.CreatedDate,
                LanguageId = manufacturerTranslation.LanguageId,
                Name = manufacturerTranslation != null ? manufacturerTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<ManufacturerDto>(manufacturerDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(ManufacturerRequest request)
        {
            var manufacturer = await _context.Manufacturers.FindAsync(request.Id);
            var manufacturerTranslations = await _context.ManufacturerTranslations.FirstOrDefaultAsync(x => x.ManufacturerId == request.Id
            && x.LanguageId == request.LanguageId);

            if (manufacturer == null || manufacturerTranslations == null) throw new EShopException($"Cannot find a manufacturer with id: {request.Id}");

            manufacturerTranslations.Name = request.Name;
            manufacturer.Description = request.Description;
            manufacturer.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}
