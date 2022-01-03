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
        public int? GenderId { get; set; }
        public List<string> AppRoleCodes { set; get; }
        public bool IsActive { set; get; }
        public IFormFile Avatar { set; get; }
        public int LanguageId { set; get; }
    }
}
