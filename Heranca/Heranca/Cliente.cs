using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocha.Entidades
{
    public class Cliente
    {
        //atributos
        public int Codigo;
        public string Nome;
       // public int TipoCliente; type code não é uma boa prática

        //métodos
        public void Mostrar()
        {
            Console.WriteLine("Dados do cliente: {0}--{1}", Codigo, Nome);
        }
    }

    public class PessoaFisica : Cliente
    {
        public string CPF;
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CPF: {0}", CPF);
        }
    }

    public class PessoaJuridica : Cliente
    {
        public string CNPJ;
        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CNPJ: {0}", CNPJ);
        }
    }

}
