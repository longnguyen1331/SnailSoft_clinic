using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.Sales.Contacts;

namespace SnailApp.Application.Sales.Contacts
{
    public interface IContactService
    {
        Task<ApiResult<int>> CreateAsync(ContactRequest request);
        Task<ApiResult<int>> UpdateAsync(ContactRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ContactDto>> GetById(ContactRequest request);
        Task<PagedResult<ContactDto>> GetManageListPaging(ManageContactPagingRequest request);
    }
    public class ContactService : IContactService
    {
        private readonly EShopDbContext _context;
        
        public ContactService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(ContactRequest request)
        {
            try
            {
                var contact = new Contact()
                {
                    Name = request.Name,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    Message = request.Message,
                    CreatedDate = DateTime.Now
                };

                if (!string.IsNullOrEmpty(request.CreatedUserId))
                {
                    contact.CreatedUserId = Guid.Parse(request.CreatedUserId);
                }
                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    contact.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }

                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(contact.Id);
            }
            catch (Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> UpdateAsync(ContactRequest request)
        {
            try
            {
                var contact = await _context.Contacts.FindAsync(request.Id);

                if (contact == null) throw new EShopException($"Cannot find a contact with id: {request.Id}");

                contact.Name = request.Name;
                contact.Email = request.Email;
                contact.PhoneNumber = request.PhoneNumber;
                contact.Message = request.Message;
                contact.ModifiedDate = DateTime.Now;

                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    contact.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }

                _context.Contacts.Update(contact);

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(contact.Id);
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
                var contacts = await _context.Contacts.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (contacts == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Contacts.RemoveRange(contacts);

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

        public async Task<PagedResult<ContactDto>> GetManageListPaging(ManageContactPagingRequest request)
        {
            //1. Select join
            var query = from c in _context.Contacts
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


            var data = await query.Select(x => new ContactDto() {
                Id = x.c.Id,
                Name = x.c.Name,
                Email = x.c.Email,
                PhoneNumber = x.c.PhoneNumber,
                Message = x.c.Message
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ContactDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<ContactDto>> GetById(ContactRequest request)
        {
            var data = await _context.Contacts.FindAsync(request.Id);

            return new ApiSuccessResult<ContactDto>(new ContactDto() { Id = data.Id });
        }
    }
}