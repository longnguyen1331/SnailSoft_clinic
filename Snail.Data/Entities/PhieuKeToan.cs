using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Snail.ViewModels.Enums;

namespace Snail.Data.Entities
{
    public class PhieuKeToan : BaseEntity
    {
        public LoaiPhieuKeToan LoaiPhieuKeToan { set; get; }
        public Guid? SaleStaffId { set; get; }
        public virtual AppUser SaleStaff { set; get; }
        public Guid? AppUserId { set; get; }
        public virtual AppUser AppUser { set; get; }
        public Guid? CustomerId { set; get; }
        public virtual AppUser Customer { set; get; }
        public DateTime Date { set; get; }
        public int? PhieuKeToanStatusId { set; get; }
        public virtual PhieuKeToanStatus PhieuKeToanStatus { set; get; }
        public double MoneyBeforeTax { set; get; } 
        public double MoneyAffterTax { set; get; }
        public double TotalMoney { set; get; }
        public double TotalPaid { set; get; }
        public double TotalDiscount { set; get; }
        public double TotalCommission { set; get; }
        public double TotalDebt { set; get; }
        public double TotalBuyingPrice { set; get; }
        public double PercentDiscount { set; get; }
        public int PaymentMethod { set; get; }
        
        public int? StoreId { get; set; }
        public virtual Store Store { get; set; }
        public string Note { set; get; }
        public List<PhieuKeToanChiTiet> PhieuKeToanChiTiets { get; set; }
    }
}