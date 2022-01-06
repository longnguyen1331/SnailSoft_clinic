using System;

namespace SnailApp.Data.Entities
{
    public class Doctor : BaseEntity
    {
        public Guid UserID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Biography { set; get; }
        public string Skills { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int GenderID { set; get; }
        public Gender Gender { set; get; }
        public bool Status { set; get; }
        public string AddressDetails { set; get; }
        public int ClinicID { set; get; }
    }
}
