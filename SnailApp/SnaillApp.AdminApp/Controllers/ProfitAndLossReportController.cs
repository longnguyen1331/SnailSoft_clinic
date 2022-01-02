using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SnailApp.AdminApp.Models;
using Microsoft.AspNetCore.Authorization;
using SnailApp.Utilities.Constants;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Accountants.PhieuKeToans;
using SnailApp.ApiIntegration;
using SnailApp.Utilities.Session;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Common;
using BHSNetCoreLib.ExcelUtil;
using System.Globalization;
using Microsoft.VisualBasic;

namespace SnailApp.AdminApp.Controllers
{
    public class ProfitAndLossReportController : BaseController
    {
        private readonly IReportProfitAndLossApiClient _reportProfitAndLossApiClient;

        public ProfitAndLossReportController(
            IReportProfitAndLossApiClient reportProfitAndLossApiClient
        )
        {
            _reportProfitAndLossApiClient = reportProfitAndLossApiClient;
        }

        public IActionResult Index()
        {
            BaseViewModel model = new BaseViewModel();

            model.CurrentUserRole = InternalService.FixedUserRole(HttpContext.Session.GetObject<UserDto>(
                SystemConstants.AppConstants.CurrentUserRoleSession),
                (ControllerContext.ActionDescriptor).ControllerName,
                (ControllerContext.ActionDescriptor).ActionName);

            model.PageTitle = "Báo cáo";
            model.Breadcrumbs = new List<string>() { "Trang chủ", "Báo cáo", "Lợi nhuận", "Báo cáo" };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> GetReport([FromBody] ManageReportProfitAndLossPagingRequest rq)
        {
            int storeId = System.Convert.ToInt32(HttpContext.Session.GetString(SystemConstants.AppConstants.DefaultStoreId));
            Dictionary<string, string> date = GetDatePast(rq.DateType);
            var request = new ManageReportProfitAndLossPagingRequest()
            {
                FromDate = date["fDate"],
                ToDate = date["tDate"] ,
                FromDatePast = date["fDatePast"],
                ToDatePast = date["tDatePast"],
                PageIndex = 0,
                PageSize = 0,
                StoreId = storeId,
            };

            var orderApiClient = await _reportProfitAndLossApiClient.GetReport(request);

            return Json(new
            {
                data = orderApiClient.Items
            });
        }

        private Dictionary<string,string> GetDatePast(int type)
        {
            Dictionary<string, string> date = new Dictionary<string,string>();
            string fDatePast = string.Empty, tDatePast = string.Empty, fDate = string.Empty, tDate = string.Empty;
            if (type == 1)// 7 ngày gần đây
            {
                tDate = DateTime.Now.ToString("dd/MM/yyyy");
                fDate = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
                tDatePast = DateTime.Now.AddDays(-8).ToString("dd/MM/yyyy");
                fDatePast = DateTime.Now.AddDays(-14).ToString("dd/MM/yyyy");
            }  else if(type== 2)//30 ngày gần đây  
            {
                tDate = DateTime.Now.ToString("dd/MM/yyyy");
                fDate = DateTime.Now.AddDays(-30).ToString("dd/MM/yyyy");
                tDatePast = DateTime.Now.AddDays(31).ToString("dd/MM/yyyy");
                fDatePast = DateTime.Now.AddDays(60).ToString("dd/MM/yyyy");
            }
            else if (type == 3)//Tuần này
            {

                //đầu tuần này
                var firstDayOfWeek = GetFirstDayOfWeek(DateTime.Now);
                //đầu tuần trước
                var firstDayOfWeekPast = GetFirstDayOfWeek(DateTime.Now.AddDays(-7));

                fDate = firstDayOfWeek.ToString("dd/MM/yyyy");
                tDate = firstDayOfWeek.AddDays(7).ToString("dd/MM/yyyy");
                fDatePast = firstDayOfWeekPast.ToString("dd/MM/yyyy");
                tDatePast = firstDayOfWeekPast.AddDays(7).ToString("dd/MM/yyyy");

            }
            else if (type == 4)//Tuần trước
            {
                //đầu tuần trước
                var firstDayOfWeekPast = GetFirstDayOfWeek(DateTime.Now.AddDays(-7));
                var firstDayOfWeekPastMinusOne = GetFirstDayOfWeek(DateTime.Now.AddDays(-14));
                fDate = firstDayOfWeekPast.ToString("dd/MM/yyyy");
                tDate = firstDayOfWeekPast.AddDays(7).ToString("dd/MM/yyyy");
                fDatePast = firstDayOfWeekPastMinusOne.ToString("dd/MM/yyyy");
                tDatePast = firstDayOfWeekPastMinusOne.AddDays(7).ToString("dd/MM/yyyy");
            }

            else if (type == 5)//Tháng này
            {
                fDate = GetFirstDayOfMonth(DateTime.Now).ToString("dd/MM/yyyy");
                tDate = GetLastDayOfMonth(DateTime.Now).ToString("dd/MM/yyyy");
                fDatePast = GetFirstDayOfMonth(DateTime.Now.AddMonths(-1)).ToString("dd/MM/yyyy");
                tDatePast = GetLastDayOfMonth(DateTime.Now.AddMonths(-1)).ToString("dd/MM/yyyy");
            }

            else if (type == 6)//Tháng trước
            {
                fDate = GetFirstDayOfMonth(DateTime.Now.AddMonths(-1)).ToString("dd/MM/yyyy");
                tDate = GetLastDayOfMonth(DateTime.Now.AddMonths(-1)).ToString("dd/MM/yyyy");
                fDatePast = GetFirstDayOfMonth(DateTime.Now.AddMonths(-2)).ToString("dd/MM/yyyy");
                tDatePast = GetLastDayOfMonth(DateTime.Now.AddMonths(-2)).ToString("dd/MM/yyyy");
            }

            date.Add("fDate", fDate);
            date.Add("tDate", tDate);
            date.Add("fDatePast", fDatePast);
            date.Add("tDatePast", tDatePast);


            return date;
        }

        public static DateTime GetFirstDayOfWeek(DateTime dayInWeek)
        {
            CultureInfo defaultCultureInfo = CultureInfo.CurrentCulture;
            return GetFirstDayOfWeek(dayInWeek, defaultCultureInfo);
        }

        /// <summary>
        /// Lấy ra ngày đầu tiên trong tuần của ngày nhập vào
        /// với một Culture cụ thể được truyền vào
        /// </summary>
        /// <param name="dayInWeek">Ngày nhập vào</param>
        /// <param name="cultureInfo">CultureInfo quy định các thông tin về Culture 
        /// ( định dạng ngày tháng, ngày bắt đầu trong tuần , ... )
        /// </param>
        /// <returns></returns>
        private static DateTime GetFirstDayOfWeek(DateTime dayInWeek, CultureInfo cultureInfo)
        {
            DayOfWeek firstDay = DayOfWeek.Monday;
            DateTime firstDayInWeek = dayInWeek.Date;
            while (firstDayInWeek.DayOfWeek != firstDay)
            {
                firstDayInWeek = firstDayInWeek.AddDays(-1);
            }
            return firstDayInWeek;
        }
        /// <summary>
        /// Lấy ra ngày đầu tiên trong tuần của ngày nhập vào
        /// với 1 giá trị cụ thể của enum DayOfWeek chỉ định 
        /// ngày bắt đầu tuần là thứ mấy
        /// </summary>
        /// <param name="dayInWeek">Ngày nhập vào</param>
        /// <param name="dayOfWeek">enum chỉ định thứ bắt đầu tuần</param>
        /// <returns></returns>
        private static DateTime GetFirstDayOfWeek(DateTime dayInWeek, DayOfWeek dayOfWeek)
        {
            DateTime firstDayInWeek = dayInWeek.Date;

            while (firstDayInWeek.DayOfWeek != dayOfWeek)
            {
                firstDayInWeek = firstDayInWeek.AddDays(-1);
            }
            return firstDayInWeek;
        }


        /// <summary>
        /// Lấy ra ngày đầu tiên trong tháng có chứa 
        /// 1 ngày bất kỳ được truyền vào
        /// </summary>
        /// <param name="dtDate">Ngày nhập vào</param>
        /// <returns>Ngày đầu tiên trong tháng</returns>
        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }
        /// <summary>
        /// Lấy ra ngày đầu tiên trong tháng được truyền vào 
        /// là 1 số nguyên từ 1 đến 12
        /// </summary>
        /// <param name="iMonth">Thứ tự của tháng trong năm</param>
        /// <returns>Ngày đầu tiên trong tháng</returns>
        public static DateTime GetFirstDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }



        /// <summary>
        /// Lấy ra ngày cuối cùng trong tháng có chứa 
        /// 1 ngày bất kỳ được truyền vào
        /// </summary>
        /// <param name="dtInput">Ngày nhập vào</param>
        /// <returns>Ngày cuối cùng trong tháng</returns>
        public static DateTime GetLastDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
        /// <summary>
        /// Lấy ra ngày cuối cùng trong tháng được truyền vào
        /// là 1 số nguyên từ 1 đến 12
        /// </summary>
        /// <param name="iMonth"></param>
        /// <returns></returns>
        public static DateTime GetLastDayOfMonth(int iMonth)
        {
            DateTime dtResult = new DateTime(DateTime.Now.Year, iMonth, 1);
            dtResult = dtResult.AddMonths(1);
            dtResult = dtResult.AddDays(-(dtResult.Day));
            return dtResult;
        }
    }
}