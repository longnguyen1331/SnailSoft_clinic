using System;
using System.Linq;
using Snail.ViewModels.System.DocTemplates;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Snail.Application.SystemApplication.DocTemplates;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocTemplatesController : ControllerBase
    {
        private readonly IDocTemplateService _docTemplateService;

        public DocTemplatesController(IDocTemplateService docTemplateService)
        {
            _docTemplateService = docTemplateService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageDocTemplatePagingRequest request)
        {
            var docTemplates = await _docTemplateService.GetManageListPaging(request);
            return Ok(docTemplates);
        }

        [HttpGet("GetContentByDocTemplateTypeCode")]
        public async Task<IActionResult> GetContentByDocTemplateTypeCode([FromQuery] DocTemplateRequest request)
        {
            var docTemplates = await _docTemplateService.GetContentByDocTemplateTypeCode(request);
            return Ok(docTemplates);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] DocTemplateRequest request)
        {
            var docTemplate = await _docTemplateService.GetById(request);
            if (docTemplate.IsSuccessed)
                if (docTemplate.ResultObj == null)
                    return BadRequest("Cannot find DocTemplate");
            return Ok(docTemplate);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] DocTemplateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _docTemplateService.UpdateAsync(request);
            }
            else
            {
                res = await _docTemplateService.CreateAsync(request);
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
            var result = await _docTemplateService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
        [HttpPost("ckeditoruploadfile")]
        public async Task<IActionResult> CKEditorUploadFile([FromForm] IFormFile uploadFile)
        {
            var result = await _docTemplateService.CKEditorUploadFile(uploadFile);

            return Ok(result);
        }
    }
}
