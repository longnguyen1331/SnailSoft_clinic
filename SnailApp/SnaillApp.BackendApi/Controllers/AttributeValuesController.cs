using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.AttributeValues;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.Attributes;
using SnailApp.ViewModels.Catalog.AttributeValues;
using SnailApp.Application.Catalog.Attributes;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AttributeValuesController : ControllerBase
    {
        private readonly IAttributeValueService _attributeValueService;

        public AttributeValuesController(IAttributeValueService attributeValueService)
        {
            _attributeValueService = attributeValueService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageAttributeValuePagingRequest request)
        {
            var attributes = await _attributeValueService.GetManageListPaging(request);
            return Ok(attributes);
        }

        [HttpGet("{attributeId}")]
        public async Task<IActionResult> GetById(int attributeId, int languageId)
        {
            var attribute = await _attributeValueService.GetById(attributeId, languageId);
            if (attribute.IsSuccessed)
                if (attribute.ResultObj == null)
                    return BadRequest("Cannot find attribute");
            return Ok(attribute);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] AttributeValueRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _attributeValueService.UpdateAsync(request);
            }
            else
            {
                res = await _attributeValueService.CreateAsync(request);
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
            var result = await _attributeValueService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
