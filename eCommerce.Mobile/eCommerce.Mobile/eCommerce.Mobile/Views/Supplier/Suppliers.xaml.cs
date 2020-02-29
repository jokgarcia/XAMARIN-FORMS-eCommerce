using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eCommerce.Mobile.Views.Supplier
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Suppliers : ContentPage
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        private async void btnSaveSupplier_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSuppName.Text))
            {
                await App.Database.SaveSupplierAsync(new Models.Supplier
                {
                    SupplierName = txtSuppName.Text,
                    SupplierAddress = txtAddress.Text
                });
            }

            listViewCategory.ItemsSource = await App.Database.GetSupplierAsync();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewCategory.ItemsSource = await App.Database.GetSupplierAsync();
        }
    }
}