using ChinoPet.ViewModels.Common;
using ChinoPet.ViewModels.News.Posts;
using System;
using System.Collections.Generic;
using ChinoPet.ViewModels.Catalog.PetServiceSelections;
using ChinoPet.ViewModels.System.ContactInformation;

namespace ChinoPet.Website.Models
{
    public class BlogViewModel
    {
        public PagedResult<PostDto> Data { set; get; }
        public string UrlServer { set; get; }
        public List<PostDto> Posts { set; get; }
        public List<PetServiceSelectionDto> PetServiceSelections { set; get; }
        public ContactInformationDto ContactInformation { set; get; }
    }
}
