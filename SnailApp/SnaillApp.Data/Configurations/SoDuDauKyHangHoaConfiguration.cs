using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class SoDuDauKyHangHoaConfiguration : IEntityTypeConfiguration<SoDuDauKyHangHoa>
    {
        public void Configure(EntityTypeBuilder<SoDuDauKyHangHoa> builder)
        {
            builder.ToTable("SoDuDauKyHangHoas");
        }
    }
}
