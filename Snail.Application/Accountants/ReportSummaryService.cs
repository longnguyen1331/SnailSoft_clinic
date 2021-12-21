using Snail.Data.EF;
using System;
using System.Threading.Tasks;
using Snail.ViewModels.Accountants.PhieuKeToans;
using System.Data;
using Snail.Data.SqlHelper;
using Snail.Utilities.Constants;
using System.Globalization;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Snail.Application.Accountants
{
    public interface IReportSummaryService
    {
        Task<ReportSummaryDto> GetReport(ManageReportSummaryPagingRequest request);

    }
    public class ReportSummaryService : IReportSummaryService
    {
        private readonly EShopDbContext _context;
        private readonly IConfiguration _configuration;

        public ReportSummaryService(EShopDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

     
        public async Task<ReportSummaryDto> GetReport(ManageReportSummaryPagingRequest request)
        {
            try
            {
                ReportSummaryDto data = new ReportSummaryDto();

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

                string sqlCommand = "exec usp_GetReportSummary @storeId, @fDate, @tDate";

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

                var res  = await SQLHelper.ExecuteScalarAsync<ReportSummaryDto>(_context, sqlCommand,
                    x => new ReportSummaryDto
                    {
                        TotalOrders = (int)x[0],
                        OrdeRaverageValue = (double)x[1],
                        Revenue = (double)x[2],
                        GrossProfit = (double)x[3],
                        TotalPayment = (double)x[4],
                        TotalCollectMoney = (double)x[5],
                        TotalProductInStock = (int)x[6],
                        TotalProductOutStock = (int)x[7]
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