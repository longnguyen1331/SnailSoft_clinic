﻿using System;

namespace Snail.ViewModels.System.Statuses.SlideStatus
{
    public class SlideStatusRequest
    {
        public int? Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int LanguageId { set; get; }
        public int SortOrder { set; get; }
        public Guid CreatedUserId { set; get; }
        public Guid ModifiedUserId { set; get; }
    }
}
