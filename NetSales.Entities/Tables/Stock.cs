using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Tables
{
    public class Stock
    {
        public int ID { get; set; }
        public bool Status { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string Barcode { get; set; }
        public string BarcodeType { get; set; }
        public string SKU { get; set; }
        public string StockGroup { get; set; }
        public string StockSubGroup { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string SpecialCode4 { get; set; }
        public string MaintenancePeriod { get; set; }
        public string ManufacturerCode { get; set; }
        public int BuyVat { get; set; }
        public int SalesVat { get; set; }
        public decimal PurchasePrice1 { get; set; }
        public decimal PurchasePrice2 { get; set; }
        public decimal PurchasePrice3 { get; set; }
        public decimal SalePrice1 { get; set; }
        public decimal SalePrice2 { get; set; }
        public decimal SalePrice3 { get; set; }
        public decimal MinStockQty { get; set; }
        public decimal MaxStockQty { get; set; }
        public string Description { get; set; }

    }
}
