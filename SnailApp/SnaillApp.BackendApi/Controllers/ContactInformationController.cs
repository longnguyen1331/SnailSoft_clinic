using System;
using System.Linq;
using SnailApp.ViewModels.System.ContactInformation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.SystemApplication.ContactInformation;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactInformationController : ControllerBase
    {
        private readonly IContactInformationService _contactInformationService;

        public ContactInformationController(IContactInformationService contactInformationService)
        {
            _contactInformationService = contactInformationService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageContactInformationPagingRequest request)
        {
            var contactInformations = await _contactInformationService.GetManageListPaging(request);
            return Ok(contactInformations);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] ContactInformationRequest request)
        {
            var contactInformation = await _contactInformationService.GetById(request);
            if (contactInformation.IsSuccessed)
                if (contactInformation.ResultObj == null)
                    return BadRequest("Cannot find contactInformation");
            return Ok(contactInformation);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ContactInformationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _contactInformationService.UpdateAsync(request);
            }
            else
            {
                res = await _contactInformationService.CreateAsync(request);
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
            var result = await _contactInformationService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
        [HttpGet("GetDefault")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicDefault()
        {
            var contactInformation = await _contactInformationService.GetPublicDefault();
            if (contactInformation.IsSuccessed)
                if (contactInformation.ResultObj == null)
                {
                    return BadRequest("Cannot find contactInformation");
                }    
                    
            return Ok(contactInformation);
        }
    }
}
