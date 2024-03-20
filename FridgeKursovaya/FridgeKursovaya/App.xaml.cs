using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using FridgeKursovaya.Models;

namespace FridgeKursovaya
{
    public partial class App : Application
    {

        private static BD db;

        public static BD Db
        {
            get
            {
                if (db == null)
                {
                    db = new BD(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "db.sqlite3"));
                }
                return db;
            }
        }

        private static ProductDB pro;

        public static ProductDB Pro
        {
            get
            {
                if (pro == null)
                {
                    pro = new ProductDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "pro.sqlite3"));
                }
                return pro;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
