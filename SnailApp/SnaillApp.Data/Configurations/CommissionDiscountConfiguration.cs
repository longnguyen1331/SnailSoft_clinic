﻿using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class CommissionDiscountConfiguration : IEntityTypeConfiguration<CommissionDiscount>
    {
        public void Configure(EntityTypeBuilder<CommissionDiscount> builder)
        {
            builder.ToTable("CommissionDiscounts");
        }
    }
}