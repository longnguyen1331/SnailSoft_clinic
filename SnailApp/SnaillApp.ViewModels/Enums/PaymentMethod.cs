using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.ViewModels.Enums
{
    public enum PaymentMethod
    {
        Cash = 0,
        Bank = 1,
        Transfer = 2,
        Debit = 3,
        MembershipCard = 4
    }

    public enum AppointmentStatus
    {
        Cancel = 0,
        Booking= 1, 
        Approve = 2, 
        Checkin = 3 ,
        Examined =4,
        Checkout = 5
    }
}
