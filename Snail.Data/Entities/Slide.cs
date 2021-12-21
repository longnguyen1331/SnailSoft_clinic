using Snail.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Slide: BaseEntity
    {
        public string Link { set; get; }
        public string Image { get; set; }
        public int? SlideStatusId { set; get; }
        public SlideStatus SlideStatus { set; get; }
        public ICollection<SlideTranslation> SlideTranslations { set; get; }
    }
}