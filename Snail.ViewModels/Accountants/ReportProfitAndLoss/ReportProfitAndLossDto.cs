
namespace Snail.ViewModels.Accountants.PhieuKeToans
{
    public class ReportProfitAndLossDto
    {
        public string Date { set; get; }
        public int QtyInStock { set; get; }
        public double Price { set; get; }
        public double BuyingPrice { set; get; }
        public double Revenue { set; get; }
        public double DoanhSoKyTruoc { set; get; }
        public double DoanhSoKyNay { set; get; }
        public double TienVonKyTruoc { set; get; }
        public double TienVonKyNay { set; get; }
        public double LaiGopKyTruoc { set; get; }
        public double LaiGopKyNay { set; get; }
    }
}

