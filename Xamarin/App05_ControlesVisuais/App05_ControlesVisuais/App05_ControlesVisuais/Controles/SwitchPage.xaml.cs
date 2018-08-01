using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControlesVisuais.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();
		}

        private void ActionTrocou(object sender, ToggledEventArgs args)
        {
            resultado.Text = DateTime.UtcNow.ToString("HH:mm") + " - " + args.Value;
        }

    }
}