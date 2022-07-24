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
    public class StockMap : EntityTypeConfiguration<Stock>
    {
        public StockMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StockCode).HasMaxLength(12);
            this.Property(p => p.StockName).HasMaxLength(50);
            this.Property(p => p.Barcode).HasMaxLength(20);
            this.Property(p => p.BarcodeType).HasMaxLength(15);
            this.Property(p => p.SKU).HasMaxLength(15);
            this.Property(p => p.StockGroup).HasMaxLength(30);
            this.Property(p => p.StockSubGroup).HasMaxLength(30);
            this.Property(p => p.Brand).HasMaxLength(30);
            this.Property(p => p.Model).HasMaxLength(30);
            this.Property(p => p.SpecialCode1).HasMaxLength(30);
            this.Property(p => p.SpecialCode2).HasMaxLength(30);
            this.Property(p => p.SpecialCode3).HasMaxLength(30);
            this.Property(p => p.MaintenancePeriod).HasMaxLength(15);
            this.Property(p => p.ManufacturerCode).HasMaxLength(30);
            this.Property(p => p.PurchasePrice1).HasPrecision(12, 2);
            this.Property(p => p.PurchasePrice2).HasPrecision(12, 2);
            this.Property(p => p.PurchasePrice3).HasPrecision(12, 2);
            this.Property(p => p.SalePrice1).HasPrecision(12, 2);
            this.Property(p => p.SalePrice2).HasPrecision(12, 2);
            this.Property(p => p.SalePrice3).HasPrecision(12, 2);
            this.Property(p => p.MinStockQty).HasPrecision(12, 3);
            this.Property(p => p.MaxStockQty).HasPrecision(12, 3);
            this.Property(p => p.Description).HasMaxLength(200);


            this.ToTable("Stocks");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.Status).HasColumnName("Status");
            this.Property(p => p.StockCode).HasColumnName("StockCode");
            this.Property(p => p.StockName).HasColumnName("StockName");
            this.Property(p => p.Barcode).HasColumnName("Barcode");
            this.Property(p => p.BarcodeType).HasColumnName("BarcodeType");
            this.Property(p => p.SKU).HasColumnName("SKU");
            this.Property(p => p.StockGroup).HasColumnName("StockGroup");
            this.Property(p => p.StockSubGroup).HasColumnName("StockSubGroup");
            this.Property(p => p.Brand).HasColumnName("Brand");
            this.Property(p => p.Model).HasColumnName("Model");
            this.Property(p => p.SpecialCode1).HasColumnName("SpecialCode1");
            this.Property(p => p.SpecialCode2).HasColumnName("SpecialCode2");
            this.Property(p => p.SpecialCode3).HasColumnName("SpecialCode3");
            this.Property(p => p.SpecialCode4).HasColumnName("SpecialCode4");
            this.Property(p => p.MaintenancePeriod).HasColumnName("MaintenancePeriod");
            this.Property(p => p.ManufacturerCode).HasColumnName("ManufacturerCode");
            this.Property(p => p.BuyVat).HasColumnName("BuyVat");
            this.Property(p => p.SalesVat).HasColumnName("SalesVat");
            this.Property(p => p.PurchasePrice1).HasColumnName("PurchasePrice1");
            this.Property(p => p.PurchasePrice2).HasColumnName("PurchasePrice2");
            this.Property(p => p.PurchasePrice3).HasColumnName("PurchasePrice3");
            this.Property(p => p.SalePrice1).HasColumnName("SalePrice1");
            this.Property(p => p.SalePrice2).HasColumnName("SalePrice2");
            this.Property(p => p.SalePrice3).HasColumnName("SalePrice3");
            this.Property(p => p.MinStockQty).HasColumnName("MinStockQty");
            this.Property(p => p.MaxStockQty).HasColumnName("MaxStockQty");
            this.Property(p => p.Description).HasColumnName("Description");

        }
    }
}
