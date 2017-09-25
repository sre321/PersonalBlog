using System;
using System.Data.Entity.ModelConfiguration;

namespace Domain
{
    public class CategoryMap:EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.ToTable("PB_Category");
            this.HasKey(t => t.Id);
            this.Property(t => t.CategoryName).HasMaxLength(50);
        }
    }
}
