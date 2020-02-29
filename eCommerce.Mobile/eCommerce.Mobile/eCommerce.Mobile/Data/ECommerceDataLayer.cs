using eCommerce.Mobile.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eCommerce.Mobile.Data
{
    public class ECommerceDataLayer
    {
        readonly SQLiteAsyncConnection _database;

        //Constructor
        public ECommerceDataLayer(string dbPath) 
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Category>().Wait();
        }

        /// <summary>
        /// CREATE
        /// </summary>
        /// <param name="category">Category Model</param>
        /// <returns>Next Id Number</returns>
        public Task<int> SaveCategoryAsync(Category category)
        {
            return _database.InsertAsync(category);
        }

        /// <summary>
        /// RETRIEVE
        /// </summary>
        /// <returns></returns>
        public Task<List<Category>> GetCategoryAsync()
        {
            return _database.Table <Category > ().ToListAsync();
        }

       
    }
}
