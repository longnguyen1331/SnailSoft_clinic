using System;
using System.Linq;
using Snail.ViewModels.System.Languages;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.SystemApplication.Languages;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LanguagesController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguagesController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageLanguagePagingRequest request)
        {
            var languages = await _languageService.GetManageListPaging(request);
            return Ok(languages);
        }

        [HttpGet("{languageId}")]
        public async Task<IActionResult> GetById(int languageId)
        {
            var language = await _languageService.GetById(languageId);
            if (language.IsSuccessed)
                if (language.ResultObj == null)
                    return BadRequest("Cannot find language");
            return Ok(language);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] LanguageRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _languageService.UpdateAsync(request);
            }
            else
            {
                res = await _languageService.CreateAsync(request);
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
            var result = await _languageService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}