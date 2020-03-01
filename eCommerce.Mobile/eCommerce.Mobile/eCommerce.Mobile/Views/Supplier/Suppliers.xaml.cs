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
                    SupplierAddress = txtAddress.Text,
                    SupplierContactNo = txtContactNo.Text
                });
            }
            txtSuppName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            listViewCategory.ItemsSource = await App.Database.GetSupplierAsync();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewCategory.ItemsSource = await App.Database.GetSupplierAsync();
        }

        private async void listViewCategory_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            

            var selected = e.SelectedItem as Models.Supplier;

            if (!string.IsNullOrWhiteSpace(selected.SupplierContactNo))
            {
                await DisplayAlert("App", selected.SupplierName + " contact no. " + selected.SupplierContactNo, "OK");
            }
            else
            {
                await DisplayAlert("App", "No contact no.", "OK");
            }
            
        }

        private async void listViewCategory_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //await DisplayAlert("App", "Tapped " + listViewCategory.SelectedItem.ToString(), "OK");

        }
    }
}