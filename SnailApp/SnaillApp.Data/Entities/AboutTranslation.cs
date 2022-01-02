using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnailApp.Data.Entities
{
    public class AboutTranslation : BaseEntity
    {
        public int AboutId { set; get; }
        public About About { get; set; }
        public int LanguageId { set; get; }
        public Language Language { get; set; }



        public string Address { set; get; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Youtube { get; set; }
        public string GoogleMap { get; set; }
        public string Logo { get; set; }
        public string AboutUs { get; set; }
    }
}
