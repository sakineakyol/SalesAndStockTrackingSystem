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
    public class InvoiceMap: EntityTypeConfiguration<Invoice>
    {
        public InvoiceMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.InvoiceNumber).HasMaxLength(12);
            this.Property(p => p.InvoiceType).HasMaxLength(30);
            this.Property(p => p.CurrentCode).HasMaxLength(12);
            this.Property(p => p.CurrentName).HasMaxLength(50);
            this.Property(p => p.DocumentNo).HasMaxLength(20);
            this.Property(p => p.SalesRepresentativeCode).HasMaxLength(12);
            this.Property(p => p.SalesRepresentativeName).HasMaxLength(50);
            this.Property(p => p.DiscountRate).HasPrecision(5,2);
            this.Property(p => p.DiscountTotal).HasPrecision(12, 2);
            this.Property(p => p.TotalAmount).HasPrecision(12, 2);
            this.Property(p => p.Description).HasMaxLength(200);


            this.ToTable("Invoices");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.InvoiceNumber).HasColumnName("InvoiceNumber");
            this.Property(p => p.InvoiceType).HasColumnName("InvoiceType");
            this.Property(p => p.CurrentCode).HasColumnName("CurrentCode");
            this.Property(p => p.CurrentName).HasColumnName("CurrentName");
            this.Property(p => p.DocumentNo).HasColumnName("DocumentNo");
            this.Property(p => p.DateTime).HasColumnName("DateTime");
            this.Property(p => p.SalesRepresentativeCode).HasColumnName("SalesRepresentativeCode");
            this.Property(p => p.SalesRepresentativeName).HasColumnName("SalesRepresentativeName");
            this.Property(p => p.DiscountRate).HasColumnName("DiscountRate");
            this.Property(p => p.DiscountTotal).HasColumnName("DiscountTotal");
            this.Property(p => p.TotalAmount).HasColumnName("TotalAmount");
            this.Property(p => p.Description).HasColumnName("Description");
          
        }
    }
}
