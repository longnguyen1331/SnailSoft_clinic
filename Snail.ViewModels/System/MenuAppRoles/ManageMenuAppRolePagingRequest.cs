﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.System.MenuAppRoles
{
    public class ManageMenuAppRolePagingRequest: PagingRequestBase
    {
        public string AppRoleId { set; get; }
        public int? MenuId { set; get; }
    }
}
