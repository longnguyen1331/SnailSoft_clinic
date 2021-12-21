﻿using Snail.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Contact: BaseEntity
    {
        public string Email { set; get; }
        public string PhoneNumber { set; get; }
        public string Message { set; get; }
    }
}
