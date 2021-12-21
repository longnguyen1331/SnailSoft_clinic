using Snail.Application.Common;
using Snail.Data.EF;
using Snail.Data.Entities;
using Snail.Utilities.Constants;
using Snail.Utilities.Exceptions;
using Snail.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Snail.ViewModels.HR.PayrollDetails;

namespace Snail.Application.HR.PayrollDetails
{
    public interface IPayrollDetailService
    {
        Task<PagedResult<PayrollDetailDto>> GetManageListPaging(ManagePayrollDetailPagingRequest request);
    }
    public class PayrollDetailService : IPayrollDetailService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public PayrollDetailService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
      
        public async Task<PagedResult<PayrollDetailDto>> GetManageListPaging(ManagePayrollDetailPagingRequest request)
        {
            //1. Select join
            var query = from pd in _context.PayrollDetails
                        join au in _context.AppUsers on pd.AppUserId equals au.Id into p_au
                        from au in p_au.DefaultIfEmpty()
                        select new { pd, au };
            //2. filter
            if (!string.IsNullOrEmpty(request.TextSearch))
                query = query.Where(x => (x.au.FirstName + " " + x.au.LastName).Contains(request.TextSearch)
                                            || (x.au.LastName + " " + x.au.FirstName).Contains(request.TextSearch));

            if (!string.IsNullOrEmpty(request.AppUserId))
            {
                query = query.Where(x => x.pd.AppUserId == Guid.Parse(request.AppUserId));
            }

            if (request.PayrollId != null)
            {
                query = query.Where(x => x.pd.PayrollId == request.PayrollId.Value);
            }


            //3. Paging
            int totalRow = await query.CountAsync();

            if (request.PageIndex != null)
            {
                query = query.Skip((request.PageIndex.Value - 1) * request.PageSize)
                            .Take(request.PageSize);
            }
            var data = await query.Select(x => new PayrollDetailDto()
            {
                Id = x.pd.Id,
                AppUserFirstName = x.au.FirstName,
                AppUserLastName = x.au.LastName,
                Commission = x.pd.Commission,
                Discount= x.pd.Discount,
                BasicSalary = x.pd.BasicSalary,
                Total = x.pd.Total,
                CreatedDate = x.pd.CreatedDate
            }).AsNoTracking().ToListAsync();

            //4. Select and projection
            var pagedResult = new PagedResult<PayrollDetailDto>()
            {
                TotalRecords = totalRow,
                PageSize = request.PageSize,
                PageIndex = request.PageIndex,
                Items = data
            };
            return pagedResult;
        }
    }
}
