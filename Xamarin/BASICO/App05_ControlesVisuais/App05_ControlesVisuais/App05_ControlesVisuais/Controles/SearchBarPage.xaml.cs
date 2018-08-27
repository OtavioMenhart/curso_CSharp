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
	public partial class SearchBarPage : ContentPage
	{
        private List<String> empresasTI;

		public SearchBarPage ()
		{
			InitializeComponent ();

            empresasTI = new List<string>();
            empresasTI.Add("Microsoft");
            empresasTI.Add("Apple");
            empresasTI.Add("Oracle");
            empresasTI.Add("IBM");

            Preencher(empresasTI);
		}

        private void Pesquisar(object sender, EventArgs args)
        {
           var resultado = empresasTI.Where(a => a.Contains(((SearchBar)sender).Text)).ToList<String>();
           Preencher(resultado);
        }

        private void Preencher(List<String> empresasTI)
        {
            listResult.Children.Clear();
            foreach (var emp in empresasTI)
            {
                listResult.Children.Add(new Label { Text = emp });
            }
        }
	}
}