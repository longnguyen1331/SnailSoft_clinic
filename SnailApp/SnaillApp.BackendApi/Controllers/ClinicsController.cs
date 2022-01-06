using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.Clinics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.Clinics;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ClinicsController : ControllerBase
    {
        private readonly IClinicService _clinicService;

        public ClinicsController(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageClinicPagingRequest request)
        {
            var clinics = await _clinicService.GetManageListPaging(request);
            return Ok(clinics);
        }

        [HttpGet("clinicId")]
        public async Task<IActionResult> GetById(ClinicRequest request)
        {
            var clinic = await _clinicService.GetById(request);
            if (clinic.IsSuccessed)
            {
                if (clinic.ResultObj == null)
                {
                    return BadRequest("Cannot find clinic");
                }
            }
            
            return Ok(clinic);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ClinicRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _clinicService.UpdateAsync(request);
            }
            else
            {
                res = await _clinicService.CreateAsync(request);
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
            var result = await _clinicService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
