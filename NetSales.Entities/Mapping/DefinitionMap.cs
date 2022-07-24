using NetSales.Entities.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Mapping
{
    public class DefinitionMap : EntityTypeConfiguration<Definition>
    {
        public DefinitionMap()
        {

            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Type).HasMaxLength(15);
            this.Property(p => p.Definitions).HasMaxLength(30);
            this.Property(p => p.Description).HasMaxLength(200);


            this.ToTable("Definitions");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.Type).HasColumnName("Type");
            this.Property(p => p.Definitions).HasColumnName("Definitions");
            this.Property(p => p.Description).HasColumnName("Description");
        }
    }
}
