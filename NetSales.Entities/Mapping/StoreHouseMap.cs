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
    public class StoreHouseMap : EntityTypeConfiguration<StoreHouse>
    {
        public StoreHouseMap()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.StoreHouseCode).HasMaxLength(12);
            this.Property(p => p.StoreHouseName).HasMaxLength(30);
            this.Property(p => p.ContactCode).HasMaxLength(12);
            this.Property(p => p.ContactName).HasMaxLength(50);
            this.Property(p => p.City).HasMaxLength(20);
            this.Property(p => p.County).HasMaxLength(20);
            this.Property(p => p.District).HasMaxLength(20);
            this.Property(p => p.Address).HasMaxLength(100);
            this.Property(p => p.Phone).HasMaxLength(20); 
            this.Property(p => p.Description).HasMaxLength(200);

            this.ToTable("StoreHouses");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.StoreHouseCode).HasColumnName("StoreHouseCode");
            this.Property(p => p.StoreHouseName).HasColumnName("StoreHouseName");
            this.Property(p => p.ContactCode).HasColumnName("ContactCode");
            this.Property(p => p.ContactName).HasColumnName("ContactName");
            this.Property(p => p.City).HasColumnName("City");
            this.Property(p => p.County).HasColumnName("County");
            this.Property(p => p.District).HasColumnName("District");
            this.Property(p => p.Address).HasColumnName("Address");
            this.Property(p => p.Phone).HasColumnName("Phone");
            this.Property(p => p.Description).HasColumnName("Description");
        }
    }
}
