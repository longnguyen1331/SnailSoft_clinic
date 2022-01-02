using System;
using System.Linq;
using SnailApp.ViewModels.Website.WebsiteMenus;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Website.WebsiteMenus;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WebsiteMenusController : ControllerBase
    {
        private readonly IWebsiteMenuService _websiteMenuService;

        public WebsiteMenusController(IWebsiteMenuService websiteMenuService)
        {
            _websiteMenuService = websiteMenuService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageWebsiteMenuPagingRequest request)
        {
            var websiteMenus = await _websiteMenuService.GetAll(request);
            return Ok(websiteMenus);
        }
        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageWebsiteMenuPagingRequest request)
        {
            var result = await _websiteMenuService.GetManageListPaging(request);
            return Ok(result);
        }

        [HttpGet("gebyid")]
        public async Task<IActionResult> GetById([FromQuery]WebsiteMenuRequest request)
        {
            var result = await _websiteMenuService.GetById(request);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null)
                {
                    return BadRequest("Cannot find websiteMenu");
                }
            }

            return Ok(result);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] WebsiteMenuRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _websiteMenuService.UpdateAsync(request);
            }
            else
            {
                res = await _websiteMenuService.CreateAsync(request);
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
            var result = await _websiteMenuService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
