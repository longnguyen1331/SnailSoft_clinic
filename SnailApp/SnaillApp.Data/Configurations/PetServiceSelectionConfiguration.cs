using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PetServiceSelectionConfiguration : IEntityTypeConfiguration<PetServiceSelection>
    {
        public void Configure(EntityTypeBuilder<PetServiceSelection> builder)
        {
            builder.ToTable("PetServiceSelections");
        }
    }
}
