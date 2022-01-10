using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.Regions
{
    public class RegionDto: BaseDto
    {

        public int? ParentId { get; set; }
        public string ParentName { get; set; }
        public int Level { get; set; }
    }
}
