using App06_Tarefa.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App06_Tarefa.Telas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Cadastro : ContentPage
	{
        private byte numPrioridade { get; set; }

		public Cadastro ()
		{
			InitializeComponent ();

		}

        public void PrioridadeSelectAction(object sender, EventArgs args)
        {
            var Stacks = SLPrioridades.Children;

            foreach (var linha in Stacks)
            {
                Label lblPrioridade = ((StackLayout)linha).Children[1] as Label;

                lblPrioridade.TextColor = Color.Gray;
            }
            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            FileImageSource source = ((Image)((StackLayout)sender).Children[0]).Source as FileImageSource;

            string prioridade = source.File.ToString().Replace("Resources/","").Replace(".png","").Replace("p","");

            numPrioridade = byte.Parse(prioridade);
        }

        public void SalvarAction(object sender, EventArgs args)
        {
            bool erroExiste = false;

            if(!(txtNome.Text.Trim().Length > 0))
            {
                erroExiste = true;
                DisplayAlert("ERRO", "Nome não preenchido", "OK");
            }

            if(!(numPrioridade > 0))
            {
                erroExiste = true;
                DisplayAlert("ERRO", "Prioridade não foi selecionada", "OK");
            }

            if(erroExiste == false)
            {
                //salva dados
                Tarefa tarefa = new Tarefa();
                tarefa.Nome = txtNome.Text.Trim();
                tarefa.Prioridade = numPrioridade;

                new GerenciadorTarefa().Salvar(tarefa);

                //forçando para criar uma nova página
                App.Current.MainPage = new NavigationPage(new Inicio());
            }
        }

    }
}