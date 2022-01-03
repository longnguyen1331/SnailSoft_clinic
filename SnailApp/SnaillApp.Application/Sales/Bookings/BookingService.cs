using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Exceptions;
using SnailApp.Utilities.Constants;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.PetServiceSelections;
using SnailApp.ViewModels.Sales.Bookings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

namespace SnailApp.Application.Sales.Bookings
{
    public interface IBookingService
    {
        Task<ApiResult<int>> CreateAsync(BookingRequest request);
        Task<ApiResult<int>> UpdateAsync(BookingRequest request);
        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);
        Task<ApiResult<BookingDto>> GetById(BookingRequest request);
        Task<PagedResult<BookingDto>> GetManageListPaging(ManageBookingPagingRequest request);
    }
    public class BookingService : IBookingService
    {
        private readonly ClinicDbContext _context;
        private readonly IConfiguration _configuration;

        public BookingService(ClinicDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(BookingRequest request)
        {
            DateTime ngayValue;

            try
            {
                var bookingInformation = new Booking()
                {
                    Name = request.Name,
                    Email = request.Email,
                    PhoneNumber = request.PhoneNumber,
                    PetName = request.PetName,
                    PetWeight = request.PetWeight,
                    DateContact = (DateTime.TryParseExact(request.DateContact, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now),
                    PetServiceSelectionId = request.PetServiceSelectionId,
                    SpecialNote = request.SpecialNote,
                    CreatedDate = DateTime.Now
                };

                if (!string.IsNullOrEmpty(request.CreatedUserId))
                {
                    bookingInformation.CreatedUserId = Guid.Parse(request.CreatedUserId);
                }
                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    bookingInformation.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }

                _context.Bookings.Add(bookingInformation);
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(bookingInformation.Id);
            }
            catch(Exception ex)
            {
                return new ApiErrorResult<int>(ex.Message);
            }
        }

        public async Task<ApiResult<int>> UpdateAsync(BookingRequest request)
        {
            DateTime ngayValue;
            try
            {
                var bookingInformation = await _context.Bookings.FindAsync(request.Id);

                if (bookingInformation == null) throw new EShopException($"Cannot find a bookingInformation with id: {request.Id}");

                bookingInformation.Name = request.Name;
                bookingInformation.Email = request.Email;
                bookingInformation.PhoneNumber = request.PhoneNumber;
                bookingInformation.PetName = request.PetName;
                bookingInformation.PetWeight = request.PetWeight;
                bookingInformation.DateContact = (DateTime.TryParseExact(request.DateContact, _configuration[SystemConstants.AppConstants.DateFormat], null, DateTimeStyles.None, out ngayValue) ? ngayValue : DateTime.Now);
                bookingInformation.PetServiceSelectionId = request.PetServiceSelectionId;
                bookingInformation.SpecialNote = request.SpecialNote;
                bookingInformation.ModifiedDate = DateTime.Now;
                if (!string.IsNullOrEmpty(request.ModifiedUserId))
                {
                    bookingInformation.ModifiedUserId = Guid.Parse(request.ModifiedUserId);
                }

                _context.Bookings.Update(bookingInformation);

                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(bookingInformation.Id);

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
                var bookingInformations = await _context.Bookings.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (bookingInformations == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Bookings.RemoveRange(bookingInformations);

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

        public async Task<PagedResult<BookingDto>> GetManageListPaging(ManageBookingPagingRequest request)
        {
            //1. Select join
            var query = from b in _context.Bookings                            
                        select new { b };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.b.Name.Contains(request.TextSearch)
                || x.b.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.b.Id) :
                            query.OrderByDescending(x => x.b.Id);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.b.Name) :
                            query.OrderByDescending(x => x.b.Name);

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


            var data = await query.Select(x => new BookingDto() {
                Id = x.b.Id,
                Name = x.b.Name,
                Email = x.b.Email,
                PhoneNumber = x.b.PhoneNumber,
                PetName = x.b.PetName,
                PetWeight = x.b.PetWeight,
                StrDateContact = x.b.DateContact.ToString("dd/MM/yyyy"),
                SpecialNote = x.b.SpecialNote,
                PetServiceSelectionId = x.b.PetServiceSelectionId
            }).AsNoTracking().ToListAsync();

            var petServiceSelectionIds = data.Select(m => m.PetServiceSelectionId).ToList();

            var petServiceSelections = await (from p in _context.PetServiceSelections
                                              join pt in _context.PetServiceSelectionTranslations on p.Id equals pt.PetServiceSelectionId into p_pt
                                              from pt in p_pt.DefaultIfEmpty()
                                              where petServiceSelectionIds.Contains(p.Id)
                                              select new PetServiceSelectionDto()
                                              {
                                                  Id = p.Id,
                                                  Name = pt.Name
                                              }).AsNoTracking().ToListAsync();

            foreach (var booking in data)
            {
                booking.PetServiceSelection = petServiceSelections.FirstOrDefault(m => m.Id == booking.PetServiceSelectionId);
            }

            //4. Select and projection
            var pagedResult = new PagedResult<BookingDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<BookingDto>> GetById(BookingRequest request)
        {
            var data = await _context.Bookings.FindAsync(request.Id);

            return new ApiSuccessResult<BookingDto>(new BookingDto() { Id = data.Id });
        }
    }
}