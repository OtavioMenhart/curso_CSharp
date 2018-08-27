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
	public partial class CadastrarVaga : ContentPage
	{
		public CadastrarVaga ()
		{
			InitializeComponent ();
		}

        public void SalvarAction(object sender, EventArgs args)
        {
            //Obter dados da tela
            Vaga vaga = new Vaga();
            vaga.NomeVaga = NomeVaga.Text;
            vaga.Quantidade = short.Parse(Quantidade.Text);
            vaga.Salario = double.Parse(Salario.Text);
            vaga.Empresa = Empresa.Text;
            vaga.Cidade = Cidade.Text;
            vaga.Descricao = Descricao.Text;
            vaga.TipoContratacao = (TipoContratacao.IsToggled) ? "PJ" : "CLT";
            vaga.Telefone = Telefone.Text;
            vaga.Email = Email.Text;

            //Salvar informações no banco
            Database db = new Database();
            db.Cadastro(vaga);

            //Voltar para tela de pesquisa
            App.Current.MainPage = new NavigationPage(new ConsultaVagas());
        }

    }
}