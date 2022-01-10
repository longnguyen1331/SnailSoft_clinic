using System;
using System.Collections.Generic;
using SnailApp.ViewModels.Catalog.Genders;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.ViewModels.System.MenuAppRoles;

namespace SnailApp.ViewModels.System.Users
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Code { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }
        public string StrDob { set; get; }
        public IList<AppRoleDto> AppRoles { get; set; }
        public string Avatar { set; get; }
        public int? GenderId { set; get; }
        public GenderDto Gender { set; get; }
        public string Address { set; get; }
        public string StrCreatedDate { set; get; }
        public List<MenuAppRoleDto> MenuAppRoles { set; get; }
        public bool IsAllowView { set; get; }
        public bool IsAllowEdit { set; get; }
        public bool IsAllowDelete { set; get; }
        public bool IsActive { set; get; }
        public string Id_Image_FullName_Email { set; get; }
        public string Password { set; get; }
        public string Biography { set; get; }
        public string Skills { set; get; }
        public int? Type { set; get; }
        public int? ClinicId { set; get; }
        public int? ProvinceId { set; get; }
        public string DistrictName { set; get; }
        public int? DistrictId { set; get; }
        public string ProvinceName { set; get; }
        public int? WardId { set; get; }
        public string WardName { set; get; }
        public int? BloodId { set; get; }
        public string BloodName { set; get; }
        public string Proifle { set; get; }
    }
}