using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Web.Models
{
    public class Product : BaseClass
    {
        public string SKU { get; set; }
        public string ProductName { get; set; }
        public decimal Cost { get; set; }
        public decimal SellingPrice { get; set; }
    }
}
