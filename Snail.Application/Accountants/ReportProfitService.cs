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
    public interface IReportProfitService
    {
        Task<PagedResult<ReportProfitDto>> GetReport(ManageReportProfitPagingRequest request);

    }
    public class ReportProfitService : IReportProfitService
    {
        private readonly EShopDbContext _context;

        public ReportProfitService(EShopDbContext context)
        {
            _context = context;
        }

     
        public async Task<PagedResult<ReportProfitDto>> GetReport(ManageReportProfitPagingRequest request)
        {
            var pagedResult = new PagedResult<ReportProfitDto>()
            {
                PageSize = request.PageSize,
                PageIndex = request.PageIndex
            };

            try
            {
                List<ReportProfitDto> data = new List<ReportProfitDto>();
                #region FromSqlStoredProcedureSqlParameter
                string sqlCommand = "exec usp_ProfitReport @storeId,@fDate,@tDate,@pageSize,@pageNumber, @totalRows OUTPUT";

                SqlParameter[] param = new SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "storeId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.StoreId
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "fDate",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.FromDate
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "tDate",
                        SqlDbType = SqlDbType.VarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.ToDate + " 23:59:59"
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "pageSize",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.PageSize
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "pageNumber",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.PageIndex.Value - 1
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "totalRows",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output,
                        Value = 0
                    }
                };
                data = await SQLHelper.ExecuteScalarAsync<ReportProfitDto>(_context, sqlCommand,
                    x => new ReportProfitDto
                    {
                        Date = (string)x[0],
                        QtyInStock = (int)x[1],
                        Price = (double)x[2],
                        BuyingPrice = (double)x[3],
                        Revenue = (double)x[4]
                    }, param);

                int totalRecord = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, param);
                totalRecord = Int32.Parse(param[5].Value.ToString());
                #endregion


                //4. Select and projection
                pagedResult.TotalRecords = totalRecord;
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