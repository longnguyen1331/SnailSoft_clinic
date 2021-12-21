using System;
using System.Linq;
using Snail.ViewModels.Sales.Promotions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Sales.Promotions;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PromotionsController : ControllerBase
    {
        private readonly IPromotionService _promotionService;

        public PromotionsController(IPromotionService promotionService)
        {
            _promotionService = promotionService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePromotionPagingRequest request)
        {
            var promotions = await _promotionService.GetManageListPaging(request);
            return Ok(promotions);
        }

        [HttpGet("getbasicinfoasyncbyid")]
        public async Task<IActionResult> GetBasicInfoAsyncById([FromQuery]PromotionRequest request)
        {
            var promotion = await _promotionService.GetBasicInfoAsyncById(request);
            if (promotion.IsSuccessed)
            {
                if (promotion.ResultObj == null)
                {
                    return BadRequest("Cannot find promotion");
                }
            }
                
            return Ok(promotion);
        }

        [HttpPost("addOrupdatebasicinfo")]
        public async Task<IActionResult> AddOrUpdateBasicInfo([FromBody] PromotionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = await _promotionService.AddOrUpdateBasicInfoAsync(request);
            
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
            var result = await _promotionService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
