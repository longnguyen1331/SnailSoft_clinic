using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Website.Abouts
{
    public class AboutDto : BaseDto
    {
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