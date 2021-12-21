using System;
using System.Linq;
using Snail.ViewModels.Catalog.CustomerTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Catalog.CustomerTypes;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerTypesController : ControllerBase
    {
        private readonly ICustomerTypeService _customerTypeService;

        public CustomerTypesController(ICustomerTypeService customerTypeService)
        {
            _customerTypeService = customerTypeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageCustomerTypePagingRequest request)
        {
            var customerTypes = await _customerTypeService.GetManageListPaging(request);
            return Ok(customerTypes);
        }

        [HttpGet("{customerTypeId}")]
        public async Task<IActionResult> GetById(int customerTypeId, int languageId)
        {
            var customerType = await _customerTypeService.GetById(customerTypeId, languageId);
            if (customerType.IsSuccessed)
                if (customerType.ResultObj == null)
                    return BadRequest("Cannot find customerType");
            return Ok(customerType);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] CustomerTypeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _customerTypeService.UpdateAsync(request);
            }
            else
            {
                res = await _customerTypeService.CreateAsync(request);
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
            var result = await _customerTypeService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
