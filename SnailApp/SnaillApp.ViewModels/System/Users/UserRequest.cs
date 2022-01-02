using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using SnailApp.ViewModels.Enums;
using Microsoft.AspNetCore.Http;

namespace SnailApp.ViewModels.System.Users
{
    public class UserRequest
    {
        public string Id { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public string Code { set; get; }
        public int AppUserStatusId { set; get; }
        public string Address { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TaxCode { get; set; }
        public int? GenderId { get; set; }
        public List<string> AppRoleCodes { set; get; }
        public bool IsActive { set; get; }
        public bool IsStillInUse { set; get; }
        public IFormFile Avatar { set; get; }
        public int LanguageId { set; get; }
        public string Description { set; get; }
        public string ContactPerson { set; get; }
        public List<int> AppUserTypeIds { set; get; }
        public string StrAppUserTypeIds { set; get; }
        public string AppUserTypeCodes { set; get; }
        public string LeaveDate { set; get; }
        public string StartingDate { set; get; }
        public string RegisterDate { set; get; }
        public IFormFileCollection ImportDataExcelFiles { set; get; }
        public string CompanyName { set; get; }
        public string MaSoThue { set; get; }
        public string GhiChu { set; get; }

    }
}
