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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var reg = new Personas
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellidos.Text,
                    CorreOnum = txtContacto.Text,
                    Dni = txtDni.Text,
                    Contraseña = txtPassword.Text
                };
                var respta = await App.contexto.ingresar(reg);
                if (respta == 1)
                {
                    //await DisplayAlert("Aviso", "se grabó los datos", "Aceptar");
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Aviso", "No se grabó los datos", "Aceptar");
                }
            }
            catch (Exception er)
            {
                await DisplayAlert("Aviso", er.Message, "Aceptar");
            }
        }
    }
}