using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace data_format_Q1.Models
{
    public class Product
    {
        public DateTime Date1 { get; set; }
        public string Locale { get; set; }
        public string Product_Name { get; set; }
        public decimal Price { get; set; }
        public string Promote_Price { get; set; }
    }
}