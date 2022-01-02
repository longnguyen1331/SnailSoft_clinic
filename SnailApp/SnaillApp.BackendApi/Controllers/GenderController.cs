using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.Genders;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.Genders;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GendersController : ControllerBase
    {
        private readonly IGenderService _genderService;

        public GendersController(IGenderService genderService)
        {
            _genderService = genderService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageGenderPagingRequest request)
        {
            var genders = await _genderService.GetManageListPaging(request);
            return Ok(genders);
        }

        [HttpGet("{genderId}")]
        public async Task<IActionResult> GetById(int genderId, int languageId)
        {
            var gender = await _genderService.GetById(genderId, languageId);
            if (gender.IsSuccessed)
                if (gender.ResultObj == null)
                    return BadRequest("Cannot find gender");
            return Ok(gender);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] GenderRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _genderService.UpdateAsync(request);
            }
            else
            {
                res = await _genderService.CreateAsync(request);
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
            var result = await _genderService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
