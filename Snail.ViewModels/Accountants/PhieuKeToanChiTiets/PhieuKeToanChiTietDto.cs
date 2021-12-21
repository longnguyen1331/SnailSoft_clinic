using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Accountants.PhieuKeToanChiTiets
{
    public class PhieuKeToanChiTietDto: BaseDto
    {
        public string ProductSKUCode { set; get; }
        public string ProductSKUName { set; get; }
        public int? ProductSKUId { set; get; }
        public double Price { set; get; }
        public double Total { set; get; }
        public double TotalDiscount { set; get; }
        public double BuyingPrice { set; get; }
        public int? Qty { set; get; }
    }
}
