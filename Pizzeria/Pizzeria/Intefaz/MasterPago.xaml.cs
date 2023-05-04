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
    public partial class MasterPago : ContentPage
    {
        public decimal SumTotal { get; set; }
        public MasterPago()
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
            if (NroTarjeta.Text == null & enMes.Text == null & enAño.Text == null & enCVC.Text == null & enNomTitular.Text == null)
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