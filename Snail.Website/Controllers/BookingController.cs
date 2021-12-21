using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChinoPet.ViewModels.Common;
using ChinoPet.ApiIntegration;
using ChinoPet.ViewModels.Sales.Bookings;

namespace ChinoPet.Website.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingApiClient _bookingApiClient;

        public BookingController(IBookingApiClient bookingApiClient)
        {
            _bookingApiClient = bookingApiClient;
        }
        [HttpPost]
        public async Task<IActionResult> Save([FromBody] AddEditRequest<BookingRequest> rq)
        {
            ApiResult<int> result = null;

            if (rq != null)
            {
                result = await _bookingApiClient.PublicAddOrUpdateAsync(rq.Data);
            }
            else
            {
                result = new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = "Không có dữ liệu"
                };
            }

            return Ok(result);
        }
    }
}
