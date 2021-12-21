using System;
using System.Linq;
using Snail.ViewModels.System.Statuses.PostStatus;
using Snail.Utilities.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.SystemApplication.Statuses;
using Snail.ViewModels.Common;
using Microsoft.Extensions.Configuration;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostStatusesController : ControllerBase
    {
        private readonly IPostStatusService _postStatusService;
        private readonly IConfiguration _configuration;

        public PostStatusesController(IPostStatusService postStatusService, IConfiguration configuration)
        {
            _postStatusService = postStatusService;
            _configuration = configuration;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePostStatusPagingRequest request)
        {
            var posts = await _postStatusService.GetManageListPaging(request);
            return Ok(posts);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManagePostStatusPagingRequest request)
        {
            var stores = await _postStatusService.GetManageListPaging(request);
            return Ok(stores);
        }
        [HttpGet("{postStatusId}")]
        public async Task<IActionResult> GetById(int postStatusId, int languageId)
        {
            var post = await _postStatusService.GetById(postStatusId, languageId);
            if (post.IsSuccessed)
                if (post.ResultObj == null)
                    return BadRequest("Cannot find postStatus");
            return Ok(post);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PostStatusRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _postStatusService.UpdateAsync(request);
            }
            else
            {
                res = await _postStatusService.CreateAsync(request);
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
            var result = await _postStatusService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
