using System;
using System.Linq;
using Snail.ViewModels.Catalog.Attributes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Catalog.Attributes;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AttributesController : ControllerBase
    {
        private readonly IAttributeService _attributeService;

        public AttributesController(IAttributeService attributeService)
        {
            _attributeService = attributeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAttributePagingRequest request)
        {
            var attributes = await _attributeService.GetManageListPaging(request);
            return Ok(attributes);
        }

        [HttpGet("{attributeId}")]
        public async Task<IActionResult> GetById(int attributeId, int languageId)
        {
            var attribute = await _attributeService.GetById(attributeId, languageId);
            if (attribute.IsSuccessed)
                if (attribute.ResultObj == null)
                    return BadRequest("Cannot find attribute");
            return Ok(attribute);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AttributeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _attributeService.UpdateAsync(request);
            }
            else
            {
                res = await _attributeService.CreateAsync(request);
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
            var result = await _attributeService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
