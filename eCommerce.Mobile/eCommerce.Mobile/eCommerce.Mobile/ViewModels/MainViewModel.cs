using eCommerce.Mobile.Models;
using eCommerce.Mobile.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eCommerce.Mobile.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private DataService _dataService = new DataService();
        private List<Product> _products;
        private bool _isRefreshing;


        public List<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        public ICommand RefreshCommand => new Command(async () =>
        {
            await GetProducts();
        });

        private async Task GetProducts()
        {
            IsRefreshing = true;

            Products = await _dataService.GetProducts();

            IsRefreshing = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
