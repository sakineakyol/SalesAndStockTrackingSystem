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
    public class CashMap : EntityTypeConfiguration<Cash>
    {
        public CashMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CashCode).HasMaxLength(12);
            this.Property(p => p.CashName).HasMaxLength(30);
            this.Property(p => p.ContactCode).HasMaxLength(12);
            this.Property(p => p.ContactName).HasMaxLength(50);
            this.Property(p => p.Description).HasMaxLength(200);

            this.ToTable("Cashes");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.CashCode).HasColumnName("CashCode");
            this.Property(p => p.CashName).HasColumnName("CashName");
            this.Property(p => p.ContactCode).HasColumnName("ContactCode");
            this.Property(p => p.ContactName).HasColumnName("ContactName");
            this.Property(p => p.Description).HasColumnName("Description");
        }
    }
}
