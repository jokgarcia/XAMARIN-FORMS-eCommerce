using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Mobile.Models
{
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
