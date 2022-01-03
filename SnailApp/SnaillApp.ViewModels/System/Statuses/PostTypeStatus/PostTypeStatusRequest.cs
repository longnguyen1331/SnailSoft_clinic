﻿using System;

namespace SnailApp.ViewModels.System.Statuses.PostTypeStatus
{
    public class PostTypeStatusRequest
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