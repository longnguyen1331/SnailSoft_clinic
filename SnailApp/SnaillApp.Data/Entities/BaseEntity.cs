using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SnailApp.Data.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            SortOrder = 0;
            CreatedDate = System.DateTime.Now;
            ModifiedDate = System.DateTime.Now;
            IsDeleted = false;
            IsDefault = false;
            IsVisibled = true;            
        }

        [Key]
        public int Id { set; get; }
        public int SortOrder { set; get; }
        [MaxLength()]
        public virtual string Code { set; get; }
        [MaxLength()]
        public virtual string Name { set; get; }
        [Column(TypeName = "ntext")]
        public virtual string Description { set; get; }
        public System.DateTime CreatedDate { set; get; }
        public System.DateTime ModifiedDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }
    }
}
