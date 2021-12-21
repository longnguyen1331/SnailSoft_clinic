using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.ViewModels.Catalog.CustomerTypes
{
    public class CustomerTypeRequest
    {
        public int? Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        public string CreatedDate { set; get; }
        public string ModifiedDate { set; get; }
        public string CreatedUserId { set; get; }
        public string ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }
        public int LanguageId { set; get; }
        public int StoreId { set; get; }
        
    }
    
}