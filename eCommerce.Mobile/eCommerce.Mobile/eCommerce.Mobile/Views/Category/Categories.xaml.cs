using eCommerce.Mobile.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eCommerce.Mobile.View.Category
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Categories : ContentPage
    {
        public Categories()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listViewCategory.ItemsSource = await App.Database.GetCategoryAsync();
        }


      
        async void btnSaveCategory_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCatName.Text)) 
            {
                await App.Database.SaveCategoryAsync(new Models.Category
                {
                    CategoryName = txtCatName.Text,
                    CategoryDescription = txtCatDesc.Text
                });
            }

            listViewCategory.ItemsSource = await App.Database.GetCategoryAsync();
        }

        private void btnMain_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new MainPage()));
        }
    }
}