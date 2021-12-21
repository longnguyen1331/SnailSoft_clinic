using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class WebsiteMenuConfiguration : IEntityTypeConfiguration<WebsiteMenu>
    {
        public void Configure(EntityTypeBuilder<WebsiteMenu> builder)
        {
            builder.ToTable("WebsiteMenus");
        }
    }
}