using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Aluno
    {
        public Aluno()
        {
            Console.WriteLine("aluno constructor");
        }

        //CONSTRUTOR COM PARAMETROS
        public Aluno(string _nome, int _idade)
        {
            this.nome = _nome;
            this.idade = _idade;
        }

        /*INICIO PROPRIEDADES */
        //NOME
        private string nome;
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        //IDADE
        private int idade;
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                if(value >= 18)
                {
                    idade = value;
                }                
            }
        }

        public int GetTwiceIdade()
        {
            int twice = this.idade * 2;
            return twice;
        }

        public bool VerificaMaior(int _idade)
        {
            /*bool verifica = false;
            if(_idade >= 18)
            {
                verifica = true;
            }
            else
            {
                verifica = false;
            }*/
            bool verifica = (_idade >= 18) ? true : false;
            return verifica;
        }

        /*FIM PROPRIEDADES */

        //METODO
        public void Limpar()
        {
            this.idade = 0;
            this.nome = string.Empty;
        }

        private void GoAge()
        {
            this.idade = 20;
        }

        ~Aluno()
        {
            Console.WriteLine("aluno destructor");
            Console.ReadKey();
        }
    }
}
