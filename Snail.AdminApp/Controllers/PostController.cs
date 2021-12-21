using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Snail.ApiIntegration;
using Snail.Utilities.Constants;
using Snail.Utilities.Session;
using Snail.ViewModels.News.Posts;
using Snail.ViewModels.Catalog.PostTypes;
using Snail.ViewModels.System.Users;
using Snail.AdminApp.Models;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Snail.AdminApp.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostApiClient _postApiClient;
        private readonly IConfiguration _configuration;
        private readonly IPostTypeApiClient _postTypeApiClient;

        public PostController(IPostApiClient postApiClient, IConfiguration configuration,
                                IPostTypeApiClient postTypeApiClient)
        {
            _configuration = configuration;
            _postApiClient = postApiClient;
            _postTypeApiClient = postTypeApiClient;
        }

        public async Task<IActionResult> Index()
        {
            var model = new PostViewModel();
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Bài viết";
            model.Breadcrumbs = new List<string>() { "Quản trị Website", "Bài viết" };

            var postTypeApiClient = await _postTypeApiClient.GetAll(new ManagePostTypePagingRequest() { LanguageId = languageId });
            if (postTypeApiClient.IsSuccessed)
            {
                model.PostTypes = postTypeApiClient.ResultObj;
            }
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> DataTableGetList(int? draw, int? start, int? length, string textSearch, int? postTypeId)
        {
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            var sortColumnDir = Request.Form["order[0][dir]"].FirstOrDefault();
            int skip = start != null ? Convert.ToInt32((start / length) + 1) : 1;
            int pageSize = length != null ? Convert.ToInt32(length) : 10;
            int languageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));

            var request = new ManagePostPagingRequest()
            {
                TextSearch = textSearch,
                PageIndex = skip,
                PageSize = pageSize,
                PostTypeId = postTypeId,
                LanguageId = languageId,
                OrderCol = !string.IsNullOrEmpty(sortColumn) ? sortColumn : "Id",
                OrderDir = !string.IsNullOrEmpty(sortColumnDir) ? sortColumnDir : "desc"
            };

            var postApiClient = await _postApiClient.GetManageListPaging(request);

            return Json(new
            {
                draw = draw,
                recordsFiltered = postApiClient.TotalRecords,
                recordsTotal = postApiClient.TotalRecords,
                data = postApiClient.Items
            });
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteByIds([FromBody] DeleteRequest request)
        {
            string resultMessage = string.Empty;
            var result = await _postApiClient.DeleteByIds(request);

            if (!result.IsSuccessed)
            {
                resultMessage = "Lỗi";
            }

            return Json(new
            {
                isSuccessed = result.IsSuccessed,
                message = resultMessage
            });
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromForm] PostRequest rq)
        {
            ApiResult<int> result = null;

            string userGuid = HttpContext.Session.GetString(SystemConstants.AppConstants.UserId);

            if (rq != null)
            {
                rq.LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
                if (rq.Id == null)
                {
                    rq.CreatedUserId = userGuid;
                    rq.ModifiedUserId = userGuid;
                }
                else
                {
                    rq.ModifiedUserId = userGuid;
                    rq.Id = rq.Id.Value;
                }
                result = await _postApiClient.AddOrUpdateAsync(rq);
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

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var model = new PostViewModel();
            var languageId = Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId));
            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(SystemConstants.AppConstants.CurrentUserRoleSession),
                                                                                                            (ControllerContext.ActionDescriptor).ControllerName,
                                                                                                            (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Bài viết";
            model.Breadcrumbs = new List<string>() { "Website", "Bài viết" };

            if (id != null)
            {
                var postApiClient = await _postApiClient.GetById(new PostRequest
                {
                    LanguageId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultLanguageId)),
                    Id = id
                });

                if (postApiClient.IsSuccessed)
                {
                    model.Post = postApiClient.ResultObj;
                    if (!string.IsNullOrEmpty(model.Post.ThumbnailImage))
                    {
                        model.Post.ThumbnailImage = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + model.Post.ThumbnailImage;
                    }
                }
            }

            return View(model);
        }

        [AcceptVerbs("POST")]
        public async Task<IActionResult> CKEditorUploadImage(IFormFile upload)
        {
            string fileUrl = string.Empty;
            var postApiClient = await _postApiClient.CKEditorUploadFile(upload);

            if (postApiClient.IsSuccessed)
            {
                fileUrl = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + postApiClient.ResultObj;
            }

            return new JsonResult(new
            {
                uploaded = 1,
                fileName = upload.FileName,
                url = fileUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveImages([FromBody] DeleteRequest request)
        {
            string fileUrl = string.Empty;
            var postApiClient = await _postApiClient.RemoveImages(request);

            return Ok(postApiClient);
        }
        [HttpGet]
        public async Task<IActionResult> DeleteThumbnailImageByPostId(int postId)
        {
            var postApiClient = await _postApiClient.DeleteThumbnailImageByPostId(postId);

            if (postApiClient.IsSuccessed)
            {
                postApiClient.ResultObj = _configuration[SystemConstants.AppConstants.BaseAddress] + "/" + postApiClient.ResultObj;
            }

            return Ok(postApiClient);
        }
    }
}
