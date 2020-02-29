using eCommerce.Mobile.View.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eCommerce.Mobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCategory_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NavigationPage(new Categories()));
        }

        private void btnProduct_Clicked(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Clicked(object sender, EventArgs e)
        {

        }

        private void btnSeller_Clicked(object sender, EventArgs e)
        {

        }

        private void btnSupplier_Clicked(object sender, EventArgs e)
        {

        }

        private void btnBrand_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDelivery_Clicked(object sender, EventArgs e)
        {

        }
    }
}
