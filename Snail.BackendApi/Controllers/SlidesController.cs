using System;
using System.Linq;
using Snail.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Utilities.Slides;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SlidesController : ControllerBase
    {
        private readonly ISlideService _slideService;

        public SlidesController(ISlideService slideService)
        {
            _slideService = slideService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageSlidePagingRequest request)
        {
            var slides = await _slideService.GetManageListPaging(request);
            return Ok(slides);
        }
        [HttpGet("getpublicall")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicAll([FromQuery] PublicSlidePagingRequest request)
        {
            var slides = await _slideService.GetPublicAll(request);
            return Ok(slides);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(SlideRequest request)
        {
            var slideService = await _slideService.GetById(request);
            if (slideService.IsSuccessed)
            {
                if (slideService.ResultObj == null)
                {
                    return BadRequest("Cannot find store");
                }
            }

            return Ok(slideService);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] SlideRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> slideService = null;
            if (request.Id != null)
            {
                slideService = await _slideService.UpdateAsync(request);
            }
            else
            {
                slideService = await _slideService.CreateAsync(request);
            }

            if (slideService.IsSuccessed)
            {
                if (slideService.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(slideService);
        }

        [HttpDelete("{ids}")]
        public async Task<IActionResult> DeleteByIds(string ids)
        {
            var slideService = await _slideService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(slideService);
        }
    }
}