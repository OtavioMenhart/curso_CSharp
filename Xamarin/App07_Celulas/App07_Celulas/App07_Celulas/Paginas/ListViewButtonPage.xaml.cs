using App07_Celulas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App07_Celulas.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListViewButtonPage : ContentPage
	{
		public ListViewButtonPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Otávio", Cargo = "Desenvolvedor" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente Vendas" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Marketing" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor" });

            ListaFuncionarios.ItemsSource = Lista;
        }

        private void FeriasAction(object sender, ClickedEventArgs args)
        {
            Button btnFerias = (Button)sender;
            Funcionario func = (Funcionario)btnFerias.CommandParameter;

            DisplayAlert("Férias", "Funcionário: " + func.Nome, "OK");
        }

    }
}