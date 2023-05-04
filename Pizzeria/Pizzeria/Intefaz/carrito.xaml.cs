using Pizzeria.Intefaz;
using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzeria
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class carrito : ContentPage
	{
        public static List<ProductoCarro> todasLasListas = new List<ProductoCarro>();
        decimal sumatotal = 0;
        public carrito()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Objeto representa el tipo de elemento de la lista
           // Objeto representa el tipo de elemento de la lista
            todasLasListas.AddRange(Pizzas.EnvioCarrito);
            todasLasListas.AddRange(bebidas.EnvioCarrito);
            todasLasListas.AddRange(cocteles.EnvioCarrito);
            listaCompra.ItemsSource = null;
            listaCompra.ItemsSource = todasLasListas;
            sumatotal = todasLasListas.Sum(p => p.Total);
            txtTotal.Text = sumatotal.ToString();
            bebidas.EnvioCarrito.Clear();
            Pizzas.EnvioCarrito.Clear();
            cocteles.EnvioCarrito.Clear();

        }

        private async void btncompra_Clicked(object sender, EventArgs e)
        {
            var pago = new pagos();
            pago.PasarSuma = sumatotal;
            await Navigation.PushAsync(pago);

        }
        
        private void btnaliminar_Clicked(object sender, EventArgs e)
        {
            var producto = (ProductoCarro)((ImageButton)sender).CommandParameter;
            todasLasListas.Remove(producto);
            sumatotal = todasLasListas.Sum(p => p.Total);
            txtTotal.Text = sumatotal.ToString();
            OnAppearing();
        }
    }
}
