﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_treinamentos
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class pagina1 : ContentView
	{
		public pagina1 ()
		{
			InitializeComponent ();

            new Label();

		}
	}
}