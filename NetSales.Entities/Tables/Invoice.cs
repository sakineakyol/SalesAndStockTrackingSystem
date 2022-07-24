using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Tables
{
    public class Invoice
    {
        public int ID { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceType { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public string DocumentNo { get; set; }
        public DateTime DateTime { get; set; }
        public string SalesRepresentativeCode { get; set; }
        public string SalesRepresentativeName { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public string Description { get; set; }
    }
}
