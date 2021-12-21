using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Sales.Customers
{
    public class CustomerDto : BaseDto
    {
        public bool IsCustomer { set; get; }
        public bool IsSupplier { set; get; }
        public int? GenderId { set; get; }
        public PersonalOrCompany PersonalOrCompany { set; get; }
        public string Address { set; get; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Taxcode { get; set; }
        public string PersonContact { get; set; }
        public string LastimePurchase { get; set; }
        public float TotalDebt { get; set; }
        public string Note { set; get; }
        public DateTime? Dob { get; set; }
    }
}