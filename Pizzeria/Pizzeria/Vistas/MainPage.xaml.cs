using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Pizzeria.Models;
using Newtonsoft.Json;
using SQLite;

namespace Pizzeria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public bool verificarLogin(string Correo, string Contra)
        {
            string dbPath = App.contexto.cnx.DatabasePath;
            using (SQLiteConnection conn = new SQLiteConnection(dbPath))
            {
                conn.CreateTable<Personas>();
                var user = conn.Table<Personas>().FirstOrDefault(u => u.CorreOnum.ToLower() == Correo.ToLower() && u.Contraseña == Contra);
                if (user != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private async void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string Correo = txtEmail.Text;
            string Contra = txtContra.Text;
            bool isValid = verificarLogin(Correo, Contra);
            if (isValid)
            {
                await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");
                await Navigation.PushAsync(new inicio());
            }
            else
            {
                await DisplayAlert("Error", "Usuario O Contraseña Invalido", "OK");
            }
        }
        private async void btnRegister_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
        private async void btnRecuCuenta_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OlvidoContra());
        }
    }
}
