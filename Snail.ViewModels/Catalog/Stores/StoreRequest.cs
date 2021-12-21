using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Catalog.Stores
{
    public class StoreRequest
    {
        public int? Id { set; get; }
        public int SortOrder { set; get; }
        public virtual string Code { set; get; }
        public virtual string Name { set; get; }
        public virtual string Description { set; get; }
        public string CreatedDate { set; get; }
        public string ModifiedDate { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public bool IsDeleted { set; get; }
        public bool IsDefault { set; get; }
        public bool IsVisibled { set; get; }

        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string Website { get; set; }
        public string Taxcode { get; set; }
        public string Logo { get; set; }
        public int StoreStatusId { get; set; }
        public int LanguageId { set; get; }
    }

}