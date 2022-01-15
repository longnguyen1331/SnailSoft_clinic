using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.Application.Catalog.Clinics;
using SnailApp.Application.Catalog.ExaminationsResults;
using SnailApp.ViewModels.Catalog.ExaminationsResults;
using Microsoft.AspNetCore.Http;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ExaminationsResultsController : ControllerBase
    {
        private readonly IExaminationsResultService _examinationsResultService;

        public ExaminationsResultsController(IExaminationsResultService examinationsResultService
            )
        {
            _examinationsResultService = examinationsResultService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageExaminationsResulttPagingRequest request)
        {
            var examinationsResults = await _examinationsResultService.GetManageListPaging(request);
            return Ok(examinationsResults);
        }
        
        [HttpGet("AppointmentId")]
        public async Task<IActionResult> GetByAppointmentId([FromQuery] ExaminationsResultRequest request)
        {
            var examinationsResult = await _examinationsResultService.GetByAppointmentId(request);
            if (examinationsResult.IsSuccessed)
            {
                if (examinationsResult.ResultObj == null)
                {
                    return BadRequest("Cannot find examinationsResult");
                }
            }

            return Ok(examinationsResult);
        }

        [HttpGet("examinationsResultId")]
        public async Task<IActionResult> GetById([FromQuery] ExaminationsResultRequest request)
        {
            var examinationsResult = await _examinationsResultService.GetById(request);
            if (examinationsResult.IsSuccessed)
            {
                if (examinationsResult.ResultObj == null)
                {
                    return BadRequest("Cannot find examinationsResult");
                }
            }
            
            return Ok(examinationsResult);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ExaminationsResultRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id > 0)
            {
                res = await _examinationsResultService.UpdateAsync(request);
            }
            else
            {
                res = await _examinationsResultService.CreateAsync(request);
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
            var result = await _examinationsResultService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }

        [HttpPost("ckeditoruploadfile")]
        public async Task<IActionResult> CKEditorUploadFile([FromForm] IFormFile uploadFile)
        {
            var result = await _examinationsResultService.CKEditorUploadFile(uploadFile);

            return Ok(result);
        }

    }
}
