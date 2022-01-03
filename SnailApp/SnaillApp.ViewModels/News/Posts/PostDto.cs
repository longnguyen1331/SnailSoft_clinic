﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SnailApp.ViewModels.Enums;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.System.Statuses.PostStatus;
using SnailApp.ViewModels.Catalog.PostTypes;

namespace SnailApp.ViewModels.News.Posts
{
    public class PostDto: BaseDto
    {
        public string Author { set; get; }
        public string Content { set; get; }
        public int? PostTypeId { set; get; }
        public PostTypeDto PostType { set; get; }
        public int? PostStatusId { set; get; }
        public PostStatusDto PostStatus { set; get; }
        public string ThumbnailImage { set; get; }
        public int? ThumbnailImageId { set; get; }
        public List<string> CategorieOfPosts { get; set; } = new List<string>();
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }
        public int ViewCount { set; get; }
        public string SeoAlias { get; set; }
        public string Abstract { set; get; }
    }
}