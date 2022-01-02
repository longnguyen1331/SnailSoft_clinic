using System;
using System.Linq;
using SnailApp.ViewModels.System.Statuses.PostTypeStatus;
using SnailApp.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.SystemApplication.Statuses;
using SnailApp.ViewModels.Common;
using Microsoft.Extensions.Configuration;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostTypeStatusesController : ControllerBase
    {
        private readonly IPostTypeStatusService _postTypeStatusService;
        private readonly IConfiguration _configuration;

        public PostTypeStatusesController(IPostTypeStatusService postTypeStatusService, IConfiguration configuration)
        {
            _postTypeStatusService = postTypeStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePostTypeStatusPagingRequest request)
        {
            var posts = await _postTypeStatusService.GetManageListPaging(request);
            return Ok(posts);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManagePostTypeStatusPagingRequest request)
        {
            var stores = await _postTypeStatusService.GetManageListPaging(request);
            return Ok(stores);
        }
        [HttpGet("{postTypeStatusId}")]
        public async Task<IActionResult> GetById(int postTypeStatusId, int languageId)
        {
            var post = await _postTypeStatusService.GetById(postTypeStatusId, languageId);
            if (post.IsSuccessed)
                if (post.ResultObj == null)
                    return BadRequest("Cannot find postTypeStatus");
            return Ok(post);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PostTypeStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _postTypeStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _postTypeStatusService.CreateAsync(request);
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
            var result = await _postTypeStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
