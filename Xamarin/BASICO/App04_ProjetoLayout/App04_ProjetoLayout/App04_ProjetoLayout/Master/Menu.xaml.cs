using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App04_ProjetoLayout.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        private void GoPaginaXamarin(object sender, EventArgs args)
        {
            IsPresented = false;
            Detail = new NavigationPage(new Pages.Xamarin());
        }

        private void GoPaginaPerfil1(object sender, EventArgs args)
        {
            IsPresented = false;
            Detail = new NavigationPage(new Pages.Perfil1());
        }

    }
}