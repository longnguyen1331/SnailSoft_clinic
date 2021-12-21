﻿using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class SoDuDauKySoQuyConfiguration : IEntityTypeConfiguration<SoDuDauKySoQuy>
    {
        public void Configure(EntityTypeBuilder<SoDuDauKySoQuy> builder)
        {
            builder.ToTable("SoDuDauKySoQuys");
        }
    }
}
