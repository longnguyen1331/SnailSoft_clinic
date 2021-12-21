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
    public interface IReportProductService
    {
        Task<PagedResult<ReportWarehouseDto>> GetReport(ManageReportWarehousePagingRequest request);
        Task<PagedResult<ReportWarehouseDto>> GetTotalReport(ManageReportWarehousePagingRequest request);

    }
    public class ReportProductService : IReportProductService
    {
        private readonly EShopDbContext _context;

        public ReportProductService(EShopDbContext context)
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
                string sqlCommand = "exec usp_GetReportProduct @languageId, @storeId ,@fDate, @tDate,   @pageSize, @pageNumber, @totalRows OUTPUT";

                SqlParameter[] param = new SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "languageId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.LanguageId
                    },
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
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.FromDate + " 00:00:01"
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
                        Value = request.PageIndex.Value -1
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
                        Code = (string)x[0],
                        Name = (string)x[1],
                        ProductTypeName = (string)x[2],
                        ProductTypeId = (string)x[3],
                        QtyInStock = (int)x[4],
                        Price = (double)x[5],
                        BuyingPrice = (double)x[6]
                    }, param);

                totalRecord = await SQLHelper.ExecuteNonQueryAsync(_context, sqlCommand, param);
                totalRecord = Int32.Parse(param[6].Value.ToString());
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


        public async Task<PagedResult<ReportWarehouseDto>> GetTotalReport(ManageReportWarehousePagingRequest request)
        {
            var pagedResult = new PagedResult<ReportWarehouseDto>()
            {
                PageSize = request.PageSize,
                PageIndex = request.PageIndex
            };

            try
            {
                List<ReportWarehouseDto> data = new List<ReportWarehouseDto>();
                #region FromSqlStoredProcedureSqlParameter
                string sqlCommand = "exec usp_GetTotalReportProduct @languageId, @storeId ,@fDate, @tDate";

                SqlParameter[] param = new SqlParameter[] {
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "languageId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = request.LanguageId
                    },
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
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.FromDate + " 00:00:01"
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "tDate",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.ToDate + " 23:59:59"
                    }
                };
                data = await SQLHelper.ExecuteScalarAsync<ReportWarehouseDto>(_context, sqlCommand,
                    x => new ReportWarehouseDto
                    {
                        ProductTypeName = (string)x[0],
                        ProductTypeId = (string)x[1],
                        QtyInStock = (int)x[2],
                        BuyingPrice = (double)x[3]
                    }, param);
                #endregion


                //4. Select and projection
                pagedResult.TotalRecords = 0;
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