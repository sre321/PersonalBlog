using System;
using System.Data.Entity.ModelConfiguration;

namespace Domain
{
    public class CommentMap: EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            this.ToTable("PB_Comment");
            this.HasKey(t => t.Id);
            this.Property(t => t.Account).IsRequired().HasMaxLength(50);
            this.Property(t => t.PostTime).IsRequired();
            this.Property(t => t.Body).IsRequired().HasMaxLength(1000);
        }
    }
}
