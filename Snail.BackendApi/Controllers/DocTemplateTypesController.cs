using System;
using System.Linq;
using Snail.ViewModels.Catalog.DocTemplateTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Catalog.DocTemplateTypes;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DocTemplateTypesController : ControllerBase
    {
        private readonly IDocTemplateTypeService _docTemplateTypeService;

        public DocTemplateTypesController(IDocTemplateTypeService docTemplateTypeService)
        {
            _docTemplateTypeService = docTemplateTypeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageDocTemplateTypePagingRequest request)
        {
            var docTemplateTypes = await _docTemplateTypeService.GetManageListPaging(request);
            return Ok(docTemplateTypes);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageDocTemplateTypePagingRequest request)
        {
            var docTemplateTypes = await _docTemplateTypeService.GetManageListPaging(request);
            return Ok(docTemplateTypes);
        }

        [HttpGet("{docTemplateTypeId}")]
        public async Task<IActionResult> GetById(int docTemplateTypeId, int languageId)
        {
            var docTemplateType = await _docTemplateTypeService.GetById(docTemplateTypeId, languageId);
            if (docTemplateType.IsSuccessed)
            {
                if (docTemplateType.ResultObj == null)
                {
                    return BadRequest("Cannot find docTemplateType");
                }
            }

            return Ok(docTemplateType);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] DocTemplateTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _docTemplateTypeService.UpdateAsync(request);
            }
            else
            {
                res = await _docTemplateTypeService.CreateAsync(request);
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
            var result = await _docTemplateTypeService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
