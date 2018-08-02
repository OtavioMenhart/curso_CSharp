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
	public partial class Inicio : ContentPage
	{
		public Inicio ()
		{
			InitializeComponent ();
            DataHoje.Text = DateTime.UtcNow.DayOfWeek.ToString() + ", " + DateTime.UtcNow.ToString("dd/MM");

            CarregarTarefas();
		}
        public void ActionGoCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Cadastro());
        }

        private void CarregarTarefas()
        {
            SLTarefas.Children.Clear();
            List<Tarefa> Lista = new GerenciadorTarefa().Listagem();

            int i = 0;
            foreach (Tarefa tarefa in Lista)
            {
                LinhaStackLayout(tarefa, i);
                i++;
            }
        }

        public void LinhaStackLayout(Tarefa tarefa, int index)
        {
            Image imgDelete = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("Delete.png") };
            if (Device.RuntimePlatform == Device.UWP)
            {
                imgDelete.Source = ImageSource.FromFile("Resources/Delete.png");
            }
            TapGestureRecognizer deleteTap = new TapGestureRecognizer();
            deleteTap.Tapped += delegate
            {
                new GerenciadorTarefa().Deletar(index);
                CarregarTarefas();
            };
            imgDelete.GestureRecognizers.Add(deleteTap);


            Image imgPrioridade = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("p"+tarefa.Prioridade + ".png") };
            if (Device.RuntimePlatform == Device.UWP)
            {
                imgPrioridade.Source = ImageSource.FromFile("Resources/p" + tarefa.Prioridade + ".png");
            }

            View stackCentral = null;
            if(tarefa.DataFinalizacao == null)
            {
                stackCentral = new Label() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Text = tarefa.Nome };
            }
            else
            {
                stackCentral = new StackLayout() { VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.FillAndExpand, Spacing = 0 };
                ((StackLayout)stackCentral).Children.Add(new Label() { Text = tarefa.Nome, TextColor = Color.Gray });
                ((StackLayout)stackCentral).Children.Add(new Label() { Text = "Finalizado em " + tarefa.DataFinalizacao.Value.ToString("dd/MM/yyyy - hh:mm") + "h", TextColor = Color.Gray, FontSize = 10 });
            }

            

            Image check = new Image() { VerticalOptions = LayoutOptions.Center, Source = ImageSource.FromFile("CheckOff.png") };
            if(Device.RuntimePlatform == Device.UWP)
            {
                check.Source = ImageSource.FromFile("Resources/CheckOff.png");
            }

            if(tarefa.DataFinalizacao != null)
            {
                check.Source = ImageSource.FromFile("CheckOn.png");
                if (Device.RuntimePlatform == Device.UWP)
                {
                    check.Source = ImageSource.FromFile("Resources/CheckOn.png");
                }
            }

            TapGestureRecognizer checkTap = new TapGestureRecognizer();
            checkTap.Tapped += delegate
            {
                new GerenciadorTarefa().Finalizar(index, tarefa);
                
                CarregarTarefas();
            };
            check.GestureRecognizers.Add(checkTap);

            StackLayout linha = new StackLayout() { Orientation = StackOrientation.Horizontal, Spacing = 15 };
            linha.Children.Add(check);
            linha.Children.Add(stackCentral);
            linha.Children.Add(imgPrioridade);
            linha.Children.Add(imgDelete);

            SLTarefas.Children.Add(linha);
        }

    }
}