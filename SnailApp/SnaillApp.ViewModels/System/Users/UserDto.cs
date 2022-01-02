using System;
using System.Collections.Generic;
using SnailApp.ViewModels.Catalog.AppUserTypes;
using SnailApp.ViewModels.Catalog.Genders;
using SnailApp.ViewModels.System.AppRoles;
using SnailApp.ViewModels.System.AppUser_AppUserTypes;
using SnailApp.ViewModels.System.MenuAppRoles;
using SnailApp.ViewModels.System.Statuses.AppUserStatus;

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
        public DateTime? Dob { get; set; }
        public string StrDob { set; get; }
        public IList<AppRoleDto> AppRoles { get; set; }
        public string Avatar { set; get; }
        public AppUserStatusDto AppUserStatus { set; get; }
        public int? GenderId { set; get; }
        public GenderDto Gender { set; get; }
        public string Address { set; get; }
        public string StrCreatedDate { set; get; }
        public string StrLastimePurchase { set; get; }
        public List<MenuAppRoleDto> MenuAppRoles { set; get; }
        public bool IsAllowView { set; get; }
        public bool IsAllowEdit { set; get; }
        public bool IsAllowDelete { set; get; }
        public bool IsActive { set; get; }
        public bool IsStillInUse { set; get; }
        public string Id_Image_FullName_Email { set; get; }
        public List<AppUserTypeDto> AppUserTypes { set; get; }
        public string TaxCode { set; get; }
        public string Password { set; get; }
        public DateTime? LeaveDate { set; get; }
        public DateTime StartingDate { set; get; }
        public string CountryCode { set; get; }
        public string AddressStreet { set; get; }
        public string AddressDistrict { set; get; }
        public string AddressWard { set; get; }
        public string AddressCity { set; get; }
        public int AccountType { set; get; }
        public string DateOfBirth { set; get; }
        public bool IsEmailVerified { set; get; }
        public bool IsPhoneVerified { set; get; }
        public string Pin { set; get; }
        public double RewardPoints { set; get; }
        public List<int> RewardList { set; get; }
        public List<int> FavoriteProductIds { set; get; }
        public double TotalDebt { set; get; }
        public string StrTotalDebt { set; get; }
        public double TotalMoney { set; get; }
        public string StrTotalMoney { set; get; }
        public double TongTienTraHang { set; get; }
        public string StrTongTienTraHang { set; get; }
        public string CompanyName { set; get; }
        public string GhiChu { set; get; }       
        public int SoDonHang { set; get; }
        public double NoNhaCungCap { set; get; }
        public string StrNoNhaCungCap { set; get; }
    }
}