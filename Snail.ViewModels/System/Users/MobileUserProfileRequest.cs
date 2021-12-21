using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail.ViewModels.System.Users
{
    public class MobileUserProfileRequest
    {
        public string Id { set; get; }
        public string ModifiedUserId { set; get; }
        public string FullName { set; get; }
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public int CountryId { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
        public int AccountType { set; get; }
        public string AddressStreet { set; get; }
        public string AddressDistrict { set; get; }
        public string AddressWard { set; get; }
        public string AddressCity { set; get; }
        public string DateOfBirth { set; get; }
        public bool IsEmailVerified { set; get; }
        public bool IsPhoneVerified { set; get; }
        public string Pin { set; get; }
        public double RewardPoints { set; get; }
        public List<int> RewardList { set; get; }
        public List<int> FavoriteProducts { set; get; }
    }
}
