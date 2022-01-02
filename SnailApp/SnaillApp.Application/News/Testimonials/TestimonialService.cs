using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.Utilities.Constants;
using SnailApp.Application.Common;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.News.Testimonials;

namespace SnailApp.Application.News.Testimonials
{
    public interface ITestimonialService
    {
        Task<ApiResult<int>> CreateAsync(TestimonialRequest request);
        Task<ApiResult<int>> UpdateAsync(TestimonialRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<TestimonialDto>> GetById(TestimonialRequest request);
        Task<PagedResult<TestimonialDto>> GetManageListPaging(ManageTestimonialPagingRequest request);
        Task<ApiResult<List<TestimonialDto>>> GetPublicAll(ManageTestimonialPagingRequest request);
        Task<ApiResult<string>> DeleteImageByTestimonialId(int testimonialId);
    }
    public class TestimonialService : ITestimonialService
    {
        private readonly EShopDbContext _context;
        private readonly IFileStorageService _storageService;
        private readonly IConfiguration _configuration;

        public TestimonialService(EShopDbContext context, IFileStorageService storageService,
                                IConfiguration configuration)
        {
            _context = context;
            _storageService = storageService;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(TestimonialRequest request)
        {
            var testimonial = new Testimonial()
            {
                SortOrder = request.SortOrder,
                Code = request.Code,
                Name = request.Name,
                Description = request.Description,
                CreatedDate = DateTime.Now
            };

            if (!string.IsNullOrEmpty(request.CreatedUserId))
            {
                testimonial.CreatedUserId = Guid.Parse(request.CreatedUserId);
            }
            if (!string.IsNullOrEmpty(request.ModifiedUserId))
            {
                testimonial.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            }

            //Save image
            if (request.Image != null)
            {
                testimonial.Image = await this.SaveFile(request.Image);
            }

            _context.Testimonials.Add(testimonial);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(testimonial.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(TestimonialRequest request)
        {
            try
            {
                var testimonial = await _context.Testimonials.FindAsync(request.Id);

                if (testimonial == null) throw new EShopException($"Cannot find a testimonial with id: {request.Id}");

                testimonial.SortOrder = request.SortOrder;
                testimonial.Code = request.Code;
                testimonial.Name = request.Name;
                testimonial.Description = request.Description;
                testimonial.ModifiedDate = DateTime.Now;
                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    testimonial.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }

                //Save image
                if (request.Image != null)
                {
                    if (!string.IsNullOrEmpty(testimonial.Image))
                    {
                        await DeleteFile(testimonial.Image);
                    }

                    testimonial.Image = await this.SaveFile(request.Image);
                }

                _context.Testimonials.Update(testimonial);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(testimonial.Id);

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
                var testimonials = await _context.Testimonials.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (testimonials == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                foreach(var testimonial in testimonials)
                {
                    if (testimonial.Image != null)
                    {
                        if (!string.IsNullOrEmpty(testimonial.Image))
                        {
                            await DeleteFile(testimonial.Image);
                        }
                    }
                }

                _context.Testimonials.RemoveRange(testimonials);

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

        public async Task<PagedResult<TestimonialDto>> GetManageListPaging(ManageTestimonialPagingRequest request)
        {
            //1. Select join
            var query = from c in _context.Testimonials
                        select new { c };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.c.Name.Contains(request.TextSearch)
                || x.c.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.c.Id) :
                            query.OrderByDescending(x => x.c.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.c.Code) :
                            query.OrderByDescending(x => x.c.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.c.Name) :
                            query.OrderByDescending(x => x.c.Name);

                        break;

                    case "sortOrder":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.c.SortOrder) :
                            query.OrderByDescending(x => x.c.SortOrder);

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


            var data = await query.Select(x => new TestimonialDto() {
                Id = x.c.Id,
                SortOrder = x.c.SortOrder,
                Code = x.c.Code,
                Name = x.c.Name,
                Description = x.c.Description,
                Image = (!string.IsNullOrEmpty(x.c.Image) ? _configuration[SystemConstants.TestimonialConstants.ImagePath] + "/" + x.c.Image : _configuration[SystemConstants.AppConstants.NoImageAvailable]),
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<TestimonialDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<TestimonialDto>> GetById(TestimonialRequest request)
        {
            var data = await _context.Testimonials.FindAsync(request.Id);

            return new ApiSuccessResult<TestimonialDto>(new TestimonialDto() { 
                Id = data.Id,
                SortOrder = data.SortOrder,
                Code = data.Code,
                Name = data.Name,
                Description = data.Description,
                Image = (!string.IsNullOrEmpty(data.Image) ? _configuration[SystemConstants.TestimonialConstants.ImagePath] + "/" + data.Image : _configuration[SystemConstants.AppConstants.NoImageAvailable]),
            });
        }
        public async Task<ApiResult<List<TestimonialDto>>> GetPublicAll(ManageTestimonialPagingRequest request)
        {
            //1. Select join
            var query = from t in _context.Testimonials
                        select new { t };

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.t.Id) :
                            query.OrderByDescending(x => x.t.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.t.Code) :
                            query.OrderByDescending(x => x.t.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.t.Name) :
                            query.OrderByDescending(x => x.t.Name);

                        break;

                    case "sortOrder":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.t.SortOrder) :
                            query.OrderByDescending(x => x.t.SortOrder);

                        break;

                    default:
                        query.OrderBy(x => x.t.SortOrder);

                        break;
                }
            }

            return new ApiSuccessResult<List<TestimonialDto>>(await query.Select(x => new TestimonialDto()
            {
                SortOrder = x.t.SortOrder,
                Code = x.t.Code,
                Name = x.t.Name,
                Description = x.t.Description,
                Image = (!string.IsNullOrEmpty(x.t.Image) ? _configuration[SystemConstants.TestimonialConstants.ImagePath] + "/" + x.t.Image : _configuration[SystemConstants.AppConstants.NoImageAvailable]),
                
            }).AsNoTracking().ToListAsync());
        }
        public async Task<ApiResult<string>> DeleteImageByTestimonialId(int testimonialId)
        {
            try
            {
                var testimonial = await _context.Testimonials.FindAsync(testimonialId);
                if (testimonial == null)
                {
                    throw new EShopException($"Cannot find an Testimonial with id {testimonialId}");
                }

                if (!string.IsNullOrEmpty(testimonial.Image))
                {
                    await DeleteFile(testimonial.Image);
                    testimonial.Image = string.Empty;
                }
                
                _context.Testimonials.Update(testimonial);
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
            await _storageService.SaveFileAsync(file.OpenReadStream(), _configuration[SystemConstants.TestimonialConstants.ImagePath] + "/" + fileName);
            return fileName;
        }
        private async Task DeleteFile(string fileName)
        {
            await _storageService.DeleteFileAsync(_configuration[SystemConstants.TestimonialConstants.ImagePath] + "/" + fileName);
        }
    }
}