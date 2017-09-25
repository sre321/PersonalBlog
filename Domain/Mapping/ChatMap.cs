using System;
using System.Data.Entity.ModelConfiguration;

namespace Domain
{
    public class ChatMap:EntityTypeConfiguration<Chat>
    {
        public ChatMap()
        {
            this.ToTable("PB_Chat");
            this.HasKey(t => t.Id);
            this.Property(t => t.Body).IsRequired().HasMaxLength(1000);
            this.Property(t => t.PointCount).IsRequired();
            this.Property(t => t.PublicationDate).IsRequired();
            this.Property(t => t.Image).HasMaxLength(100);
        }
    }
}
