using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocha.Entidades;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica cli1 = new PessoaFisica();
            cli1.Codigo = 123;
            cli1.Nome = "Otávio";
            cli1.CPF = "123456789";
            cli1.Mostrar();

            PessoaJuridica cli2 = new PessoaJuridica();
            cli2.Codigo = 1234;
            cli2.Nome = "juridica";
            cli2.CNPJ = "123456789456789";
            cli2.Mostrar();

            Console.ReadKey();
        }
    }
}
