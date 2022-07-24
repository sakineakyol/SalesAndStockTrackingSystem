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
    public class CurrentMap: EntityTypeConfiguration<Current>
    {
        public CurrentMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.CurrentType).HasMaxLength(15);
            this.Property(p => p.CurrentCode).HasMaxLength(12);
            this.Property(p => p.CurrentName).HasMaxLength(50);
            this.Property(p => p.ContactName).HasMaxLength(50);
            this.Property(p => p.InvoiceTitle).HasMaxLength(50);
            this.Property(p => p.MobilePhoneNumber).HasMaxLength(20);
            this.Property(p => p.PhoneNumber).HasMaxLength(20);
            this.Property(p => p.Fax).HasMaxLength(20);
            this.Property(p => p.Email).HasMaxLength(50);
            this.Property(p => p.Web).HasMaxLength(50);
            this.Property(p => p.City).HasMaxLength(20);
            this.Property(p => p.County).HasMaxLength(20);
            this.Property(p => p.District).HasMaxLength(20);
            this.Property(p => p.Address).HasMaxLength(20);
            this.Property(p => p.CurrentGroup).HasMaxLength(30);
            this.Property(p => p.CurrentSubGroup).HasMaxLength(30);
            this.Property(p => p.CurrentSpecialCode1).HasMaxLength(30);
            this.Property(p => p.CurrentSpecialCode2).HasMaxLength(30);
            this.Property(p => p.CurrentSpecialCode3).HasMaxLength(30);
            this.Property(p => p.CurrentSpecialCode4).HasMaxLength(30);
            this.Property(p => p.TaxOffice).HasMaxLength(30);
            this.Property(p => p.TaxNumber).HasMaxLength(30);
            this.Property(p => p.DiscountRate).HasPrecision(5, 2);
            this.Property(p => p.Exposure).HasPrecision(12, 2);
            this.Property(p => p.PurchaseSpecialPrice).HasMaxLength(15);
            this.Property(p => p.SaleSpecialPrice).HasMaxLength(15);
            this.Property(p => p.Description).HasMaxLength(200);


            this.ToTable("Currents");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.Status).HasColumnName("Status");
            this.Property(p => p.CurrentType).HasColumnName("CurrentType");
            this.Property(p => p.CurrentCode).HasColumnName("CurrentCode");
            this.Property(p => p.CurrentName).HasColumnName("CurrentName");
            this.Property(p => p.ContactName).HasColumnName("ContactName");
            this.Property(p => p.InvoiceTitle).HasColumnName("InvoiceTitle");
            this.Property(p => p.MobilePhoneNumber).HasColumnName("MobilePhoneNumber");
            this.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(p => p.Fax).HasColumnName("Fax");
            this.Property(p => p.Email).HasColumnName("Email");
            this.Property(p => p.Web).HasColumnName("Web");
            this.Property(p => p.City).HasColumnName("City");
            this.Property(p => p.County).HasColumnName("County");
            this.Property(p => p.District).HasColumnName("District");
            this.Property(p => p.Address).HasColumnName("Address");
            this.Property(p => p.CurrentGroup).HasColumnName("CurrentGroup");
            this.Property(p => p.CurrentSubGroup).HasColumnName("CurrentSubGroup");
            this.Property(p => p.CurrentSpecialCode1).HasColumnName("CurrentSpecialCode1");
            this.Property(p => p.CurrentSpecialCode2).HasColumnName("CurrentSpecialCode2");
            this.Property(p => p.CurrentSpecialCode3).HasColumnName("CurrentSpecialCode3");
            this.Property(p => p.CurrentSpecialCode4).HasColumnName("CurrentSpecialCode4");
            this.Property(p => p.TaxOffice).HasColumnName("TaxOffice");
            this.Property(p => p.TaxNumber).HasColumnName("TaxNumber");
            this.Property(p => p.DiscountRate).HasColumnName("DiscountRate");
            this.Property(p => p.Exposure).HasColumnName("Exposure");
            this.Property(p => p.PurchaseSpecialPrice).HasColumnName("PurchaseSpecialPrice");
            this.Property(p => p.SaleSpecialPrice).HasColumnName("SaleSpecialPrice");
            this.Property(p => p.Description).HasColumnName("Description");
        }
    }
}
