using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;
using System.ComponentModel.DataAnnotations;

namespace SnailApp.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string Code { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }
        public DateTime? Dob { get; set; }
        public List<Transaction> Transactions { get; set; }
        public string Avatar { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { set; get; }
        public string Address { set; get; }

        [DataType("ntext")]
        public string Biography { set; get; }
        [DataType("ntext")]
        public string Skills { set; get; }
        [DataType("ntext")]
        public string Proifle { set; get; }
        public string Phone { set; get; }
        public bool Status { set; get; }
        public int? ClinicId { get; set; }
        public virtual Clinic Clinics { get; set; }
        public int? BloodId { get; set; }
        public virtual Blood Bloods { get; set; }
        public int? CityId { get; set; }
        public virtual Region Citys { get; set; }
        public int? ProvinceId { get; set; }
        public virtual Region Provinces { get; set; }
        public int? WardId { get; set; }
        public virtual Region Wards { get; set; }
        public int? Type { get; set; }
        public ICollection<AppUser_Clinic> AppUser_Clinics { get; set; }
    }
}
