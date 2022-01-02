using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Units;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SnailApp.Application.Catalog.Units
{
    public interface IUnitService
    {
        Task<ApiResult<List<UnitDto>>> GetAll(ManageUnitPagingRequest request);
        Task<PagedResult<UnitDto>> GetManageListPaging(ManageUnitPagingRequest request);
        Task<ApiResult<int>> CreateAsync(UnitRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<UnitDto>> GetById(int unitId, int languageId);
        Task<ApiResult<int>> UpdateAsync(UnitRequest request);
    }
    public class UnitService : IUnitService
    {
        private readonly EShopDbContext _context;

        public UnitService(EShopDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<UnitDto>>> GetAll(ManageUnitPagingRequest request)
        {
            var query = from m in _context.Units
                        join ut in _context.UnitTranslations on m.Id equals ut.UnitId
                        where ut.LanguageId == request.LanguageId
                        select new { m, ut };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.ut.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<UnitDto>>(await query.Select(x => new UnitDto()
            {
                Id = x.m.Id,
                Name = x.ut.Name
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(UnitRequest request)
        {
            if (!await ExistByCode(null, request.Code))
            {
                var languages = _context.Languages;
                var translations = new List<UnitTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new UnitTranslation()
                        {
                            Name = request.Name,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new UnitTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }
                var unit = new Unit()
                {
                    Code = request.Code,
                    Description = request.Description,
                    UnitTranslations = translations,
                    CreatedUserId = Guid.Parse(request.CreatedUserId),
                    ModifiedUserId = Guid.Parse(request.CreatedUserId),
                };

                _context.Units.Add(unit);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(unit.Id);
            }
            else
            {
                return new ApiErrorResult<int>("Đã tồn tại mã này trong hệ thống.");
            }

        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var units = await _context.Units.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (units == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> unitIds = units.Select(m => m.Id).ToList();
                var unitTranslations = _context.UnitTranslations.Where(m => unitIds.Contains(m.UnitId)).ToList();
                if (unitTranslations != null)
                {
                    _context.UnitTranslations.RemoveRange(unitTranslations);
                }

                _context.Units.RemoveRange(units);

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

        public async Task<PagedResult<UnitDto>> GetManageListPaging(ManageUnitPagingRequest request)
        {

            //1. Select join
            var query = from u in _context.Units
                        join ut in _context.UnitTranslations on u.Id equals ut.UnitId into umt
                        from ut in umt.DefaultIfEmpty()
                        where ut.LanguageId == request.LanguageId
                        select new { u, ut };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.ut.Name.Contains(request.TextSearch));

            //3.Sort
            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "description":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.u.Description) :
                            query.OrderByDescending(x => x.u.Description);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.u.Code) :
                            query.OrderByDescending(x => x.u.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.ut.Name) :
                            query.OrderByDescending(x => x.ut.Name);

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
            var data = await query.Select(x => new UnitDto()
            {
                Id = x.u.Id,
                Code = x.u.Code,
                Name = x.ut.Name,
                Description = x.u.Description,
                DayOfActive = (DateTime.Now - x.ut.CreatedDate).Days,
                LanguageId = x.ut.LanguageId
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<UnitDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<UnitDto>> GetById(int unitId, int languageId)
        {
            var unit = await _context.Units.FindAsync(unitId);
            var unitTranslation = await _context.UnitTranslations.FirstOrDefaultAsync(x => x.UnitId == unitId
                                                                                                            && x.LanguageId == languageId);

            var unitDto = new UnitDto()
            {
                Id = unit.Id,
                CreatedDate = unit.CreatedDate,
                LanguageId = unitTranslation.LanguageId,
                Name = unitTranslation != null ? unitTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<UnitDto>(unitDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(UnitRequest request)
        {
            if (!await ExistByCode(request.Id, request.Code))
            {
                var unit = await _context.Units.FindAsync(request.Id);
                var unitTranslations = await _context.UnitTranslations.FirstOrDefaultAsync(x => x.UnitId == request.Id
                && x.LanguageId == request.LanguageId);

                if (unit == null || unitTranslations == null) throw new EShopException($"Cannot find a unit with id: {request.Id}");

                unitTranslations.Name = request.Name;
                unit.Code = request.Code;
                unit.Description = request.Description;
                unit.ModifiedUserId = Guid.Parse(request.ModifiedUserId);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            else
            {
                return new ApiErrorResult<int>("Đã tồn tại mã này trong hệ thống.");
            }

        }


        public async Task<bool> ExistByCode(int? id, string code)
        {
            Unit unit = null;
            if (id.HasValue) { 

                unit = await _context.Units.Where(x => x.Code.Trim().ToLower() == code.Trim().ToLower() && x.Id != id.Value).FirstOrDefaultAsync();
            }
            else
            {
                unit = await _context.Units.Where(x => x.Code.Trim().ToLower() == code.Trim().ToLower()).FirstOrDefaultAsync();

            }

            return unit != null;
        }

    }
}
