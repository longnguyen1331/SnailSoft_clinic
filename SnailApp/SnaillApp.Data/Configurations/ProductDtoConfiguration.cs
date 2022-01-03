﻿using SnailApp.Data.Entities;
using SnailApp.ViewModels.Catalog.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class ProductDtoConfiguration : IEntityTypeConfiguration<ProductDto>
    {
        public void Configure(EntityTypeBuilder<ProductDto> builder)
        {

            builder.Property(x => x.Price).HasColumnType("decimal(18,2)");
            builder.Property(x => x.OriginalPrice).HasColumnType("decimal(18,2)");

        }
    }
}