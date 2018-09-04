using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App02_ListView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            ListaFuncionarios.ItemsSource = GetFuncionarios();

        }

        private List<Grupo> GetFuncionarios()
        {
            return new List<Grupo>
            {
                new Grupo("Presidente", "CEO", "Presidente da empresa")
                {
                    new Pessoa { Nome = "Otávio", IsRequired=true, RankEficiencia=8 }
                },
                new Grupo("Diretores", "Dir", "Diretor da empresa")
                {
                    new Pessoa{Nome = "João", IsRequired=false},
                    new Pessoa{Nome = "Maria", IsRequired=true, RankEficiencia=6}
                },
                new Grupo("Gerentes", "Ger", "Gerente da empresa")
                {
                    new Pessoa{Nome = "José", IsRequired=true, RankEficiencia=9},
                    new Pessoa{Nome = "Judas", IsRequired=false}
                },
                new Grupo("Funcionário", "Func", "Funcionários da empresa")
                {
                    new Pessoa{Nome = "José", IsRequired=false},
                    new Pessoa{Nome = "Judas", IsRequired=false},
                    new Pessoa{Nome = "João", IsRequired=false, RankEficiencia=6},
                    new Pessoa{Nome = "Maria", IsRequired=false},
                    new Pessoa{Nome = "Felipe", IsRequired=false},
                    new Pessoa{Nome = "Danilo", IsRequired=false},
                    new Pessoa{Nome = "Jessica", IsRequired=false},
                    new Pessoa{Nome = "Debora", IsRequired=false}
                },
            };
        }

        public class Grupo : List<Pessoa>
        {
            public string Titulo { get; set; }
            public string TituloCurto { get; set; }
            public string Descricao { get; set; }

            public Grupo(string titulo, string tituloCurto, string descricao)
            {
                this.Titulo = titulo;
                this.TituloCurto = tituloCurto;
                this.Descricao = descricao;
            }
        }

        public class Pessoa
        {
            public string Nome { get; set; }
            public int RankEficiencia { get; set; }
            public bool IsRequired { get; set; }
        }
    }
}
