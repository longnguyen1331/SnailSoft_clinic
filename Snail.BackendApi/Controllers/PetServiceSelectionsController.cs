using System;
using System.Linq;
using Snail.ViewModels.Catalog.PetServiceSelections;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Catalog.PetServiceSelections;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PetServiceSelectionsController : ControllerBase
    {
        private readonly IPetServiceSelectionService _petServiceSelectionService;

        public PetServiceSelectionsController(IPetServiceSelectionService petServiceSelectionService)
        {
            _petServiceSelectionService = petServiceSelectionService;
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManagePetServiceSelectionPagingRequest request)
        {
            var menus = await _petServiceSelectionService.GetAll(request);
            return Ok(menus);
        }
        [HttpGet("getpublicall")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicAll([FromQuery] ManagePetServiceSelectionPagingRequest request)
        {
            var menus = await _petServiceSelectionService.GetAll(request);
            return Ok(menus);
        }
        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePetServiceSelectionPagingRequest request)
        {
            var petServiceSelections = await _petServiceSelectionService.GetManageListPaging(request);
            return Ok(petServiceSelections);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] PetServiceSelectionRequest request)
        {
            var petServiceSelection = await _petServiceSelectionService.GetById(request);
            if (petServiceSelection.IsSuccessed)
                if (petServiceSelection.ResultObj == null)
                    return BadRequest("Cannot find petServiceSelection");
            return Ok(petServiceSelection);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PetServiceSelectionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _petServiceSelectionService.UpdateAsync(request);
            }
            else
            {
                res = await _petServiceSelectionService.CreateAsync(request);
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
            var result = await _petServiceSelectionService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
