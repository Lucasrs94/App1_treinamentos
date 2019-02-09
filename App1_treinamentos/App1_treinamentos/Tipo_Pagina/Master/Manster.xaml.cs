using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_treinamentos.Tipo_Pagina.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Manster : MasterDetailPage
	{
		public Manster ()
		{
			InitializeComponent ();
		}
        private void MudarPagina1(object senser,EventArgs args)
        {
            Detail = new Navegtaion.Navegation1();

        }
        private void MudarPagina2(object senser, EventArgs args)
        {

            Detail = new Navegtaion.Navegation2();
        }
        private void MudarPagina3(object senser, EventArgs args)
        {

            Detail = new Conteudo();

        }


    }
}