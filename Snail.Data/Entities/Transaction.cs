﻿using Snail.ViewModels.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Entities
{
    public class Transaction: BaseEntity
    {
        public DateTime TransactionDate { set; get; }
        public string ExternalTransactionId { set; get; }
        public decimal Amount { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public string Provider { set; get; }
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
