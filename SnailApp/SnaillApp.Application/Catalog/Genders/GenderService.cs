using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Genders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SnailApp.Application.Catalog.Genders
{
    public interface IGenderService
    {
        Task<ApiResult<List<GenderDto>>> GetAll(ManageGenderPagingRequest request);
        Task<PagedResult<GenderDto>> GetManageListPaging(ManageGenderPagingRequest request);
        Task<ApiResult<int>> CreateAsync(GenderRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<GenderDto>> GetById(int genderId, int languageId);
        Task<ApiResult<int>> UpdateAsync(GenderRequest request);
    }
    public class GenderService : IGenderService
    {
        private readonly ClinicDbContext _context;

        public GenderService(ClinicDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult<List<GenderDto>>> GetAll(ManageGenderPagingRequest request)
        {
            var query = from p in _context.Genders
                        join pt in _context.GenderTranslations on p.Id equals pt.GenderId
                        where pt.LanguageId == request.LanguageId
                        select new { p, pt };

            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.pt.Name.Contains(request.TextSearch));
            }

            return new ApiSuccessResult<List<GenderDto>>(await query.Select(x => new GenderDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<int>> CreateAsync(GenderRequest request)
        {
            var languages = _context.Languages;
            var translations = new List<GenderTranslation>();
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new GenderTranslation()
                    {
                        Name = request.Name,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new GenderTranslation()
                    {
                        Name = SystemConstants.AppConstants.NA,
                        LanguageId = language.Id
                    });
                }
            }
            var gender = new Gender()
            {
                GenderTranslations = translations,
                Code = request.Code
            };

            _context.Genders.Add(gender);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(gender.Id);
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var genders = await _context.Genders.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (genders == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                List<int> genderIds = genders.Select(m => m.Id).ToList();
                var genderTranslations = _context.GenderTranslations.Where(m => genderIds.Contains(m.GenderId)).ToList();
                if (genderTranslations != null)
                {
                    _context.GenderTranslations.RemoveRange(genderTranslations);
                }

                _context.Genders.RemoveRange(genders);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<PagedResult<GenderDto>> GetManageListPaging(ManageGenderPagingRequest request)
        {
            //1. Select join
            var query = from p in _context.Genders
                        join pt in _context.GenderTranslations on p.Id equals pt.GenderId into ppt
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
            var data = await query.Select(x => new GenderDto()
            {
                Id = x.p.Id,
                Code = x.p.Code,
                Name = x.pt.Name,
                CreatedDate = x.p.CreatedDate,
                LanguageId = x.pt.LanguageId
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<GenderDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<GenderDto>> GetById(int genderId, int languageId)
        {
            var gender = await _context.Genders.FindAsync(genderId);
            var genderTranslation = await _context.GenderTranslations.FirstOrDefaultAsync(x => x.GenderId == genderId
                                                                                                            && x.LanguageId == languageId);

            var genderDto = new GenderDto()
            {
                Id = gender.Id,
                CreatedDate = gender.CreatedDate,
                LanguageId = genderTranslation.LanguageId,
                Code = gender.Code,
                Name = genderTranslation != null ? genderTranslation.Name : string.Empty,
            };

            return new ApiSuccessResult<GenderDto>(genderDto);
        }

        public async Task<ApiResult<int>> UpdateAsync(GenderRequest request)
        {
            try
            {
                var gender = await _context.Genders.FindAsync(request.Id);
                var genderTranslations = await _context.GenderTranslations.FirstOrDefaultAsync(x => x.GenderId == request.Id
                && x.LanguageId == request.LanguageId);

                if (gender == null || genderTranslations == null) throw new EShopException($"Cannot find a gender with id: {request.Id}");

                gender.Code = request.Code;
                _context.Genders.Update(gender);

                genderTranslations.Name = request.Name;
                _context.GenderTranslations.Update(genderTranslations);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
            
        }
    }
}
