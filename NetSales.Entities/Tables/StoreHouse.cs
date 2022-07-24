using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSales.Entities.Tables
{
    public class StoreHouse
    {
        public int ID { get; set; }
        public string StoreHouseCode { get; set; }
        public string StoreHouseName { get; set; }
        public string ContactCode { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
