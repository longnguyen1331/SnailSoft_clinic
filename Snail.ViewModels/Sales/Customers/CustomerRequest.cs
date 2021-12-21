using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Sales.Customers
{
    public class CustomerRequest
    {
        public int? Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        public string CreatedDate { set; get; }
        public string ModifiedDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }
        public PersonalOrCompany PersonalOrCompany { set; get; }
        public bool IsCustomer { set; get; }
        public bool IsSupplier { set; get; }
        public int GenderId { set; get; } 
        public string Address { set; get; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Taxcode { get; set; }
        public string PersonContact { get; set; }
        public DateTime? LastimePurchase { get; set; }
        public DateTime? Dob { get; set; }
        public string Note { set; get; }
        public float TotalMoney { get; set; }
        public float TotalDebt { get; set; }
        public int StoreId { get; set; }
        
    }
    
}