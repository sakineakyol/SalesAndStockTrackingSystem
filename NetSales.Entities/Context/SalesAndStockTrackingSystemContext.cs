using NetSales.Entities.Mapping;
using NetSales.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Context
{
    public class SalesAndStockTrackingSystemContext : DbContext
    {
        //Bir sınıfın context olduğunu velirlemek için o sınıfın DbContext'ten inherit edilmesi gerekli. using system.data.entity
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Current> Currents { get; set; }
        public DbSet<Cash> Cashes { get; set; }
        public DbSet<CashTransaction> CashTransactions { get; set; }
        public DbSet<Definition> Definitions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }
        public DbSet<StoreHouse> StoreHouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StockMap());
            modelBuilder.Configurations.Add(new CurrentMap());
            modelBuilder.Configurations.Add(new CashMap());
            modelBuilder.Configurations.Add(new CashTransactionMap());
            modelBuilder.Configurations.Add(new DefinitionMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new StockMovementMap());
            modelBuilder.Configurations.Add(new StoreHouseMap());
        }
    }
}
