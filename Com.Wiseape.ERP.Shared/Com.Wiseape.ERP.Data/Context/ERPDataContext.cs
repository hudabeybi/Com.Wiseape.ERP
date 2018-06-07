namespace Com.Wiseape.ERP.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data.SqlClient;
    using Com.Wiseape.ERP.Data.Model;

    public partial class ERPDataContext : DbContext
    {
        public ERPDataContext()
            : base("name=ERPDataContext")
        {
        }

        public virtual DbSet<Theme> Themes { get; set; }
        public virtual DbSet<ApplicationGroup> ApplicationGroups { get; set; }
        public virtual DbSet<ApplicationItem> ApplicationItems { get; set; }
        public virtual DbSet<ApplicationSetting> ApplicationSettings { get; set; }
        public virtual DbSet<GlobalApplicationSetting> GlobalApplicationSettings { get; set; }
        public virtual DbSet<GlobalApplicationSettingTemplate> GlobalApplicationSettingTemplates { get; set; }
        public virtual DbSet<UserLogin> UserLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Theme>()
                 .Property(e => e.ThemeName)
                 .IsUnicode(false);

            modelBuilder.Entity<Theme>()
                .Property(e => e.ThemeInfo)
                .IsUnicode(false);

            modelBuilder.Entity<Theme>()
                .Property(e => e.LoadingAnimation)
                .IsUnicode(false);

            modelBuilder.Entity<Theme>()
                .Property(e => e.LoadingAnimationAudio)
                .IsUnicode(false);

            modelBuilder.Entity<Theme>()
                .Property(e => e.DefaultWallpaper)
                .IsUnicode(false);

            modelBuilder.Entity<Theme>()
                .Property(e => e.TaskbarColor)
                .IsUnicode(false);

            modelBuilder.Entity<Theme>()
                .Property(e => e.TaskbarMenuColor)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationGroup>()
                .Property(e => e.ApplicationGroupName)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationGroup>()
                .Property(e => e.ApplicationGroupDesc)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationGroup>()
                .Property(e => e.ApplicationGroupIcon)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationGroup>()
                .HasMany(e => e.ApplicationItems)
                .WithOptional(e => e.ApplicationGroup)
                .HasForeignKey(e => e.ApplicationGroupId);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationName)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationIcon)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationDesc)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationPath)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationFile)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationClass)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationItem>()
                .Property(e => e.ApplicationStartFunction)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSetting>()
                .Property(e => e.SettingKey)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSetting>()
                .Property(e => e.SettingValue)
                .IsUnicode(false);

            modelBuilder.Entity<ApplicationSetting>()
                .Property(e => e.AppName)
                .IsUnicode(false);

            modelBuilder.Entity<GlobalApplicationSetting>()
                .Property(e => e.SettingName)
                .IsUnicode(false);

            modelBuilder.Entity<GlobalApplicationSetting>()
                .Property(e => e.SettingValue)
                .IsUnicode(false);

            modelBuilder.Entity<GlobalApplicationSetting>()
                .Property(e => e.UserID)
                .IsUnicode(false);

            modelBuilder.Entity<GlobalApplicationSettingTemplate>()
                .Property(e => e.ApplicationSettingName)
                .IsUnicode(false);

            modelBuilder.Entity<GlobalApplicationSettingTemplate>()
                .Property(e => e.ApplicationSettingValue)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.IdentityNo)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<UserLogin>()
                .Property(e => e.UserPassword)
                .IsUnicode(false);
        }
    }
}
