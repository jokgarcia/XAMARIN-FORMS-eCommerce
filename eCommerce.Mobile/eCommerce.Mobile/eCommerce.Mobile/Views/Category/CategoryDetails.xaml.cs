using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eCommerce.Mobile.View.Category
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryDetails : ContentPage
    {
        public CategoryDetails(string CatName,string CatDesc)
        {
            InitializeComponent();
            //Clear Entries
            txtCatName.Text = "";
            txtCatDesc.Text = "";

            txtCatName.Text = CatName;
            txtCatDesc.Text = CatDesc;
        }

        async void btnUpdateCat_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCatName.Text))
            {
                await App.Database.UpdateCategoryAsync(new Models.Category
                {
                    CategoryName = txtCatName.Text,
                    CategoryDescription = txtCatDesc.Text
                });
            }
        }
    }
}