using SnailApp.Application.Common;
using SnailApp.Data.EF;
using SnailApp.Data.Entities;
using SnailApp.Utilities.Constants;
using SnailApp.Utilities.Exceptions;
using SnailApp.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SnailApp.ViewModels.Sales.Transactions;

namespace SnailApp.Application.Sales.Transactions
{
    public interface ITransactionService
    {
        Task<ApiResult<int>> CreateAsync(TransactionRequest request);

        Task<ApiResult<int>> UpdateAsync(TransactionRequest request);

        Task<ApiResult<int>> DeleteByIds(DeleteRequest request);

        Task<ApiResult<TransactionDto>> GetById(int id);

        Task<PagedResult<TransactionDto>> GetManageListPaging(ManageTransactionPagingRequest request);
    }
    public class TransactionService : ITransactionService
    {
        private readonly ClinicDbContext _context;
        private readonly IConfiguration _configuration;

        public TransactionService(ClinicDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ApiResult<int>> CreateAsync(TransactionRequest request)
        {
            var transaction = new Transaction()
            {
                Code = request.Code,
                Name = request.Name,
                CreatedDate = DateTime.Now
            };

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(transaction.Id);
        }

        public async Task<ApiResult<int>> UpdateAsync(TransactionRequest request)
        {
            try
            {
                var transaction = await _context.Transactions.FindAsync(request.Id);

                if (transaction == null) throw new EShopException($"Cannot find a transaction with id: {request.Id}");

                transaction.Code = request.Code;
                transaction.Name = request.Name;
                transaction.ModifiedDate = DateTime.Now;
                await _context.SaveChangesAsync();
                return new ApiSuccessResult<int>(transaction.Id);

            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<ApiResult<int>> DeleteByIds(DeleteRequest request)
        {
            try
            {
                var transactions = await _context.Transactions.Where(m => request.Ids.Contains(m.Id)).ToListAsync();
                if (transactions == null) throw new EShopException($"Cannot find Id: {string.Join(";", request.Ids)}");

                _context.Transactions.RemoveRange(transactions);

                return new ApiSuccessResult<int>(await _context.SaveChangesAsync());

            }
            catch (Exception ex)
            {
                return new ApiResult<int>()
                {
                    IsSuccessed = false,
                    Message = ex.Message
                };
            }
        }

        public async Task<PagedResult<TransactionDto>> GetManageListPaging(ManageTransactionPagingRequest request)
        {
            //1. Select join
            var query = from t in _context.Transactions
                        select new { t };

            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => x.t.Name.Contains(request.TextSearch)
                || x.t.Code.Contains(request.TextSearch));

            //3.Sort

            if (!string.IsNullOrEmpty(request.OrderCol))
            {
                switch (request.OrderCol)
                {
                    case "id":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.t.Id) :
                            query.OrderByDescending(x => x.t.Id);

                        break;

                    case "code":
                        query = (request.OrderDir == "asc") ?
                            query.OrderBy(x => x.t.Code) :
                            query.OrderByDescending(x => x.t.Code);

                        break;

                    case "name":
                        query = (request.OrderDir == "asc") ? query.OrderBy(x => x.t.Name) :
                            query.OrderByDescending(x => x.t.Name);

                        break;

                    default: break;
                }
            }

            //4. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null && request.PageIndex.Value != 0 && request.PageSize != 0)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                                .Take(request.PageSize);
            }


            var data = await query.Select(x => new TransactionDto()
            {
                Id = x.t.Id,
                Code = x.t.Code,
                Name = x.t.Name
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<TransactionDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }

        public async Task<ApiResult<TransactionDto>> GetById(int id)
        {
            var transaction = await _context.Transactions.FindAsync(id);

            var transactionDto = new TransactionDto()
            {
                Id = transaction.Id,
                Code = transaction.Code,
                Name = transaction.Name
            };
            return new ApiSuccessResult<TransactionDto>(transactionDto);
        }
    }
}
