using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Tables
{
    public class StockMovement
    {
        public int ID { get; set; }
        public string InvoiceNumber { get; set; }
        public string Movement { get; set; }
        public string StockCode { get; set; }
        public string StockName { get; set; }
        public string BarcodeType { get; set; }
        public string Barcode { get; set; }
        public string SKU { get; set; }
        public decimal Quantity { get; set; }
        public int Vat { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public string StoreHouseCode { get; set; }
        public string StoreHouseName { get; set; }
        public string SerialNumber { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
    }
}
