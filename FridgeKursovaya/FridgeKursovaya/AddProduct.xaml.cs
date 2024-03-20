using FridgeKursovaya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FridgeKursovaya
{
    
    public partial class AddProduct : ContentPage
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            string name = entName.Text.Trim();
            string callor = entCallor.Text.Trim();
            string date = entDate.Text.Trim();
            Product product = new Product
            {
                Name = name,
                Callor = Convert.ToInt32(callor),
                dateTime = date,
            };
            App.Pro.SaveProduct(product);

            entName.Text = " ";
            entCallor.Text = " ";
            entDate.Text = " ";
        }
    }
}