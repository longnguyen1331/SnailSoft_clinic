using SnailApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SnailApp.Data.Configurations
{
    public class AppUser_ClinicConfiguration : IEntityTypeConfiguration<AppUser_Clinic>
    {
        public void Configure(EntityTypeBuilder<AppUser_Clinic> builder)
        {
            builder.ToTable("AppUser_Clinics");
            builder.HasOne(x => x.Clinic).WithMany(x => x.AppUser_Clinics).HasForeignKey(x => x.ClinicID);
            builder.HasOne(x => x.AppUser).WithMany(x => x.AppUser_Clinics).HasForeignKey(x => x.UserId);
        }
    }
}
