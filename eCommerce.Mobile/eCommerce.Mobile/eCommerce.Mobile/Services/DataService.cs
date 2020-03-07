using eCommerce.Mobile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Mobile.Services
{
    public class DataService
    {
        private string product_url = "https://localhost:44341/api/product";

        //CRUD
        
        public async Task<List<Product>> GetProducts()
        {
            var httpClient = new HttpClient();
            var rest_json = await httpClient.GetStringAsync(product_url);
            var data = JsonConvert.DeserializeObject<List<Product>>(rest_json);

            return data;
        }
    }
}
