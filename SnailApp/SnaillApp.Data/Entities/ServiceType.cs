using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace SnailApp.Data.Entities
{
    public class ServiceType : BaseEntity
    {
        public string Image { set; get; }
        public int ClinicId { set; get; }
        public virtual Clinic Clinics { set; get; }
    }
}
