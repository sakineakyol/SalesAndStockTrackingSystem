using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Tables
{
    public class CashTransaction //Kasa Hareketleri
    {
        public int ID { get; set; }
        public string InvoiceCode { get; set; }
        public string Movement { get; set; }
        public string CashCode { get; set; }
        public string CashName { get; set; }
        public string PaymentTypeCode { get; set; }
        public string PaymentTypeName { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public DateTime DateTime { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}
