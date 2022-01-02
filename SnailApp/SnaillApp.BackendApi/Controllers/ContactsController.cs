using System;
using System.Linq;
using SnailApp.ViewModels.Sales.Contacts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Sales.Contacts;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageContactPagingRequest request)
        {
            var contacts = await _contactService.GetManageListPaging(request);
            return Ok(contacts);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery]ContactRequest request)
        {
            var contact = await _contactService.GetById(request);
            if (contact.IsSuccessed)
                if (contact.ResultObj == null)
                    return BadRequest("Cannot find contact");
            return Ok(contact);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] ContactRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _contactService.UpdateAsync(request);
            }
            else
            {
                res = await _contactService.CreateAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(res);
        }
        [HttpPost("publicaddorupdate")]
        [AllowAnonymous]
        public async Task<IActionResult> PublicAddOrUpdate([FromBody] ContactRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _contactService.UpdateAsync(request);
            }
            else
            {
                res = await _contactService.CreateAsync(request);
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
            var result = await _contactService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
