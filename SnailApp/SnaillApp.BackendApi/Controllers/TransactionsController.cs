using System;
using System.Linq;
using SnailApp.ViewModels.Sales.Transactions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SnailApp.Application.Sales.Transactions;
using SnailApp.ViewModels.Common;

namespace SnailApp.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionsController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet("GetManageListPaging")]
        public async Task<IActionResult> GetManageListPaging([FromQuery] ManageTransactionPagingRequest request)
        {
            var transactions = await _transactionService.GetManageListPaging(request);
            return Ok(transactions);
        }

        [HttpGet("{transactionId}")]
        public async Task<IActionResult> GetById(int transactionId)
        {
            var transaction = await _transactionService.GetById(transactionId);
            if (transaction.IsSuccessed)
                if (transaction.ResultObj == null)
                    return BadRequest("Cannot find transaction");
            return Ok(transaction);
        }

        [HttpPost("addorupdate")]
        public async Task<IActionResult> AddOrUpdate([FromBody] TransactionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApiResult<int> res = null;
            if (request.Id != null)
            {
                res = await _transactionService.UpdateAsync(request);
            }
            else
            {
                res = await _transactionService.CreateAsync(request);
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
            var result = await _transactionService.DeleteByIds(new DeleteRequest()
            {
                Ids = ids.Split("|").Select(x => Convert.ToInt32(x)).ToList()
            });

            return Ok(result);
        }
    }
}
