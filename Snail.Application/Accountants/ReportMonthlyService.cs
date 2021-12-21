using Snail.Data.EF;
using System;
using System.Threading.Tasks;
using Snail.ViewModels.Accountants.PhieuKeToans;
using System.Data;
using Snail.Data.SqlHelper;
using Snail.Utilities.Constants;
using System.Globalization;
using Microsoft.Data.SqlClient;
using Snail.ViewModels.Common;
using System.Collections.Generic;

namespace Snail.Application.Accountants
{
    public interface IReportMonthlyService
    {
        Task<PagedResult<ReportMonthlyDto>> GetReport(ManageReportMonthlyPagingRequest request);

    }
    public class ReportMonthlyService : IReportMonthlyService
    {
        private readonly EShopDbContext _context;

        public ReportMonthlyService(EShopDbContext context)
        {
            _context = context;
        }

     
        public async Task<PagedResult<ReportMonthlyDto>> GetReport(ManageReportMonthlyPagingRequest request)
        {
            var pagedResult = new PagedResult<ReportMonthlyDto>()
            {
                PageSize = request.PageSize,
                PageIndex = request.PageIndex
            };

            try
            {
                List<ReportMonthlyDto> data = new List<ReportMonthlyDto>();
                #region FromSqlStoredProcedureSqlParameter
                string sqlCommand = "exec usp_MonthlyReport @year, @storeId";

                SqlParameter[] param = new SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "year",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.Year
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "storeId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.StoreId
                    }
                };
                data = await SQLHelper.ExecuteScalarAsync<ReportMonthlyDto>(_context, sqlCommand,
                    x => new ReportMonthlyDto
                    {
                        MonthInYear = (int)x[0],
                        TotalOrders = (int)x[1],
                        QtyInStock = (int)x[2],
                        Price = (double)x[3],
                        BuyingPrice = (double)x[4]
                    }, param);

                #endregion


                //4. Select and projection
                pagedResult.TotalRecords = 12;
                pagedResult.Items = data;

                return pagedResult;
            }
            catch (Exception ex)
            {
                pagedResult.Message = ex.Message;
                pagedResult.Items = null;

                return pagedResult;
            }
        }
    }
}