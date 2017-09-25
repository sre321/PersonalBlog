using System;
using System.Data.Entity.ModelConfiguration;

namespace Domain
{
    public class UserInfoMap:EntityTypeConfiguration<UserInfo>
    {
        public UserInfoMap()
        {
            this.ToTable("PB_UserInfo");
            this.HasKey(t => t.Id);
            this.Property(t => t.Name).HasMaxLength(50);
            this.Property(t => t.NickName).IsRequired().HasMaxLength(50);
            this.Property(t => t.Account).IsRequired().HasMaxLength(50);
            this.Property(t => t.PassWord).IsRequired().HasMaxLength(50);
            this.Property(t => t.Email).IsRequired().HasMaxLength(50);
            this.Property(t => t.IsBlogger).IsRequired();
            this.Property(t => t.IsLock).IsRequired();
            this.Property(t => t.CreateTime).IsRequired();
            this.Property(t => t.LastLoginTime).IsRequired();
            this.Property(t => t.NativePlace).HasMaxLength(300);
            this.Property(t => t.PresentAdd).HasMaxLength(300);
            this.Property(t => t.Career).HasMaxLength(50);
            this.Property(t => t.Interest).HasMaxLength(500);
            this.Property(t => t.Description).HasMaxLength(1000);
            this.Property(t => t.LastLoginIP).HasMaxLength(50);
        }
    }
}
