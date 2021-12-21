using System;
using System.Linq;
using Snail.ViewModels.News.Posts;
using Snail.ViewModels.News.PostImages;
using Snail.ViewModels.Common;
using Snail.Application.News.Posts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePostPagingRequest request)
        {
            var posts = await _postService.GetManageListPaging(request);
            return Ok(posts);
        }

        [HttpGet("getpubliclistpaging")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicListPaging([FromQuery] PublicPostPagingRequest request)
        {
            var posts = await _postService.GetPublicListPaging(request);
            return Ok(posts);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] PostRequest request)
        {
            var post = await _postService.GetById(request);
            if (post.IsSuccessed)
            {
                if (post.ResultObj == null)
                {
                    return BadRequest("Cannot find post");
                }
            }

            return Ok(post);
        }

        [HttpGet("getpublicbyid")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicById([FromQuery] PostRequest request)
        {
            var post = await _postService.GetPublicById(request);
            if (post.IsSuccessed)
            {
                if (post.ResultObj == null)
                {
                    return BadRequest("Cannot find post");
                }
            }

            return Ok(post);
        }
        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromForm] PostRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _postService.UpdateAsync(request);
            }
            else
            {
                res = await _postService.CreateAsync(request);
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
            var result = await _postService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }

        [HttpPost("createimage")]
        public async Task<IActionResult> CreateImage([FromForm] PostImageRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var image = await _postService.AddImage(request);
            if (image.IsSuccessed)
            {
                if (image.ResultObj == 0)
                    return BadRequest();
            }            

            var imageDto = await _postService.GetImageById(image.ResultObj);

            return CreatedAtAction(nameof(GetImageById), new { id = imageDto.ResultObj }, image);
        }

        [HttpPut("updateimage")]
        public async Task<IActionResult> UpdateImage([FromForm] PostImageRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _postService.UpdateImage(request);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == 0)
                    return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("removeimages/{ids}")]
        public async Task<IActionResult> RemoveImages(string ids)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _postService.RemoveImages(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });
            if (result.IsSuccessed)
            {
                if (result.ResultObj == 0)
                    return BadRequest();
            }
           
            return Ok();
        }

        [HttpDelete("deletethumbnailimagebypostid/{postId}")]
        public async Task<IActionResult> DeleteThumbnailImageByPostId(int postId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _postService.DeleteThumbnailImageByPostId(postId);
            if (result.IsSuccessed)
            {
                if (string.IsNullOrEmpty(result.ResultObj))
                {
                    return BadRequest();
                }                    
            }

            return Ok(result);
        }        

        [HttpGet("getimagebyid")]
        public async Task<IActionResult> GetImageById(int id)
        {
            var result = await _postService.GetImageById(id);
            if (result.IsSuccessed)
            {
                if (result.ResultObj == null)
                    return BadRequest("Cannot find post");
            }
         
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task AddViewcount(int id)
        {
            await _postService.AddViewcount(id);
        }
        [HttpPost("ckeditoruploadfile")]
        public async Task<IActionResult> CKEditorUploadFile([FromForm] IFormFile uploadFile)
        {
            var result = await _postService.CKEditorUploadFile(uploadFile);

            return Ok(result);
        }


        [HttpGet("WebsiteGetManageListPaging")]
        [AllowAnonymous]
        public async Task<IActionResult> WebsiteGetManageListPaging([FromQuery] ManagePostPagingRequest request)
        {
            var posts = await _postService.GetManageListPaging(request);
            return Ok(posts);
        }

    }
}
