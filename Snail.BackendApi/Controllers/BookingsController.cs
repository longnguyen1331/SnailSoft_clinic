using System;
using System.Linq;
using Snail.ViewModels.Sales.Bookings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Sales.Bookings;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageBookingPagingRequest request)
        {
            var bookings = await _bookingService.GetManageListPaging(request);
            return Ok(bookings);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery]BookingRequest request)
        {
            var booking = await _bookingService.GetById(request);
            if (booking.IsSuccessed)
                if (booking.ResultObj == null)
                    return BadRequest("Cannot find booking");
            return Ok(booking);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] BookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _bookingService.UpdateAsync(request);
            }
            else
            {
                res = await _bookingService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(res);
        }
        [HttpPost("publicaddorupdate")]
        [AllowAnonymous]
        public async Task<IActionResult> PublicAddOrUpdate([FromBody] BookingRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _bookingService.UpdateAsync(request);
            }
            else
            {
                res = await _bookingService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(res);
        }


        [HttpDelete("{ids}")]
        public async Task<IActionResult> DeleteByIds(string ids)
        {
            var result = await _bookingService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
