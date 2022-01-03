using SnailApp.Data.EF;
using System;
using System.Threading.Tasks;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using System.Data;
using SnailApp.Data.SqlHelper;
using SnailApp.Utilities.Constants;
using System.Globalization;
using Microsoft.Data.SqlClient;
using SnailApp.ViewModels.Common;
using System.Collections.Generic;

namespace SnailApp.Application.Accountants
{
    public interface IReportWarehouseService
    {
        Task<PagedResult<ReportWarehouseDto>> GetReport(ManageReportWarehousePagingRequest request);

    }
    public class ReportWarehouseService : IReportWarehouseService
    {
        private readonly ClinicDbContext _context;

        public ReportWarehouseService(ClinicDbContext context)
        {
            _context = context;
        }

     
        public async Task<PagedResult<ReportWarehouseDto>> GetReport(ManageReportWarehousePagingRequest request)
        {
            var pagedResult = new PagedResult<ReportWarehouseDto>()
            {
                PageSize = request.PageSize,
                PageIndex = request.PageIndex
            };

            try
            {
                List<ReportWarehouseDto> data = new List<ReportWarehouseDto>();
                int totalRecord = 0;
                #region FromSqlStoredProcedureSqlParameter
                string sqlCommand = "exec usp_GetReportInventory @storeId ,@tDate,  @pageSize, @pageNumber, @totalRows OUTPUT";

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
                         ParameterName = "tDate",
                        SqlDbType = SqlDbType.NVarChar,
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
                        Value = request.PageSize > 0 ? (request.PageIndex.Value -1 ) * request.PageSize : 0
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "totalRows",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Output,
                        Value = 0
                    }
                };
                data = await SQLHelper.ExecuteScalarAsync<ReportWarehouseDto>(_context, sqlCommand,
                    x => new ReportWarehouseDto
                    {
                        Id = (int)x[0],
                        Code = (string)x[1],
                        Name = (string)x[2],
                        QtyInStock = (int)x[3],
                        Price = (double)x[4],
                        BuyingPrice = (double)x[5]
                    }, param);

                totalRecord = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, param);
                totalRecord = Int32.Parse(param[4].Value.ToString());
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