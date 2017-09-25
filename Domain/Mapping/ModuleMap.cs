using System;
using System.Data.Entity.ModelConfiguration;

namespace Domain
{
    public class ModuleMap: EntityTypeConfiguration<Module>
    {
        public ModuleMap()
        {
            this.ToTable("PB_Module");
            this.HasKey(t => t.Id);
            this.Property(t => t.ModuleName).HasMaxLength(50);
            this.Property(t => t.HeadLine).HasMaxLength(200);
        }
    }
}
