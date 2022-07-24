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
    public class StockMovementMap: EntityTypeConfiguration<StockMovement>
    {
        public StockMovementMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.InvoiceNumber).HasMaxLength(12);
            this.Property(p => p.Movement).HasMaxLength(10);
            this.Property(p => p.StockCode).HasMaxLength(12);
            this.Property(p => p.StockName).HasMaxLength(50);
            this.Property(p => p.BarcodeType).HasMaxLength(15);
            this.Property(p => p.Barcode).HasMaxLength(20);
            this.Property(p => p.SKU).HasMaxLength(15);
            this.Property(p => p.Quantity).HasPrecision(12, 3);
            this.Property(p => p.UnitPrice).HasPrecision(12, 2);
            this.Property(p => p.DiscountRate).HasPrecision(5, 2);
            this.Property(p => p.DiscountTotal).HasPrecision(12, 2);
            this.Property(p => p.TotalAmount).HasPrecision(12, 2);
            this.Property(p => p.StoreHouseCode).HasMaxLength(12);
            this.Property(p => p.StoreHouseName).HasMaxLength(30);
            this.Property(p => p.SerialNumber).HasMaxLength(200);
            this.Property(p => p.Description).HasMaxLength(200);


            this.ToTable("StockMovements");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.InvoiceNumber).HasColumnName("InvoiceNumber");
            this.Property(p => p.Movement).HasColumnName("Movement");
            this.Property(p => p.StockCode).HasColumnName("StockCode");
            this.Property(p => p.StockName).HasColumnName("StockName");
            this.Property(p => p.BarcodeType).HasColumnName("BarcodeType");
            this.Property(p => p.Barcode).HasColumnName("Barcode");
            this.Property(p => p.SKU).HasColumnName("SKU");
            this.Property(p => p.Quantity).HasColumnName("Quantity");
            this.Property(p => p.Vat).HasColumnName("Vat");
            this.Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            this.Property(p => p.DiscountRate).HasColumnName("DiscountRate");
            this.Property(p => p.DiscountTotal).HasColumnName("DiscountTotal");
            this.Property(p => p.TotalAmount).HasColumnName("TotalAmount");
            this.Property(p => p.StoreHouseCode).HasColumnName("StoreHouseCode");
            this.Property(p => p.StoreHouseName).HasColumnName("StoreHouseName");
            this.Property(p => p.SerialNumber).HasColumnName("SerialNumber");
            this.Property(p => p.DateTime).HasColumnName("DateTime");
            this.Property(p => p.Description).HasColumnName("Description");
        }
    }
}
