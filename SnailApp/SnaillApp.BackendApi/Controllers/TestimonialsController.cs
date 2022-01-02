using System;
using System.Linq;
using SnailApp.ViewModels.News.Testimonials;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.News.Testimonials;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialsController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageTestimonialPagingRequest request)
        {
            var testimonials = await _testimonialService.GetManageListPaging(request);
            return Ok(testimonials);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery]TestimonialRequest request)
        {
            var testimonial = await _testimonialService.GetById(request);
            if (testimonial.IsSuccessed)
                if (testimonial.ResultObj == null)
                    return BadRequest("Cannot find testimonial");
            return Ok(testimonial);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromForm] TestimonialRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _testimonialService.UpdateAsync(request);
            }
            else
            {
                res = await _testimonialService.CreateAsync(request);
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
            var result = await _testimonialService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
        [HttpGet("getpublicall")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicAll([FromQuery] ManageTestimonialPagingRequest request)
        {
            var menus = await _testimonialService.GetPublicAll(request);
            return Ok(menus);
        }
        [HttpDelete("deleteimagebytestimonialid/{testimonialId}")]
        public async Task<IActionResult> DeleteImageByTestimonialId(int testimonialId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _testimonialService.DeleteImageByTestimonialId(testimonialId);
            if (result.IsSuccessed)
            {
                if (string.IsNullOrEmpty(result.ResultObj))
                {
                    return BadRequest();
                }
            }

            return Ok(result);
        }
    }
}
