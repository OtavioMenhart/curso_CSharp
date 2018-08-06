using App11_ProjVagas.Banco;
using App11_ProjVagas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App11_ProjVagas.Paginas
{
    
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ConsultaVagas : ContentPage
	{
        List<Vaga> Lista { get; set; }

        public ConsultaVagas ()
		{
			InitializeComponent ();
            Database db = new Database();
            Lista = db.Consultar();
            
            ListaVagas.ItemsSource = Lista;
            lblCount.Text = Lista.Count.ToString();

        }

        private void GoCadastro(object sender, ClickedEventArgs args)
        {
            Navigation.PushAsync(new CadastrarVaga());
        }

        private void GoMinhasVagas(object sender, ClickedEventArgs args)
        {
            Navigation.PushAsync(new MinhasVagasCadastradas());
        }

        private void MaisDetalheAction(object sender, EventArgs args)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;
            Navigation.PushAsync(new DetalheVaga(vaga));
        }

        private void PesquisarAction(object sender, TextChangedEventArgs args)
        {
            ListaVagas.ItemsSource = Lista.Where(a => a.NomeVaga.Contains(args.NewTextValue)).ToList();
        }
    }
}