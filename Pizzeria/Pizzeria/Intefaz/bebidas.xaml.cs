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
	public partial class bebidas : ContentPage
	{
        Int32 cantidad = 0;
        public static List<ProductoCarro> EnvioCarrito = new List<ProductoCarro>();
        public List<Bebidas> bebidas1 {  get; set; }
        public bool IsAddToCartEnabled => txtCan.Equals("0");
        public bebidas()
        {
            InitializeComponent();
            bebidas1 = bebida.listBebidas;
            carusel1.ItemsSource = bebidas1;
            BindingContext = this;

        }

        private void btnMas_Clicked(object sender, EventArgs e)
        {
            cantidad++;
            txtCan.Text = cantidad.ToString();
            btnAgregarCarrito.IsEnabled = true;
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

        private void btnDerecha_Clicked(object sender, EventArgs e)
        {
            cantidad = 0;
            txtCan.Text = cantidad.ToString();
            btnAgregarCarrito.IsEnabled = false;
            if (carusel1.Position < bebidas1.Count - 1)
            {
                carusel1.Position++;
            }
            else
            {
                carusel1.Position = 0;
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
                var beber = bebidas1[carusel1.Position];
                var pedido = new ProductoCarro
                {
                    Nombre = beber.Nombre,
                    Precio = beber.Precio,
                    Cantidad = cantidad,
                    Imagen = beber.Imagen,
                    Total = cantidad * beber.Precio,
                };
                EnvioCarrito.Add(pedido);
                await DisplayAlert("Confirmacion", "El producto se envio", "OK");
            }
        }
    }
}