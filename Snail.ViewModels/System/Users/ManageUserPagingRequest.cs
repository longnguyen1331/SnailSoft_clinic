﻿using Snail.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.ViewModels.System.Users
{
    public class ManageUserPagingRequest : PagingRequestBase
    {
        public string AppUserId { set; get; }
        public string FromDate { set; get; }
        public string ToDate { set; get; }
    }
}