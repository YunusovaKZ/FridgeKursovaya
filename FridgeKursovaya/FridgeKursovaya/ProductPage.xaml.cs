using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FridgeKursovaya
{
    
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            ShowRecipe();
        }

        void ShowRecipe()
        {
            productCollection.ItemsSource = App.Pro.GetProduct();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddProduct());

        }

        private async void btnUpdate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UpdateProduct());
        }
    }
}