using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Snail.Data.Entities
{
    public class PhieuKeToanChiTiet : BaseEntity
    {
        public int PhieuKeToanId { set; get; }
        public PhieuKeToan PhieuKeToan { get; set; }        
        public int? ProductSKUId { set; get; }
        public ProductSKU ProductSKU { get; set; }
        public int Qty { set; get; }
        public double Price { set; get; }
        public double ImportPrice { set; get; }
        public double TotalPrice { set; get; }
        public double BuyingPrice { set; get; }
        public double Discount { set; get; }
        public double Commission { set; get; }
        public ICollection<PhieuKeToanChiTiet_AppUser> PhieuKeToanChiTiets { set; get; }
    }
}