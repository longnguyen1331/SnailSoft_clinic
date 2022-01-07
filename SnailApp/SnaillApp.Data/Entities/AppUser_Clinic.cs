using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace SnailApp.Data.Entities
{
    public class AppUser_Clinic : BaseEntity
    {
        public int ClinicID { set; get; }
        public Clinic Clinic { set; get; }
        public Guid UserId { set; get; }
        public AppUser AppUser { set; get; }
    }
}
