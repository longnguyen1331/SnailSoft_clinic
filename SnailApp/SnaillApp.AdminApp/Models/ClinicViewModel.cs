using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.Catalog.Clinics;

namespace SnailApp.AdminApp.Models
{
    public class ClinicViewModel : BaseViewModel
    {
        public ClinicDto Clinic { set; get; }
        public List<SelectListItem> AppRoles { get; set; }
        public string FileNoImagePerson { set; get; }
    }
}
