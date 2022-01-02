using SnailApp.Data.Entities;
using SnailApp.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class PetServiceSelectionTranslationConfiguration : IEntityTypeConfiguration<PetServiceSelectionTranslation>
    {
        public void Configure(EntityTypeBuilder<PetServiceSelectionTranslation> builder)
        {
            builder.ToTable("PetServiceSelectionTranslations");

            builder.HasOne(x => x.Language).WithMany(x => x.PetServiceSelectionTranslations).HasForeignKey(x => x.LanguageId);

            builder.HasOne(x => x.PetServiceSelection).WithMany(x => x.PetServiceSelectionTranslations).HasForeignKey(x => x.PetServiceSelectionId);

        }
    }
}