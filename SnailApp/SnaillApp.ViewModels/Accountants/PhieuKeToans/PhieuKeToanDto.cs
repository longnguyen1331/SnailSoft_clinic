using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Accountants.PhieuKeToans
{
    public class PhieuKeToanDto : BaseDto
    {
        public RoleType LoaiPhieuKeToan { set; get; }
        public Guid SaleStaffId { set; get; }
        public Guid  CustomerId { set; get; }
        public string CustomerPhone { set; get; }
        public string CustomerAddress { set; get; }
        public string CustomerSex { set; get; }
        public string CustomerEmail { set; get; }
        public string CustomerBirthDay { set; get; }
        public DateTime Date { set; get; }
        public int StatusId { set; get; }
        public double MoneyBeforeTax { set; get; }
        public double MoneyAffterTax { set; get; }
        public double TotalDebt { set; get; }
        public double TotalBuyingPrice { set; get; }
        public double PercentDiscount { set; get; }
        public double TotalPaid { set; get; }
        public double TotalCommission { set; get; }
        public double TotalDiscount { set; get; }
        public PaymentMethod PaymentMethod { set; get; }
        public int StoreId { get; set; }
        public string Note { set; get; }
        public List<int> PhieuKeToanChiTiets { get; set; }
    }
}