using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.PaperSizes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.PaperSizes;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PaperSizesController : ControllerBase
    {
        private readonly IPaperSizeService _paperSizeService;

        public PaperSizesController(IPaperSizeService paperSizeService)
        {
            _paperSizeService = paperSizeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePaperSizePagingRequest request)
        {
            var paperSizes = await _paperSizeService.GetManageListPaging(request);
            return Ok(paperSizes);
        }

        [HttpGet("{paperSizeId}")]
        public async Task<IActionResult> GetById(int paperSizeId)
        {
            var paperSize = await _paperSizeService.GetById(paperSizeId);
            if (paperSize.IsSuccessed)
                if (paperSize.ResultObj == null)
                    return BadRequest("Cannot find paperSize");
            return Ok(paperSize);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PaperSizeRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _paperSizeService.UpdateAsync(request);
            }
            else
            {
                res = await _paperSizeService.CreateAsync(request);
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
            var result = await _paperSizeService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
