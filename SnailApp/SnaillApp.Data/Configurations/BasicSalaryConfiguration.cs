﻿using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class BasicSalaryConfiguration : IEntityTypeConfiguration<BasicSalary>
    {
        public void Configure(EntityTypeBuilder<BasicSalary> builder)
        {
            builder.ToTable("BasicSalarys");
        }
    }
}