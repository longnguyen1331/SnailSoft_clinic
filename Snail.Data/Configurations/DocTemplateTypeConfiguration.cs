using Snail.Data.Entities;
using Snail.ViewModels.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class DocTemplateTypeConfiguration : IEntityTypeConfiguration<DocTemplateType>
    {
        public void Configure(EntityTypeBuilder<DocTemplateType> builder)
        {
            builder.ToTable("DocTemplateTypes");
        }
    }
}
