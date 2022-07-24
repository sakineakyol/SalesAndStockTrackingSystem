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
    public class PaymentTypeMap : EntityTypeConfiguration<PaymentType>
    {
        public PaymentTypeMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.PaymentTypeCode).HasMaxLength(12);
            this.Property(p => p.PaymentTypeName).HasMaxLength(30);
            this.Property(p => p.Description).HasMaxLength(200);


            this.ToTable("PaymentTypes");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.PaymentTypeCode).HasColumnName("PaymentTypeCode");
            this.Property(p => p.PaymentTypeName).HasColumnName("PaymentTypeName");
            this.Property(p => p.Description).HasColumnName("Description");
        }
    }
}
