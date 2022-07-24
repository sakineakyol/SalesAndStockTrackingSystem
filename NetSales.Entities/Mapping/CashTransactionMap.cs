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
    public class CashTransactionMap: EntityTypeConfiguration<CashTransaction>
    {
        public CashTransactionMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.InvoiceCode).HasMaxLength(12);
            this.Property(p => p.Movement).HasMaxLength(10);
            this.Property(p => p.CashCode).HasMaxLength(12);
            this.Property(p => p.CashName).HasMaxLength(30);
            this.Property(p => p.PaymentTypeCode).HasMaxLength(12);
            this.Property(p => p.PaymentTypeName).HasMaxLength(30);
            this.Property(p => p.CurrentCode).HasMaxLength(12);
            this.Property(p => p.CurrentName).HasMaxLength(50);
            this.Property(p => p.Amount).HasPrecision(12, 2);
            this.Property(p => p.Description).HasMaxLength(200);

            this.ToTable("CashTransactions");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.InvoiceCode).HasColumnName("InvoiceCode");
            this.Property(p => p.Movement).HasColumnName("Movement");
            this.Property(p => p.CashCode).HasColumnName("CashCode");
            this.Property(p => p.CashName).HasColumnName("CashName");
            this.Property(p => p.PaymentTypeCode).HasColumnName("PaymentTypeCode");
            this.Property(p => p.PaymentTypeName).HasColumnName("PaymentTypeName");
            this.Property(p => p.CurrentCode).HasColumnName("CurrentCode");
            this.Property(p => p.CurrentName).HasColumnName("CurrentName");
            this.Property(p => p.DateTime).HasColumnName("DateTime");
            this.Property(p => p.Amount).HasColumnName("Amount");
            this.Property(p => p.Description).HasColumnName("Description");
        }
    }
}
