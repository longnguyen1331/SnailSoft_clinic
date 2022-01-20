using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Appointments
{
    public class AppointmentPaymentRequest : BaseRequest
    {
        public int AppointmentId { set; get; }
        public string Date { set; get; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal AmountDue { get; set; }
        public int PaymentMethod { get; set; }
        public string PaymentMethodNote { get; set; }
        public int Status { get; set; }
    }
}