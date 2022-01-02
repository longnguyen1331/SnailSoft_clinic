using System;
namespace SnailApp.ViewModels.Common
{
    public class BaseDto
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string DateString { set; get; }
        public virtual string Description { set; get; }
        public virtual string CustomerName { set; get; }
        public virtual string SaleStaffName { set; get; }
        public virtual double TotalMoney { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime ModifiedDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }
        public int DayOfActive { set; get; }
        public int LanguageId { set; get; }
    }
}
