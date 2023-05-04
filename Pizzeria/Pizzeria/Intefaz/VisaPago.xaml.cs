using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzeria.Intefaz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisaPago : ContentPage
    {
        public decimal SumTotal { get; set; }
        public VisaPago()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            txtSuma.Text = SumTotal.ToString();

        }
        private async void Pagar_clicked (object sender, EventArgs e)
        {
            if (NroTarjeta.Text == null & enNomTitular.Text == null & enFechExp.Text == null & enCVC.Text == null)
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