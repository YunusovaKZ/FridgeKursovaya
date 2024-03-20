using FridgeKursovaya.Models;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FridgeKursovaya
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Recept : ContentPage
    {
        public Recept()
        {
            InitializeComponent();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            string name = entName.Text.Trim();
            string desc = entDesc.Text.Trim();
            string image = entImage.Text.Trim();

            if(name.Length< 5)
            {
                await DisplayAlert("Error", "Name min 5", "Ok");
                return;
            }
            else if(desc.Length<10)
            {
                await DisplayAlert("Error", "Desc min 10", "Ok");
                return;
            }
            else if (image.Length < 15)
            {
                await DisplayAlert("Error", "Image min 15", "Ok");
                return;
            }
            Recipe recipe = new Recipe
            {
                Name = name ,
                Desc = desc ,
                Image=image,
            };
            App.Db.SaveRecept(recipe);

            entName.Text = " ";
            entImage.Text = " ";
            entDesc.Text = " ";

        }
    }
}