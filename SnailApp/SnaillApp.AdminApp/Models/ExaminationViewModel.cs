using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.Catalog.Clinics;
using SnailApp.ViewModels.Catalog.ExaminationsResults;

namespace SnailApp.AdminApp.Models
{
    public class ExaminationViewModel : BaseViewModel
    {
        public ExaminationsResultDto ExaminationsResult { set; get; }
    }
}
