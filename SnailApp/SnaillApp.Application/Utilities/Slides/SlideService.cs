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
using SnailApp.ViewModels.Utilities.Slides;

namespace SnailApp.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<ApiResult<int>> CreateAsync(SlideRequest request);
        Task<ApiResult<int>> UpdateAsync(SlideRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<SlideDto>> GetById(SlideRequest request);
        Task<PagedResult<SlideDto>> GetManageListPaging(ManageSlidePagingRequest request);
        Task<ApiResult<List<SlideDto>>> GetPublicAll(PublicSlidePagingRequest request);
        Task<ApiResult<string>> DeleteImageBySlideId(int slideId);
    }
    public class SlideService : ISlideService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public SlideService(EShopDbContext context, IFileStorageService storageService,
                                IConfiguration configuration)
        {
            _context = context;
            _storageService = storageService;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(SlideRequest request)
        {
            try
            {
                var languages = _context.Languages;
                var translations = new List<SlideTranslation>();
                foreach (var language in languages)
                {
                    if (language.Id == request.LanguageId)
                    {
                        translations.Add(new SlideTranslation()
                        {
                            Name = request.Name,
                            Description = request.Description,
                            LanguageId = request.LanguageId
                        });
                    }
                    else
                    {
                        translations.Add(new SlideTranslation()
                        {
                            Name = SystemConstants.AppConstants.NA,
                            Description = SystemConstants.AppConstants.NA,
                            LanguageId = language.Id
                        });
                    }
                }
                var slide = new Slide()
                {
                    Link = request.Link,
                    SortOrder = request.SortOrder,
                    CreatedUserId = Guid.Parse(request.CreatedUserId),
                    ModifiedUserId = Guid.Parse(request.ModifiedUserId),
                    SlideTranslations = translations
                };
                //Save image
                if (request.Image != null)
                {
                    slide.Image = await this.SaveFile(request.Image);
                }

                _context.Slides.Add(slide);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(slide.Id);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<ApiResult<int>> UpdateAsync(SlideRequest request)
        {
            try
            {
                var slide = await _context.Slides.FindAsync(request.Id);
                var slideTranslations = await _context.SlideTranslations.FirstOrDefaultAsync(x => x.SlideId == request.Id
                                                                                                && x.LanguageId == request.LanguageId);

                if (slide == null || slideTranslations == null) throw new EShopException($"Cannot find a product with id: {request.Id}");

                slideTranslations.Name = request.Name;
                slideTranslations.Description = request.Description;
                _context.SlideTranslations.Update(slideTranslations);

                slide.Link = request.Link;
                slide.SortOrder = request.SortOrder;
                slide.ModifiedDate = DateTime.Now;
                slide.ModifiedUserId = Guid.Parse(request.ModifiedUserId);

                //Save image
                if (request.Image != null)
                {
                    if (slide.Image != null)
                    {
                        await DeleteFile(slide.Image);
                    }

                    slide.Image = await this.SaveFile(request.Image);
                }

                _context.Slides.Update(slide);

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(slide.Id);
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
                var slides = await _context.Slides.Where(m => request.Ids.Contains(m.Id)).ToListAsync();

                if (slides == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                var slideIds = slides.Select(m => m.Id).ToList();
                var slideTranslations = _context.SlideTranslations.Where(i => slideIds.Contains(i.SlideId)).ToList();
                if (slideTranslations != null)
                {
                    _context.SlideTranslations.RemoveRange(slideTranslations);
                }

                foreach (var item in slides)
                {
                    await DeleteFile(item.Image);
                }

                _context.Slides.RemoveRange(slides);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }
        public async Task<PagedResult<SlideDto>> GetManageListPaging(ManageSlidePagingRequest request)

        {
            //1. Select join
            var query = from s in _context.Slides
                        join st in _context.SlideTranslations on s.Id equals st.SlideId into s_st
                        from st in s_st.DefaultIfEmpty()
                        where st.LanguageId == request.LanguageId
                        select new { s, st };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.st.Name.Contains(request.TextSearch));
            }

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

                    case "name":
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

            var data = await query.Select(x => new SlideDto()
            {
                Id = x.s.Id,
                Name = x.st.Name,
                Description = x.st.Description,
                Link = x.s.Link
            }).AsNoTracking().ToListAsync();

            //5. Select and projection
            var pagedResult = new PagedResult<SlideDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
        public async Task<ApiResult<SlideDto>> GetById(SlideRequest request)
        {
            try
            {
                var slide = await (from s in _context.Slides
                                   join st in _context.SlideTranslations on s.Id equals st.SlideId into s_st
                                   from st in s_st.DefaultIfEmpty()
                                   where st.LanguageId == request.LanguageId && s.Id == request.Id
                                   select new SlideDto()
                                   {
                                       Id = s.Id,
                                       Link = s.Link,
                                       Image = (s.Image != null ? _configuration[SystemConstants.SlideConstants.SlideImagePath] + "/" + s.Image : _configuration[SystemConstants.AppConstants.NoImageAvailable]),
                                       Name = st.Name,
                                       Description = st.Description
                                   }).AsNoTracking().FirstOrDefaultAsync();

                return new ApiSuccessResult<SlideDto>(slide);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<SlideDto>(ex.Message);
            }
        }
        public async Task<ApiResult<List<SlideDto>>> GetPublicAll(PublicSlidePagingRequest request)
        {
            //1. Select join
            var query = from s in _context.Slides
                        join st in _context.SlideTranslations on s.Id equals st.SlideId into s_st
                        from st in s_st.DefaultIfEmpty()
                        where st.LanguageId == request.LanguageId
                        select new { s, st };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
            {
                query = query.Where(x => x.st.Name.Contains(request.TextSearch));
            }

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

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.Name) :
                            query.OrderByDescending(x => x.st.Name);

                        break;

                    case "sortOrder":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.st.SortOrder) :
                            query.OrderByDescending(x => x.st.SortOrder);

                        break;
                }
            }

            return new ApiSuccessResult<List<SlideDto>>(await query.Select(x => new SlideDto()
            {
                Id = x.s.Id,
                Link = x.s.Link,
                Name = x.st.Name,
                Description = x.st.Description,
                LanguageId = x.st.LanguageId,
                Image = (!string.IsNullOrEmpty(x.s.Image) ? (_configuration[SystemConstants.SlideConstants.SlideImagePath] + "/" + x.s.Image) : _configuration[SystemConstants.AppConstants.NoImageAvailable]),
                CreatedDate = x.s.CreatedDate,
            }).AsNoTracking().ToListAsync());

        }
        public async Task<ApiResult<string>> DeleteImageBySlideId(int slideId)
        {
            try
            {
                var slide = await _context.Slides.FindAsync(slideId);
                if (slide == null)
                {
                    throw new EShopException($"Cannot find an image with id {slideId}");
                }

                if (slide.Image != null)
                {
                    await DeleteFile(slide.Image);
                }

                _context.Slides.Update(slide);
                await _context.SaveChangesAsync();

                return new ApiSuccessResult<string>(_configuration[SystemConstants.AppConstants.NoImageAvailable]);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<string>(ex.Message);
            }
        }
        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.SlideConstants.SlideImagePath] + "/" + fileName);
            return fileName;
        }
        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.SlideConstants.SlideImagePath] + "/" + fileName);
        }
    }
}