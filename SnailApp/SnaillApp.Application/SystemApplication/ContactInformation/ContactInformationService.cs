using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using SnailApp.ViewModels.System.ContactInformation;

namespace SnailApp.Application.SystemApplication.ContactInformation
{
    public interface IContactInformationService
    {
        Task<ApiResult<int>> CreateAsync(ContactInformationRequest request);
        Task<ApiResult<int>> UpdateAsync(ContactInformationRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<ContactInformationDto>> GetById(ContactInformationRequest request);
        Task<PagedResult<ContactInformationDto>> GetManageListPaging(ManageContactInformationPagingRequest request);
        Task<ApiResult<ContactInformationDto>> GetPublicDefault();
    }
    public class ContactInformationService : IContactInformationService
    {
        private readonly EShopDbContext _context;

        public ContactInformationService(EShopDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> CreateAsync(ContactInformationRequest request)
        {
            var contactInformation = new Data.Entities.ContactInformation(){
                Address = request.Address,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                FacebookLink = request.FacebookLink,
                InstagramLink = request.InstagramLink,
                YoutubeLink = request.YoutubeLink,
                IsDefault = request.IsDefault,
                CreatedDate = DateTime.Now
            };

            if(!string.IsNullOrEmpty(request.CreatedUserId))
            {
                contactInformation.CreatedUserId = Guid.Parse(request.CreatedUserId);
            }
            if (!string.IsNullOrEmpty(request.ModifiedUserId))
            {
                contactInformation.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
            }
            _context.ContactInformation.Add(contactInformation);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(contactInformation.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(ContactInformationRequest request)
        {
            try
            {
                var contactInformation = await _context.ContactInformation.FindAsync(request.Id);

                if (contactInformation == null) throw new EShopException($"Cannot find a contactInformation with id: {request.Id}");

                contactInformation.Email = request.Email;
                contactInformation.Address = request.Address;
                contactInformation.PhoneNumber = request.PhoneNumber;
                contactInformation.FacebookLink = request.FacebookLink;
                contactInformation.InstagramLink = request.InstagramLink;
                contactInformation.YoutubeLink = request.YoutubeLink;
                contactInformation.IsDefault = request.IsDefault;
                contactInformation.ModifiedDate = DateTime.Now;

                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    contactInformation.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }

                _context.ContactInformation.Update(contactInformation);

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(contactInformation.Id);

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
                var contactInformations = await _context.ContactInformation.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (contactInformations == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.ContactInformation.RemoveRange(contactInformations);

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

        public async Task<PagedResult<ContactInformationDto>> GetManageListPaging(ManageContactInformationPagingRequest request)
        {
            //1. Select join
            var query = from c in _context.ContactInformation
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


            var data = await query.Select(x => new ContactInformationDto() {
                Id = x.c.Id,
                Email = x.c.Email,
                Address = x.c.Address,
                PhoneNumber = x.c.PhoneNumber,
                FacebookLink = x.c.FacebookLink,
                InstagramLink = x.c.InstagramLink,
                YoutubeLink = x.c.YoutubeLink,
                IsDefault = x.c.IsDefault
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<ContactInformationDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<ContactInformationDto>> GetById(ContactInformationRequest request)
        {
            var data = await _context.ContactInformation.FindAsync(request.Id);

            return new ApiSuccessResult<ContactInformationDto>(new ContactInformationDto() { Id = data.Id });
        }
        public async Task<ApiResult<ContactInformationDto>> GetPublicDefault()
        {
            var contactInformation = await _context.ContactInformation.FirstOrDefaultAsync(m => m.IsDefault == true);

            return new ApiSuccessResult<ContactInformationDto>(new ContactInformationDto() {
                Id = contactInformation.Id,
                Email = contactInformation.Email,
                Address = contactInformation.Address,
                PhoneNumber = contactInformation.PhoneNumber,
                FacebookLink = contactInformation.FacebookLink,
                InstagramLink = contactInformation.InstagramLink,
                YoutubeLink = contactInformation.YoutubeLink,
                IsDefault = contactInformation.IsDefault
            });
        }
    }
}