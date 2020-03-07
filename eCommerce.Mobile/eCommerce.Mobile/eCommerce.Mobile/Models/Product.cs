using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Mobile.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
