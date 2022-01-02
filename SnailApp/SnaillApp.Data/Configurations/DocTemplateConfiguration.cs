using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.Data.Configurations
{
    public class DocTemplateConfiguration : IEntityTypeConfiguration<DocTemplate>
    {
        public void Configure(EntityTypeBuilder<DocTemplate> builder)
        {
            builder.ToTable("DocTemplates");

            builder.HasOne(x => x.DocTemplateType).WithMany(x => x.DocTemplates).HasForeignKey(x => x.DocTemplateTypeId);
            builder.HasOne(x => x.PaperSize).WithMany(x => x.DocTemplates).HasForeignKey(x => x.PaperSizeId);
        }
    }
}
