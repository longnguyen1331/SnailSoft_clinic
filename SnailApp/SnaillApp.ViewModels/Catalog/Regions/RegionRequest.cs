using System;

namespace SnailApp.ViewModels.Catalog.Regions
{
    public class RegionRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int Level { set; get; }
        public string ParentName { set; get; }
        public int? ParentId { get; set; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
    }
}
