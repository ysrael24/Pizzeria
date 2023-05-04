using Pizzeria.Models;
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
    public partial class pagos : ContentPage
    {
        public decimal PasarSuma { get; set; }
        public pagos()
        {
            InitializeComponent();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private async void btnVisa_Clicked(object sender, EventArgs e)
        {
            var Visa = new VisaPago();
            Visa.SumTotal = PasarSuma;
            await Navigation.PushAsync(Visa);
        }

        private async void btnMaster_Clicked(object sender, EventArgs e)
        {
            var Master = new MasterPago();
            Master.SumTotal = PasarSuma;
            await Navigation.PushAsync(Master);
        }

        private async void btnPaypal_Clicked(object sender, EventArgs e)
        {
            var Paypal = new PaypalPago();
            Paypal.SumTotal = PasarSuma;
            await Navigation.PushAsync(Paypal);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            txtSuma.Text = PasarSuma.ToString();

        }
    }
}