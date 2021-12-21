using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Enums;

namespace Snail.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public bool IsDelete { set; get; }
        public string Code { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
        public DateTime? Dob { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Transaction> Transactions { get; set; }
        public string Avatar { set; get; }
        public int? AppUserStatusId { set; get; }
        public AppUserStatus AppUserStatus { set; get; }
        public DateTime? ActivateDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public string ContactPerson { get; set; }
        public DateTime? LastimePurchase { get; set; }
        public double TotalMoney { get; set; }
        public double TotalDebt { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { set; get; }
        public bool IsStillInUse { set; get; }
        public string TaxCode { set; get; }
        public ICollection<AppUser_AppUserType> AppUser_AppUserTypes { set; get; }
        public ICollection<AppUser_CommissionDiscount> AppUser_CommissionDiscounts { set; get; }
        public ICollection<PhieuKeToanChiTiet_AppUser> PhieuKeToanChiTiet_AppUsers { set; get; }
        public ICollection<AppUser_BasicSalary> AppUser_BasicSalarys { set; get; }
        public ICollection<PayrollDetail> PayrollDetails { set; get; }
        public DateTime StartingDate { set; get; }
        public DateTime? LeaveDate { set; get; }
        public DateTime RegisterDate { set; get; }
        public int? CountryId { set; get; }
        public Country Country { set; get; }
        public int? CustomerTypeId { set; get; }
        public CustomerType CustomerType { set; get; }
        public string Address { set; get; }
        public string AddressStreet { set; get; }
        public string AddressDistrict { set; get; }
        public string AddressWard { set; get; }
        public string AddressCity { set; get; }
        public bool IsEmailVerified { set; get; }
        public bool IsPhoneVerified { set; get; }
        public string Pin { set; get; }
        public double RewardPoints { set; get; }
        public ICollection<AppUser_Promotion> AppUser_Promotions { set; get; }
        public ICollection<FavoriteProduct> FavoriteProducts { set; get; }
        public string CompanyName { set; get; }
        public string GhiChu { set; get; }
        public double TongTienTraHang { set; get; }
        public int SoDonHang { set; get; }
        public ICollection<AppUserFeedback> AppUserFeedbacks { set; get; }
        public ICollection<AppUserHelp> AppUserHelps { set; get; }
        public double NoNhaCungCap { set; get; }
    }
}
