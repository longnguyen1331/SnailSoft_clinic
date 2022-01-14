using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class AppointmentPaymentDto : BaseDto
    {
        public int AppointmentId { set; get; }
        public decimal Total { set; get; }
        public decimal Discount { set; get; }
        public decimal AmountDue { set; get; }
        public int PaymentMethodId { get; set; }
        public string Date { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public string PaymentMethodNote { set; get; }
        public int Status { set; get; }
    }
    
}