using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.Catalog.Appointments;
using SnailApp.ViewModels.Catalog.Clinics;
using SnailApp.ViewModels.Catalog.ExaminationsResults;

namespace SnailApp.AdminApp.Models
{
    public class AppointmentServiceViewModel : BaseViewModel
    {
        public Appointment_ServiceDto Appointment_Service { set; get; }
    }
}
