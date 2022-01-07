using System;
using System.Collections.Generic;
using SnailApp.ViewModels.Catalog.AppUserTypes;
using SnailApp.ViewModels.Catalog.Genders;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.ViewModels.System.MenuAppRoles;
using SnailApp.ViewModels.System.Statuses.AppUserStatus;

namespace SnailApp.ViewModels.System.User_Clinics
{
    public class User_ClinicDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Avatar { get; set; }
        public Guid UserId { set; get; }
        public int ClinicId { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime ModifiedDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
    }
}