using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FridgeKursovaya.Models;
using Xamarin.Forms;
using static Xamarin.Forms.Internals.GIFBitmap;

namespace FridgeKursovaya
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ShowRecipe();
        }

        void ShowRecipe()
        {
            recipeCollection.ItemsSource = App.Db.GetRecipe();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recept());

        }

        private async void btnUpdate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recept());
        }

        private async void btnRecipe_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void btnProduct_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductPage());
        }

        private async void btnAkkaunt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recept());
        }
    }
}
