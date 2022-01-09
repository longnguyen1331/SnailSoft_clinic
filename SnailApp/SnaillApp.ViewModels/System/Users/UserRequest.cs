using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace SnailApp.ViewModels.System.Users
{
    public class UserRequest
    {
        public string Id { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public string Code { set; get; }
        public string Address { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public int? GenderId { get; set; }
        public string Biography { set; get; }
        public string Skills { set; get; }
        public int? Type { get; set; }
        public int? ClinicId { get; set; }
        public string AppRoleCodes { set; get; }
        public bool IsActive { set; get; }
        public IFormFile Avatar { set; get; }
        public int LanguageId { set; get; }
        public int? CityId { get; set; }
        public int? ProvinceId { get; set; }
        public int? WardId { get; set; }
        public string Proifle { set; get; }
        public int? BloodId { get; set; }
    }
}
