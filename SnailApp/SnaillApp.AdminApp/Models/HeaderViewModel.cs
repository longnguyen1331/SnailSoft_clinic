using System.Collections.Generic;
using SnailApp.ViewModels.System.Languages;
using SnailApp.ViewModels.System.User_Clinics;

namespace SnailApp.AdminApp.Models
{
    public class HeaderViewModel
    {
        public List<LanguageDto> Languages { get; set; }
        public List<User_ClinicDto> Clinics { get; set; }

        public int CurrentClinicId { get; set; }
        public int CurrentLanguageId { get; set; }
        public string ReturnUrl { set; get; }
        public string UserImage { set; get; }
        public string FullName { set; get; }
        public string Email { set; get; }
        public string Logo { set; get; }
    }
}
