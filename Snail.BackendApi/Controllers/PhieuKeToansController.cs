using System;
using System.Linq;
using Snail.ViewModels.Accountants.PhieuKeToans;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Snail.Application.Accountants;
using Snail.ViewModels.Common;

namespace Snail.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class PhieuKeToansController : ControllerBase
    {
        private readonly IPhieuKeToanService _phieuKeToanService;

        public PhieuKeToansController(IPhieuKeToanService phieuKeToanService)
        {
            _phieuKeToanService = phieuKeToanService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManagePhieuKeToanPagingRequest request)
        {
            var phieuKeToans = await _phieuKeToanService.GetManageListPaging(request);
            return Ok(phieuKeToans);
        }

        [HttpGet("GetManageListCashBookPaging")]
        public async Task<IActionResult> GetManageListCashBookPaging([FromQuery] ManagePhieuKeToanPagingRequest request)
        {
            var phieuKeToans = await _phieuKeToanService.GetManageListCashBookPaging(request);
            return Ok(phieuKeToans);
        }

        

        [HttpGet("GetManageListDetailPaging")]
        public async Task<IActionResult> GetManageListDetailPaging([FromQuery] ManagePhieuKeToanPagingRequest request)
        {
            var phieuKeToanChiTiets = await _phieuKeToanService.GetManageListDetailPaging(request);
            return Ok(phieuKeToanChiTiets);
        }

        [HttpGet("{phieuKeToanId}")]
        public async Task<IActionResult> GetById(int phieuKeToanId)
        {
            var phieuKeToan = await _phieuKeToanService.GetById(phieuKeToanId);
            if (phieuKeToan.IsSuccessed)
                if (phieuKeToan.ResultObj == null)
                    return BadRequest("Cannot find phieuKeToan");
            return Ok(phieuKeToan);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] PhieuKeToanRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _phieuKeToanService.UpdateAsync(request);
            }
            else
            {
                res = await _phieuKeToanService.CreateAsync(request);
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
            var result = await _phieuKeToanService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }


        [HttpPost("updateDescriptionById")]
        public async Task<IActionResult> UpdateDescriptionById([FromBody] PhieuKeToanRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _phieuKeToanService.UpdateDesByIdAsync(request);
            }

            if (res.IsSuccessed)
            {
                if (res.ResultObj == 0)
                    return BadRequest();
            }

            return Ok(res);
        }
    }
}
