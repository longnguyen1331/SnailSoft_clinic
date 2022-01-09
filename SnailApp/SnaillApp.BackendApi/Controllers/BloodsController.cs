using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.Clinics;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BloodsController : ControllerBase
    {
        private readonly IBloodService _bloodService;

        public BloodsController(IBloodService bloodService
            )
        {
            _bloodService = bloodService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] PagingRequestBase request)
        {
            var bloods = await _bloodService.GetManageListPaging(request);
            return Ok(bloods);
        }

        [HttpGet("bloodId")]
        public async Task<IActionResult> GetById(BaseRequest request)
        {
            var blood = await _bloodService.GetById(request);
            if (blood.IsSuccessed)
            {
                if (blood.ResultObj == null)
                {
                    return BadRequest("Cannot find blood");
                }
            }
            
            return Ok(blood);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] BaseRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _bloodService.UpdateAsync(request);
            }
            else
            {
                res = await _bloodService.CreateAsync(request);
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
            var result = await _bloodService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
