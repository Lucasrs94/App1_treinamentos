using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_treinamentos.Tipo_Pagina.Carrossel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
            

        }
        private void MudarPagina(object sender, EventArgs args)
        {
            // Significar para ir proxima paginas
            App.Current.MainPage = new NavigationPage(new Navegtaion.Navegation1());
        }
    }
}