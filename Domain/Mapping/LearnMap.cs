using System;
using System.Data.Entity.ModelConfiguration;

namespace Domain
{
    public class LearnMap:EntityTypeConfiguration<Learn>
    {
        public LearnMap()
        {
            this.ToTable("PB_Learn");
            this.HasKey(t => t.Id);
            this.Property(t => t.Author).IsRequired().HasMaxLength(50);
            this.Property(t => t.PublicationDate).IsRequired();
            this.Property(t => t.Body).IsRequired();
            this.Property(t => t.PointCount).IsRequired();
            this.Property(t => t.CommentCount).IsRequired();
        }
    }
}
