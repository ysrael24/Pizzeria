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
	public partial class cocteles : ContentPage
	{
        Int32 cantidad = 0;
        public static List<ProductoCarro> EnvioCarrito = new List<ProductoCarro>();
        public List<Cocteles> cocteles1 { get; set; }
        public bool IsAddToCartEnabled => txtCan.Equals("0");
        public cocteles ()
		{
			InitializeComponent ();
            cocteles1 = Coctel.listaCoctel;
            carusel1.ItemsSource = cocteles1;
            BindingContext = this;
        }

        private void btnMenos_Clicked(object sender, EventArgs e)
        {
            if (cantidad > 0)
            {
                cantidad = cantidad - 1;
                if (cantidad == 0)
                {
                    txtCan.Text = cantidad.ToString();
                    btnAgregarCarrito.IsEnabled = false;
                }
                else
                {
                    btnAgregarCarrito.IsEnabled = true;
                    txtCan.Text = cantidad.ToString();
                }

            }
            else
            {
                txtCan.Text = "0";
                btnAgregarCarrito.IsEnabled = false;
            }
        }

        private void btnMas_Clicked(object sender, EventArgs e)
        {
            cantidad++;
            txtCan.Text = cantidad.ToString();
            btnAgregarCarrito.IsEnabled = true;
        }

        private void btnDerecha_Clicked(object sender, EventArgs e)
        {
            cantidad = 0;
            txtCan.Text = cantidad.ToString();
            btnAgregarCarrito.IsEnabled = false;
            if (carusel1.Position < cocteles1.Count - 1)
            {
                carusel1.Position++;
            }
            else
            {
                carusel1.Position = 0;
            }
        }

        private void btnIzquierda_Clicked(object sender, EventArgs e)
        {
            cantidad = 0;
            txtCan.Text = cantidad.ToString();
            btnAgregarCarrito.IsEnabled = false;
            if (carusel1.Position > 0)
            {
                carusel1.Position--;

            }
            else
            {
                carusel1.Position = 3;
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cantidad = 0;
            txtCan.Text = cantidad.ToString();
            btnAgregarCarrito.IsEnabled = false;
        }

        private async void btnAgregarCarrito_Clicked(object sender, EventArgs e)
        {
            if (cantidad == 0)
            {
                await DisplayAlert("Error", "La cantidad ingresada no es valida", "OK");
            }
            else
            {
                var coctel1 = cocteles1[carusel1.Position];
                var pedido = new ProductoCarro
                {
                    Nombre = coctel1.Nombre,
                    Precio = coctel1.Precio,
                    Cantidad = cantidad,
                    Imagen = coctel1.Imagen,
                    Total = cantidad * coctel1.Precio
                };
                EnvioCarrito.Add(pedido);
                await DisplayAlert("Confirmacion", "El producto se envio", "OK");
            }
        }
    }
}