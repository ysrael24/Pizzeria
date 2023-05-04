using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pizzeria.Models;

namespace Pizzeria.Intefaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaypalPago : ContentPage
    {
        public decimal SumTotal { get; set; }
        public PaypalPago()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            txtSuma.Text = SumTotal.ToString();

        }

        private async void Pagar_clicked(object sender, EventArgs e)
        {
            if (txtCorreo.Text == null & TxtContrasena.Text == null)
            {
                await DisplayAlert("Error", "Ingrese credenciales", "OK");
            }
            else
            {
                await DisplayAlert("Success", "Su compra fue realizada con exito", "OK");
                carrito.todasLasListas.Clear();       
                await Navigation.PushAsync(new principal());
            }

        }
    }
}