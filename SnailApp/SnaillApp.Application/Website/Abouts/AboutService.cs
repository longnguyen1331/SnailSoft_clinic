using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
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
using SnailApp.ViewModels.Website.Abouts;
using SnailApp.ViewModels.Enums;
using System.Xml.Linq;

namespace SnailApp.Application.Website.Abouts
{
    public interface IAboutService
    {
        Task<ApiResult<int>> CreateAsync(AboutRequest request);
        Task<ApiResult<int>> UpdateAsync(AboutRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<AboutDto>> GetById(AboutRequest request);
        Task<PagedResult<AboutDto>> GetManageListPaging(ManageAboutPagingRequest request);
        Task<PagedResult<AboutDto>> GetAll(ManageAboutPagingRequest request);
    }
    public class AboutService : IAboutService
    {
        private readonly ClinicDbContext _context;
        
        public AboutService(ClinicDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(AboutRequest request)
        {
            try
            {
                var languages = _context.Languages;
                var translations = new List<AboutTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new AboutTranslation()
                        {
                            Name = request.Name,
                            Address = request.Address,
                            Phone = request.Phone,
                            Facebook = request.Facebook,
                            Instagram = request.Instagram,
                            Youtube = request.Youtube,
                            GoogleMap = request.GoogleMap,
                            Logo = request.Logo,
                            AboutUs = request.AboutUs,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new AboutTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            Description = SystemConstants.AppConstants.NA,
                            Address = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }

                if (request.IsDefault == true)
                {
                    foreach (var item in await (_context.Abouts.Where(m => m.IsDefault).ToListAsync()))
                    {
                        item.IsDefault = false;
                        _context.Abouts.Update(item);
                    }
                }

                var about = new About()
                {
                    Name = request.Name,
                    IsDefault = request.IsDefault,
                    CreatedDate = DateTime.Now,
                    CreatedUserId = request.CreatedUserId,
                    ModifiedUserId = request.ModifiedUserId,
                    AboutTranslations = translations
                };

                _context.Abouts.Add(about);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(about.Id);
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

        public async Task<ApiResult<int>> UpdateAsync(AboutRequest request)
        {
            try
            {
                var about = await _context.Abouts.FindAsync(request.Id);


                var aboutTranslations = await _context.AboutTranslations.FirstOrDefaultAsync(x => x.AboutId == request.Id
                    && x.LanguageId == request.LanguageId);

                if (about == null || aboutTranslations == null) throw new EShopException($"Cannot find a product with id: {request.Id}");




                if (request.IsDefault)
                {
                    foreach (var item in await (_context.Abouts.Where(m => m.IsDefault).ToListAsync()))
                    {
                        item.IsDefault = false;
                        _context.Abouts.Update(item);
                    }
                }

                aboutTranslations.Name = request.Name;
                aboutTranslations.Address = request.Address;
                aboutTranslations.Name = request.Name;
                aboutTranslations.Address = request.Address;
                aboutTranslations.Phone = request.Phone;
                aboutTranslations.Facebook = request.Facebook;
                aboutTranslations.Instagram = request.Instagram;
                aboutTranslations.Youtube = request.Youtube;
                aboutTranslations.GoogleMap = request.GoogleMap;
                aboutTranslations.Logo = request.Logo;
                aboutTranslations.AboutUs = request.AboutUs;



                about.Code = request.Code;
                about.ModifiedDate = DateTime.Now;
                about.ModifiedUserId = request.ModifiedUserId;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(about.Id);

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
                var abouts = await _context.Abouts.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (abouts == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");


                var aboutIds = abouts.Select(m => m.Id).ToList();
                var aboutTranslations = _context.AboutTranslations.Where(i => aboutIds.Contains(i.AboutId)).ToList();
                if (aboutTranslations != null)
                {
                    _context.AboutTranslations.RemoveRange(aboutTranslations);
                }
                
                _context.Abouts.RemoveRange(abouts);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch(Exception ex)
            {
                return new ApiResult<int>(){
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }
        public async Task<PagedResult<AboutDto>> GetManageListPaging(ManageAboutPagingRequest request)

        {
            //1. Select join
            var query = from s in _context.Abouts
                        join st in _context.AboutTranslations on s.Id equals st.AboutId into sst
                        from st in sst.DefaultIfEmpty()
                        where st.LanguageId == request.LanguageId && st.LanguageId == request.LanguageId
                        select new { s,st };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.st.Name.Contains(request.TextSearch) 
                || x.s.Code.Contains(request.TextSearch)
                || x.st.Address.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.s.Id) :
                            query.OrderByDescending(x => x.s.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ? 
                            query.OrderBy(x => x.s.Code) :
                            query.OrderByDescending(x =>  x.s.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

                        break;

                    case "phone":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.s.Name) :
                            query.OrderByDescending(x => x.s.Name);

                        break;

                    case "address":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

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

            var data = await query.Select(x => new AboutDto() { 
                Id = x.s.Id,
                Code = x.s.Code,
                Email = x.st.Email,
                Phone = x.st.Phone,
                DayOfActive = (DateTime.Now  - x.s.CreatedDate).Days,
                Name = x.st.Name,
                Address = x.st.Address,
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<AboutDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<PagedResult<AboutDto>> GetAll(ManageAboutPagingRequest request)
        {
            //1. Select join
            var query = from s in _context.Abouts
                        join st in _context.AboutTranslations on s.Id equals st.AboutId
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.st.Name.Contains(request.TextSearch)
                || x.s.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.s.Id) :
                            query.OrderByDescending(x => x.s.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.s.Code) :
                            query.OrderByDescending(x => x.s.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

                        break;

                    default: break;
                }
            }

            var data = await query.Select(x => new AboutDto()
            {
                Id = x.s.Id,
                Code = x.s.Code,
                Name = x.st.Name
            }).AsNoTracking().ToListAsync();

            var pagedResult = new PagedResult<AboutDto>()
            {
                TotalRecords = 0,
                PageSize = 0,
                PageIndex = 0,
                Items = data
            };
            return pagedResult;

        }
        public async Task<ApiResult<AboutDto>> GetById(AboutRequest request)
        {
            var about = await _context.Abouts.FindAsync(request.Id);
            var aboutTranslation = await _context.AboutTranslations.FirstOrDefaultAsync(x => x.AboutId == request.Id
                                                                                          && x.LanguageId == request.LanguageId);

            var aboutDto = new AboutDto()
            {
                Id = about.Id,
                CreatedDate = about.CreatedDate,
                LanguageId = (aboutTranslation != null ? aboutTranslation.LanguageId : 0),
                Code = about.Code,
                Name = (aboutTranslation != null ? aboutTranslation.Name : string.Empty)
            };

            return new ApiSuccessResult<AboutDto>(aboutDto);
        }
    }
}