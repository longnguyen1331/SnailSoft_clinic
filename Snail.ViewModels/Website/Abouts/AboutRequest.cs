using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Enums;

namespace Snail.ViewModels.Website.Abouts
{
    public class AboutRequest
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

        public string Address { set; get; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
        public string GoogleMap { get; set; }
        public string Logo { get; set; }
        public string AboutUs { get; set; }
        public int LanguageId { set; get; }
    }

}