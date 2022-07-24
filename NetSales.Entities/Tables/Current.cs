using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Tables
{
    public class Current
    {
        public int ID { get; set; }
        public bool Status { get; set; }
        public string CurrentType { get; set; }
        public string CurrentCode { get; set; }
        public string CurrentName { get; set; }
        public string ContactName { get; set; }
        public string InvoiceTitle { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string CurrentGroup { get; set; }
        public string CurrentSubGroup { get; set; }
        public string CurrentSpecialCode1 { get; set; }
        public string CurrentSpecialCode2 { get; set; }
        public string CurrentSpecialCode3 { get; set; }
        public string CurrentSpecialCode4 { get; set; }
        public string TaxOffice { get; set; }
        public string TaxNumber { get; set; }
        public decimal DiscountRate { get; set; }
        public decimal Exposure { get; set; }
        public string PurchaseSpecialPrice { get; set; }
        public string SaleSpecialPrice { get; set; }
        public string Description { get; set; }
    }
}
