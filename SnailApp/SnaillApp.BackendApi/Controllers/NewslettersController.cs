using System;
using System.Linq;
using SnailApp.ViewModels.News.Newsletters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.News.Newsletters;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class NewslettersController : ControllerBase
    {
        private readonly INewsletterService _newsletterService;

        public NewslettersController(INewsletterService newsletterService)
        {
            _newsletterService = newsletterService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageNewsletterPagingRequest request)
        {
            var newsletters = await _newsletterService.GetManageListPaging(request);
            return Ok(newsletters);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery]NewsletterRequest request)
        {
            var newsletter = await _newsletterService.GetById(request);
            if (newsletter.IsSuccessed)
                if (newsletter.ResultObj == null)
                    return BadRequest("Cannot find newsletter");
            return Ok(newsletter);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] NewsletterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _newsletterService.UpdateAsync(request);
            }
            else
            {
                res = await _newsletterService.CreateAsync(request);
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
        public async Task<IActionResult> PublicAddOrUpdate([FromBody] NewsletterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _newsletterService.UpdateAsync(request);
            }
            else
            {
                res = await _newsletterService.CreateAsync(request);
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
            var result = await _newsletterService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
