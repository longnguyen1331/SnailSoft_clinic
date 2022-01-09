using SnailApp.Data.Configurations;
using SnailApp.Data.Entities;
using SnailApp.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace SnailApp.Data.EF
{
    public class ClinicDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public ClinicDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
            modelBuilder.ApplyConfiguration(new AppUser_ClinicConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new BloodConfiguration());
            modelBuilder.ApplyConfiguration(new ClinicConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new GenderTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new MenuAppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new MenuConfiguration());
            modelBuilder.ApplyConfiguration(new MenuTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            //Data seeding
            modelBuilder.Seed();
        }
        
        public DbSet<Region> Regions { get; set; }
        public DbSet<Blood> Bloods { get; set; }
        public DbSet<AppUser_Clinic> User_Clinics { get; set; }
        public DbSet<Clinic> Clinics{ get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<AppRoleTranslation> AppRoleTranslations { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }        
        public DbSet<Gender> Genders { get; set; }
        public DbSet<GenderTranslation> GenderTranslations { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Menu> Menus { get; set; }
       
        public DbSet<MenuAppRole> MenuAppRoles { get; set; }
        public DbSet<MenuTranslation> MenuTranslations { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
