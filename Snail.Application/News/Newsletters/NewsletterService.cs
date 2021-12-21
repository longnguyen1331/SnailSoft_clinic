using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Snail.ViewModels.News.Newsletters;

namespace Snail.Application.News.Newsletters
{
    public interface INewsletterService
    {
        Task<ApiResult<int>> CreateAsync(NewsletterRequest request);
        Task<ApiResult<int>> UpdateAsync(NewsletterRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<NewsletterDto>> GetById(NewsletterRequest request);
        Task<PagedResult<NewsletterDto>> GetManageListPaging(ManageNewsletterPagingRequest request);
    }
    public class NewsletterService : INewsletterService
    {
        private readonly EShopDbContext _context;

        public NewsletterService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(NewsletterRequest request)
        {
            var newsletterInformation = new Newsletter()
            {
                Email = request.Email,
                CreatedDate = DateTime.Now
            };

            if (!string.IsNullOrEmpty(request.CreatedUserId))
            {
                newsletterInformation.CreatedUserId = Guid.Parse(request.CreatedUserId);
            }
            if (!string.IsNullOrEmpty(request.ModifiedUserId))
            {
                newsletterInformation.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            }

            _context.Newsletters.Add(newsletterInformation);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(newsletterInformation.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(NewsletterRequest request)
        {
            try
            {
                var newsletterInformation = await _context.Newsletters.FindAsync(request.Id);

                if (newsletterInformation == null) throw new EShopException($"Cannot find a newsletterInformation with id: {request.Id}");

                newsletterInformation.Email = request.Email;
                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    newsletterInformation.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }
                newsletterInformation.ModifiedDate = DateTime.Now;

                _context.Newsletters.Update(newsletterInformation);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(newsletterInformation.Id);

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
                var newsletterInformations = await _context.Newsletters.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (newsletterInformations == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Newsletters.RemoveRange(newsletterInformations);

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

        public async Task<PagedResult<NewsletterDto>> GetManageListPaging(ManageNewsletterPagingRequest request)
        {
            //1. Select join
            var query = from c in _context.Newsletters
                        select new { c };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.c.Email.Contains(request.TextSearch));

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

                    case "email":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.c.Email) :
                            query.OrderByDescending(x => x.c.Email);

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


            var data = await query.Select(x => new NewsletterDto() {
                Id = x.c.Id,
                Email = x.c.Email
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<NewsletterDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<NewsletterDto>> GetById(NewsletterRequest request)
        {
            var data = await _context.Newsletters.FindAsync(request.Id);

            return new ApiSuccessResult<NewsletterDto>(new NewsletterDto() { Id = data.Id });
        }
    }
}