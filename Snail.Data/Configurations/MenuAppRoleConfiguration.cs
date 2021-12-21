using Snail.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.Data.Configurations
{
    public class MenuAppRoleConfiguration : IEntityTypeConfiguration<MenuAppRole>
    {
        public void Configure(EntityTypeBuilder<MenuAppRole> builder)
        {
            builder.ToTable("MenuAppRoles");

            builder.HasOne(t => t.Menu).WithMany(pc => pc.MenuRoles).HasForeignKey(pc => pc.MenuId);

            builder.HasOne(t => t.AppRole).WithMany(pc => pc.MenuRoles).HasForeignKey(pc => pc.AppRoleId);
        }
    }
}
