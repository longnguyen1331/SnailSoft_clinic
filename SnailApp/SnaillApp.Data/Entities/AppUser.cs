using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Enums;

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
    }
}
