using System;
using Xamarin.Forms;
using SQLite;
using Xamarin.Forms.Xaml;
using Pizzeria.Data;

namespace Pizzeria
{
    public partial class App : Application
    {
        public static DbContexto contexto { get; set; }
        public App()
        {
            InitializeComponent();

            crearBD();
            
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.FromHex("#FCFCFC"),
                BarTextColor = Color.Black,
                

            };
            
        }

        private void crearBD()
        {
            //la BD se crea en el proyecto
            var carpeta = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var data = System.IO.Path.Combine(carpeta, "DB_Pizza.db3");
            SQLitePCL.Batteries_V2.Init();
            contexto = new DbContexto(data);
        }


        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
