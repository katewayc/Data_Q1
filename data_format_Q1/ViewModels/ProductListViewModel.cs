using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace data_format_Q1.ViewModels
{
    public class ProductListViewModel
    {
       [Display(Name = "Date")]
        public string Date1 { get; set; }

        [Display(Name = "ProductName")]
        public string Product_Name { get; set; }

        [Display(Name = "Price")]
        public string Price { get; set; }

        [Display(Name = "PromotePrice")]
        public string Promote_Price { get; set; }
    }
}