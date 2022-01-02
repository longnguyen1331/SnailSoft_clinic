using SnailApp.Data.EF;
using System;
using System.Threading.Tasks;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using System.Data;
using SnailApp.Data.SqlHelper;
using SnailApp.Utilities.Constants;
using System.Globalization;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SnailApp.Application.Accountants
{
    public interface IReportCashBookService
    {
        Task<ReportCashBookDto> GetReport(ManageReportCashBookPagingRequest request);

    }
    public class ReportCashBookService : IReportCashBookService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public ReportCashBookService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

     
        public async Task<ReportCashBookDto> GetReport(ManageReportCashBookPagingRequest request)
        {
            try
            {
                ReportCashBookDto data = new ReportCashBookDto();

                DateTime fDateValue, tDateValue;
                if (string.IsNullOrEmpty(request.FromDate) ||
                    !DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null, 
                    DateTimeStyles.None, out fDateValue))
                {
                    fDateValue = DateTime.Now;
                }
                else
                {
                    DateTime.TryParseExact(request.FromDate, _configuration[SystemConstants.AppConstants.DateFormat], null,
                   DateTimeStyles.None, out fDateValue);
                }

                if (string.IsNullOrEmpty(request.ToDate) ||
                    !DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null,
                    DateTimeStyles.None, out tDateValue))
                {
                    tDateValue = new DateTime(DateTime.Now.Year,
                         DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                }
                else
                {
                    DateTime.TryParseExact(request.ToDate, _configuration[SystemConstants.AppConstants.DateFormat], null,
                    DateTimeStyles.None, out tDateValue);
                }

                string sqlCommand = "exec usp_GetReportCashBook @storeId, @fDate, @tDate";

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
                        Value = fDateValue.ToString("dd/MM/yyyy")
                    },
                    new Microsoft.Data.SqlClient.SqlParameter
                    {
                        ParameterName = "tDate",
                        SqlDbType = SqlDbType.NVarChar,
                        Direction = ParameterDirection.Input,
                        Value = tDateValue.ToString("dd/MM/yyyy")
                    }
                };

                var res  = await SQLHelper.ExecuteScalarAsync<ReportCashBookDto>(_context, sqlCommand,
                    x => new ReportCashBookDto
                    {
                        OpeningBalance = (double)x[0],
                        TotalPaymentMoney = (double)x[1],
                        TotalCollectMoney = (double)x[2]
                    }, param);

                if(res != null)
                {
                    data = res[0];
                }
                return data;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}