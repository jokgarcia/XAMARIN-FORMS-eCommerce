using ECommerce.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Web.DataLayer
{
    public class DatabaseSeeder
    {
        public static void Initialize(ECommerceContext context) 
        {
            context.Database.EnsureCreated();

            var category = new Category()
            {
                CategoryName = "Cellphone",
                CategoryDescription = "Mobile Phone"
            };

            context.Categories.Add(category);
            context.SaveChanges();

            var product = new Product()
            {
                SKU = "PR-1001",
                ProductName = "Samsung S10",
                Cost = 20000.99m,
                SellingPrice = 22000.50m
            };
            context.Products.Add(product);
            context.SaveChanges();
        }
    }
}
