using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_treinamentos.Tipo_Pagina.Navegtaion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navegation1 : ContentPage
    {
        public Navegation1()
        {
            InitializeComponent();
        }
        private void Mudapg2(object sender, EventArgs args)
        {
            //para irmos para pagina seguinte
            Navigation.PushAsync(new Navegation2() {BackgroundColor = Color.Blue});


        }
    }
}