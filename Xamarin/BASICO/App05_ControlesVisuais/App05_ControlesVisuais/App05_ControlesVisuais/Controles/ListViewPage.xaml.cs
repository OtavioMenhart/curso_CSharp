using App05_ControlesVisuais.Modelo;
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
	public partial class ListViewPage : ContentPage
	{
		public ListViewPage ()
		{
			InitializeComponent ();

            List<Pessoa> lista = new List<Pessoa>();
            lista.Add(new Pessoa { Nome = "Otávio", Idade = "20" });
            lista.Add(new Pessoa { Nome = "José", Idade = "22" });
            lista.Add(new Pessoa { Nome = "João", Idade = "18" });
            lista.Add(new Pessoa { Nome = "Paulo", Idade = "21" });
            lista.Add(new Pessoa { Nome = "Ricardo", Idade = "23" });
            lista.Add(new Pessoa { Nome = "Pedro", Idade = "21" });


            ListaPessoas.ItemsSource = lista;

        }
	}
}