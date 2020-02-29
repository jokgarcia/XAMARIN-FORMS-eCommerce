using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Mobile.Models
{
    public class Supplier
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string SupplierName { get; set; }

        public string SupplierAddress { get; set; }
    }
}
