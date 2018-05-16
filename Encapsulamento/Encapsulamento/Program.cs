using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDoBrasil.Contas;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(TipoConta.ContaCorrente, "123456");

            #region Modo public
            //conta.Num = "123";
            //conta.Saldo = 0;
            //conta.Tipo = TipoConta.ContaCorrente;
            #endregion

            conta.Depositar(500);
            conta.Sacar(300);

            Console.WriteLine("Saldo: " + conta.getSaldo().ToString());
            Console.ReadKey();
        }
    }
}
