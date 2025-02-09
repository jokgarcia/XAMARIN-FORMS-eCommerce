﻿using Android.Content;
using eCommerce.Mobile.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace eCommerce.Mobile
{
    public partial class App : Application
    {
        static ECommerceDataLayer database;

        public static ECommerceDataLayer Database
        {
            get
            {
                if (database == null)
                {
                    Context context = Android.App.Application.Context;
                    var filePath = context.GetExternalFilesDir("");

                    database = new ECommerceDataLayer(Path.Combine(filePath.ToString(), "ecommerce.db3"));

                    //database = new ECommerceDataLayer(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ecommerce.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
