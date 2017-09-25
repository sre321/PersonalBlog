using System;
using System.Data.Entity.ModelConfiguration;

namespace Domain
{
    public class PictureMap : EntityTypeConfiguration<Picture>
    {
        public PictureMap()
        {
            this.ToTable("PB_Picture");
            this.HasKey(t => t.Id);
            this.Property(t => t.OwnerId).IsRequired();
            this.Property(t => t.MimeType).IsRequired().HasMaxLength(50);
            this.Property(t => t.AltAttribute).HasMaxLength(50);
            this.Property(t => t.PictureName).IsRequired().HasMaxLength(50);
            this.Property(t => t.OwnPicName).IsRequired().HasMaxLength(100);
            this.Property(t => t.PictureType).IsRequired();
        }
    }
}
