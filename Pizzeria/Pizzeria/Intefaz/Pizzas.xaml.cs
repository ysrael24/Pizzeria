using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pizzeria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pizzas : ContentPage
    {

        public List<Productos> pizzas1 { get; set; }
        public static List<ProductoCarro> EnvioCarrito = new List<ProductoCarro>();
        public bool IsAddToCartEnabled => txtCan.Equals("0");

        int cantidad = 0;
        public Pizzas()
        {
            InitializeComponent();
            pizzas1 = Pizza.listaPizza;
            carusel1.ItemsSource = pizzas1;
            BindingContext = this;
        }

        private void btnIzquierda_Clicked(object sender, EventArgs e)
        {
            cantidad = 0;
            txtCan.Text = cantidad.ToString();
            btnCarrito.IsEnabled = false;
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
            btnCarrito.IsEnabled = false;
            if (carusel1.Position < pizzas1.Count - 1)
            {
                carusel1.Position++;
            }
            else
            {
                carusel1.Position = 0;
            }
        }

        private void btnMenos_Clicked(object sender, EventArgs e)
        {
            if (cantidad > 0)
            {
                cantidad = cantidad - 1;
                if (cantidad == 0)
                {
                    txtCan.Text = cantidad.ToString();
                    btnCarrito.IsEnabled = false;
                }
                else
                {
                    btnCarrito.IsEnabled = true;
                    txtCan.Text = cantidad.ToString();
                }

            }
            else
            {
                txtCan.Text = "0";
                btnCarrito.IsEnabled = false;
            }
        }

        private void btnMas_Clicked(object sender, EventArgs e)
        {
            cantidad++;
            txtCan.Text = cantidad.ToString();
            btnCarrito.IsEnabled = true;
        }

        private async void btnCarrito_Clicked(object sender, EventArgs e)
        {
            if (cantidad == 0)
            {
                await DisplayAlert("Error", "La cantidad ingresada no es valida", "OK");
            }
            else
            {
                var lapizza = pizzas1[carusel1.Position];
                // Crear el objeto ProductoCarro con los datos de la pizza y la cantidad seleccionada
                var pedido = new ProductoCarro
                {
                    Nombre = lapizza.Nombre,
                    Precio = lapizza.Precio,
                    Cantidad = cantidad,
                    Total = cantidad * lapizza.Precio,
                    Imagen = lapizza.Imagen
                };

                // Agregar el pedido a la lista "EnvioCarrito"
                EnvioCarrito.Add(pedido);

                // Mostrar un mensaje de confirmación
                await DisplayAlert("Confirmacion", "El producto se envio", "OK");
            }

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            cantidad = 0;
            txtCan.Text = cantidad.ToString();
            btnCarrito.IsEnabled = false;
        }

    }
}