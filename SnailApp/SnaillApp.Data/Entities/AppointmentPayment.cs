using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace SnailApp.Data.Entities
{
    public class AppointmentPayment : BaseEntity
    {
        public int AppointmentId { set; get; }
        public virtual Appointment Appointment { get; set; }
        public decimal Total { set; get; }
        public decimal Discount { set; get; }
        public decimal AmountDue { set; get; }
        public int PaymentMethodId { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public string PaymentMethodNote { set; get; }
        public int Status { set; get; }
    }
}
