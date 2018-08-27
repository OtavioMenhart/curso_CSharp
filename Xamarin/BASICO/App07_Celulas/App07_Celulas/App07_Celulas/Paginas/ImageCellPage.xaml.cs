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
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Otávio", Cargo = "Desenvolvedor", Foto = "http://www.blog.natsolutions.com.br/wp-content/uploads/2013/01/user.jpg" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente Vendas", Foto = "http://www.microlins.com.br/galeria/repositorio/images/noticias/como-posicionar-melhor-seu-perfil-no-linkedin/03-Como-posicionar-melhor-seu-perfil-do-Linkedin.png" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Marketing", Foto = "http://www.escultopintura.com.br/Tutoriais/Tutorial_Animacao_Personagem/4_Modelagem_Cabeca/0_Gabaritos/Gabaritos_Cabeca%20_Perfil.jpg" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor", Foto = "https://image.freepik.com/icones-gratis/editar-perfil_318-80207.jpg" });

            ListaFuncionarios.ItemsSource = Lista;
        }
	}
}