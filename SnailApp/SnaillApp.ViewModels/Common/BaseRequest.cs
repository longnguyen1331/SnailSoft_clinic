using System;
namespace SnailApp.ViewModels.Common
{
    public class BaseRequest
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public DateTime CreatedDate { set; get; }
        public DateTime ModifiedDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }
        public int LanguageId { set; get; }
    }
}
