using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Accountants.PhieuKeToanChiTiets;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Accountants.PhieuKeToans
{
    public class PhieuKeToanRequest
    {
        public int? Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        public string CreatedDate { set; get; }
        public string ModifiedDate { set; get; }
        public Guid? CreatedUserId { set; get; }
        public Guid? ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }
        public int Type { set; get; } // enum
        public Guid SaleStaffId { set; get; }
        public Guid? CustomerId { set; get; }
        public string Date { set; get; }
        public int PhieuKeToanStatusId { set; get; } 
        public double MoneyBeforeTax { set; get; }
        public double MoneyAffterTax { set; get; }
        public double TotalMoney { set; get; }
        public double TotalPaid { set; get; }
        public int StoreId { get; set; }
        public string Note { set; get; }
        public double TotalDiscount { set; get; }
        public double TotalCommission { set; get; }
        public double TotalDebt { set; get; }
        public double TotalBuyingPrice { set; get; }
        public double PercentDiscount { set; get; }
        public List<PhieuKeToanChiTietDto> PhieuKeToanChiTiets { get; set; }
    }
    
}