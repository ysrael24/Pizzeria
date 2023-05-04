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
	public partial class inicio : ContentPage
	{
		public inicio ()
		{
			InitializeComponent ();
		}
        private async void btnAcceso_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new principal());
        }
    }
}