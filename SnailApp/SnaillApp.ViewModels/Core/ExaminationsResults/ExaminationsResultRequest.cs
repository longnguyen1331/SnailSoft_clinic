using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.ExaminationsResults
{
    public class ExaminationsResultRequest : BaseRequest
    {
        public int AppointmentId { set; get; }
        public string ExaminationDate { set; get; }
        public string Re_Examination { set; get; }
        public string Results { set; get; }
        public string DoctorAdvice { set; get; }
        public int ClinicId { set; get; }
    }
}