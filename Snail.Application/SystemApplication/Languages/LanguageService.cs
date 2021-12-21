using Snail.Application.Common;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
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
using Snail.ViewModels.System.Languages;

namespace Snail.Application.SystemApplication.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<int>> CreateAsync(LanguageRequest request);

        Task<ApiResult<int>> UpdateAsync(LanguageRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<LanguageDto>> GetById(int id);

        Task<PagedResult<LanguageDto>> GetManageListPaging(ManageLanguagePagingRequest request);
        Task<PagedResult<LanguageDto>> GetAll();
    }
    public class LanguageService : ILanguageService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public LanguageService(EShopDbContext context, IFileStorageService storageService,
                                IConfiguration configuration)
        {
            _context = context;
            _storageService = storageService;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(LanguageRequest request)
        {
            var language = new Language()
            {
                Code = request.Code,
                Name = request.Name,
                CreatedDate = DateTime.Now
            };

            _context.Languages.Add(language);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(language.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(LanguageRequest request)
        {
            try
            {
                var language = await _context.Languages.FindAsync(request.Id);

                if (language == null) throw new EShopException($"Cannot find a language with id: {request.Id}");

                language.Code = request.Code;
                language.Name = request.Name;
                language.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(language.Id);

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
                var languages = await _context.Languages.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (languages == null) throw new EShopException($"Cannot find language: {request.Ids.ToString()}");

                _context.Languages.RemoveRange(languages);

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

        public async Task<PagedResult<LanguageDto>> GetManageListPaging(ManageLanguagePagingRequest request)
        {
            //1. Select join
            var query = from l in _context.Languages
                        select new { l };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.l.Name.Contains(request.TextSearch)
                || x.l.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.l.Id) :
                            query.OrderByDescending(x => x.l.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.l.Code) :
                            query.OrderByDescending(x => x.l.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.l.Name) :
                            query.OrderByDescending(x => x.l.Name);

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


            var data = await query.Select(x => new LanguageDto()
            {
                Id = x.l.Id,
                Code = x.l.Code,
                Name = x.l.Name
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<LanguageDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<LanguageDto>> GetById(int id)
        {
            var language = await _context.Languages.FindAsync(id);

            var languageDto = new LanguageDto()
            {
                Id = language.Id,
                Code = language.Code,
                Name = language.Name
            };
            return new ApiSuccessResult<LanguageDto>(languageDto);
        }

        public async Task<PagedResult<LanguageDto>> GetAll()
        {
            var query = from s in _context.Languages
                        select new { s };

            var data = await query.Select(x => new LanguageDto()
            {
                Id = x.s.Id,
                Code = x.s.Code,
                Name = x.s.Name
            }).AsNoTracking().ToListAsync();

            var pagedResult = new PagedResult<LanguageDto>()
            {
                TotalRecords = 0,
                PageSize =0,
                PageIndex = 0,
                Items = data
            };
            return pagedResult;

        }
    }
}
