using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Tables
{
    public class Cash
    {
        public int ID { get; set; }
        public string CashCode { get; set; }
        public string CashName { get; set; }
        public string ContactCode { get; set; }
        public string ContactName { get; set; }
        public string Description { get; set; }
    }
}
