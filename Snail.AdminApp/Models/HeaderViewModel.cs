using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.System.Languages;

namespace Snail.AdminApp.Models
{
    public class HeaderViewModel
    {
        public List<LanguageDto> Languages { get; set; }

        public int CurrentLanguageId { get; set; }
        public string HtmlMenus { set; get; }
        public string ReturnUrl { set; get; }
        public string UserImage { set; get; }
        public string FullName { set; get; }
        public string Email { set; get; }
        public string Logo { set; get; }
    }
}
