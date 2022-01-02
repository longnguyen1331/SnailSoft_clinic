using System;
using System.Linq;
using SnailApp.ViewModels.Catalog.Stores;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Catalog.Stores;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StoresController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoresController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageStorePagingRequest request)
        {
            var stores = await _storeService.GetAll(request);
            return Ok(stores);
        }
        [HttpGet("getall")]
        public async Task<IActionResult> GetAll([FromQuery] ManageStorePagingRequest request)
        {
            var stores = await _storeService.GetManageListPaging(request);
            return Ok(stores);
        }

        [HttpGet("storeId")]
        public async Task<IActionResult> GetById(StoreRequest request)
        {
            var store = await _storeService.GetById(request);
            if (store.IsSuccessed)
            {
                if (store.ResultObj == null)
                {
                    return BadRequest("Cannot find store");
                }
            }
            
            return Ok(store);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] StoreRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _storeService.UpdateAsync(request);
            }
            else
            {
                res = await _storeService.CreateAsync(request);
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
            var result = await _storeService.DeleteByIds(new DeleteRequest() { 
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
