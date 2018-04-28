using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Pagina2 : ContentPage
	{
		public Pagina2 ()
		{
			InitializeComponent ();
            this.lbOpcion.Text = string.Empty;
            btnTres.Clicked += BtnTres_Clicked;
            btnTest.Clicked += BtnTest_Clicked;
		}

        private async void BtnTest_Clicked(object sender, EventArgs e)
        {
            this.lbOpcion.Text = string.Empty;
            var resp = await DisplayAlert("Test", "Esta seguro de realizar el test", "Si", "No");
            if (resp)
            {
                await DisplayAlert("Inicio del Test", "Super bienvenido", "Aceptar");
                var opcion = await DisplayActionSheet("Opciones",
                                                        "Cancelar",
                                                        null, "Opción 1", "Opción 2", "Opción3");
                lbOpcion.Text = opcion.ToString();
            }
            else
            {
                await DisplayAlert("Test Fallido", "En otra ocasión será", "Aceptar");
            }
        }

        private async void BtnTres_Clicked(object sender, EventArgs e)
        {

            this.lbOpcion.Text = string.Empty;
            await Navigation.PushAsync(new Page3());
        }
    }
}