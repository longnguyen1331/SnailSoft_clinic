using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Catalog.PetServiceSelections;

namespace SnailApp.Application.Catalog.PetServiceSelections
{
    public interface IPetServiceSelectionService
    {
        Task<ApiResult<List<PetServiceSelectionDto>>> GetAll(ManagePetServiceSelectionPagingRequest request);
        Task<PagedResult<PetServiceSelectionDto>> GetManageListPaging(ManagePetServiceSelectionPagingRequest request);
        Task<ApiResult<int>> CreateAsync(PetServiceSelectionRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<PetServiceSelectionDto>> GetById(PetServiceSelectionRequest request);
        Task<ApiResult<int>> UpdateAsync(PetServiceSelectionRequest request);
    }
    public class PetServiceSelectionService : IPetServiceSelectionService
    {
        private readonly ClinicDbContext _context;

        public PetServiceSelectionService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<PetServiceSelectionDto>>> GetAll(ManagePetServiceSelectionPagingRequest request)
        {
            var query = from p in _context.PetServiceSelections
                        join pt in _context.PetServiceSelectionTranslations on p.Id equals pt.PetServiceSelectionId
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<PetServiceSelectionDto>>(await query.Select(x => new PetServiceSelectionDto()
            {
                Id = x.p.Id,
                Name = x.pt.Name
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(PetServiceSelectionRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<PetServiceSelectionTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new PetServiceSelectionTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new PetServiceSelectionTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var petServiceSelection = new PetServiceSelection()
            {
                CreatedUserId = Guid.Parse(request.CreatedUserId),
                ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                PetServiceSelectionTranslations = translations
            };

            _context.PetServiceSelections.Add(petServiceSelection);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(petServiceSelection.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var petServiceSelections = await _context.PetServiceSelections.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (petServiceSelections == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> petServiceSelectionIds = petServiceSelections.Select(m => m.Id).ToList();
                var petServiceSelectionTranslations = _context.PetServiceSelectionTranslations.Where(m => petServiceSelectionIds.Contains(m.PetServiceSelectionId)).ToList();
                if (petServiceSelectionTranslations != null)
                {
                    _context.PetServiceSelectionTranslations.RemoveRange(petServiceSelectionTranslations);
                }

                _context.PetServiceSelections.RemoveRange(petServiceSelections);

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

        public async Task<PagedResult<PetServiceSelectionDto>> GetManageListPaging(ManagePetServiceSelectionPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.PetServiceSelections
                        join pt in _context.PetServiceSelectionTranslations on p.Id equals pt.PetServiceSelectionId into ppt
                        from pt in ppt.DefaultIfEmpty()
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));

            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new PetServiceSelectionDto()
            {
                Id = x.p.Id,
                Name = x.pt.Name,
                CreatedDate = x.p.CreatedDate,
                LanguageId = x.pt.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<PetServiceSelectionDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<PetServiceSelectionDto>> GetById(PetServiceSelectionRequest request)
        {
            var petServiceSelection = await _context.PetServiceSelections.FindAsync(request.Id);
            var petServiceSelectionTranslation = await _context.PetServiceSelectionTranslations.FirstOrDefaultAsync(x => x.PetServiceSelectionId == request.Id
                                                                                                            && x.LanguageId == request.LanguageId);

            var petServiceSelectionDto = new PetServiceSelectionDto()
            {
                Id = petServiceSelection.Id,
                CreatedDate = petServiceSelection.CreatedDate,
                LanguageId = petServiceSelectionTranslation.LanguageId,
                Name = petServiceSelectionTranslation != null ? petServiceSelectionTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<PetServiceSelectionDto>(petServiceSelectionDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(PetServiceSelectionRequest request)
        {
            var petServiceSelection = await _context.PetServiceSelections.FindAsync(request.Id);
            var petServiceSelectionTranslations = await _context.PetServiceSelectionTranslations.FirstOrDefaultAsync(x => x.PetServiceSelectionId == request.Id
            && x.LanguageId == request.LanguageId);

            if (petServiceSelection == null || petServiceSelectionTranslations == null) throw new EShopException($"Cannot find a petServiceSelection with id: {request.Id}");

            petServiceSelection.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            petServiceSelection.ModifiedDate = DateTime.Now;
            _context.PetServiceSelections.Update(petServiceSelection);

            petServiceSelectionTranslations.Name = request.Name;
            _context.PetServiceSelectionTranslations.Update(petServiceSelectionTranslations);

            return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
        }
    }
}