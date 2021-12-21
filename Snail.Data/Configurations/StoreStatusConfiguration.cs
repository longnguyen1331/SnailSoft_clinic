﻿using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
namespace Snail.Data.Configurations
{
    public class  StoreStatusConfiguration : IEntityTypeConfiguration<StoreStatus>
    {
        public void Configure(EntityTypeBuilder<StoreStatus> builder)
        {
            builder.ToTable("StoreStatuses");
        }
    }
}
