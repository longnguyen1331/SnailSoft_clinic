using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.ProductTypes
{
    public class ProductTypeRequest
    {
        public int? Id { get; set; }
        public string Name { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
        public int StoreId { set; get; }
        public int LanguageId { set; get; }
        public int SortOrder { set; get; }
        public int? ParentId { set; get; }
    }
    
}
