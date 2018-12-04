using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_treinamentos.Tipo_Pagina.Tabt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();
            //Childreem adiciona as paginas filhas  
            Children.Add(new NavigationPage(new Tipo_Pagina.Navegtaion.Navegation1()) { Title="Item 3"});
        }
    }
}