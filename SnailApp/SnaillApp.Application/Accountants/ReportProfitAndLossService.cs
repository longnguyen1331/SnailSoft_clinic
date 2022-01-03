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
    public interface IReportProfitAndLossService
    {
        Task<PagedResult<ReportProfitAndLossDto>> GetReport(ManageReportProfitAndLossPagingRequest request);

    }
    public class ReportProfitAndLossService : IReportProfitAndLossService
    {
        private readonly ClinicDbContext _context;

        public ReportProfitAndLossService(ClinicDbContext context)
        {
            _context = context;
        }

     
        public async Task<PagedResult<ReportProfitAndLossDto>> GetReport(ManageReportProfitAndLossPagingRequest request)
        {
            var pagedResult = new PagedResult<ReportProfitAndLossDto>()
            {
                PageSize = request.PageSize,
                PageIndex = request.PageIndex
            };

            try
            {
                List<ReportProfitAndLossDto> data = new List<ReportProfitAndLossDto>();
                #region FromSqlStoredProcedureSqlParameter
                string sqlCommand = "exec usp_ProfitAndLossReport @storeId,@fDate,@tDate,@fDatePast,@tDatePast";

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
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.FromDate
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
                         ParameterName = "fDatePast",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.FromDatePast
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                         ParameterName = "tDatePast",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = request.ToDatePast + " 23:59:59"
                    }
                };
                data = await SQLHelper.ExecuteScalarAsync<ReportProfitAndLossDto>(_context, sqlCommand,
                    x => new ReportProfitAndLossDto
                    {
                        DoanhSoKyTruoc = (double)x[0],
                        DoanhSoKyNay = (double)x[1],
                        TienVonKyTruoc = (double)x[2],
                        TienVonKyNay = (double)x[3],
                        LaiGopKyTruoc = (double)x[4],
                        LaiGopKyNay = (double)x[5]
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