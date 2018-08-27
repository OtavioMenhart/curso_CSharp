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
	public partial class EditarVaga : ContentPage
	{
        private Vaga vaga { get; set; }
		public EditarVaga (Vaga vaga)
		{
			InitializeComponent ();
            //COLOCAR DADOS NA TELA
            this.vaga = vaga;
            NomeVaga.Text = vaga.NomeVaga;
            Quantidade.Text = vaga.Quantidade.ToString();
            Cidade.Text = vaga.Cidade;
            Descricao.Text = vaga.Descricao;
            TipoContratacao.IsToggled = (vaga.TipoContratacao == "CLT") ? false : true;
            Telefone.Text = vaga.Telefone;
            Email.Text = vaga.Email;
            Salario.Text = vaga.Salario.ToString();
            Empresa.Text = vaga.Empresa;
		}

        private void SalvarAction(object sender, ClickedEventArgs args)
        {
            //Obter dados da tela
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            //atualizar no BD
            Database db = new Database();
            db.Atualizacao(vaga);

            //redirecionar para a tela de Minhas Vagas Cadastradas
            App.Current.MainPage = new NavigationPage(new MinhasVagasCadastradas());
        }

    }
}