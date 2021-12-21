using System;
using System.Linq;
using Snail.ViewModels.Catalog.PostTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Catalog.PostTypes;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostTypesController : ControllerBase
    {
        private readonly IPostTypeService _postTypeService;

        public PostTypesController(IPostTypeService postTypeService)
        {
            _postTypeService = postTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] ManagePostTypePagingRequest request)
        {
            var postTypes = await _postTypeService.GetAll(request);
            return Ok(postTypes);
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePostTypePagingRequest request)
        {
            var postTypes = await _postTypeService.GetManageListPaging(request);
            return Ok(postTypes);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] PostTypeRequest request)
        {
            var postType = await _postTypeService.GetById(request);
            if (postType.IsSuccessed)
                if (postType.ResultObj == null)
                    return BadRequest("Cannot find postType");
            return Ok(postType);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PostTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _postTypeService.UpdateAsync(request);
            }
            else
            {
                res = await _postTypeService.CreateAsync(request);
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
            var result = await _postTypeService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
