
namespace SnailApp.ViewModels.Accountants.PhieuKeToans
{
    public class ReportSummaryDto
    {
        public int  TotalOrders { set; get; }
        public double OrdeRaverageValue { set; get; }
        public double Revenue { set; get; }
        public double GrossProfit { set; get; }
        public double TotalPayment { set; get; }
        public double TotalCollectMoney { set; get; }
        public int TotalProductInStock { set; get; }
        public int TotalProductOutStock { set; get; }
    }
}

