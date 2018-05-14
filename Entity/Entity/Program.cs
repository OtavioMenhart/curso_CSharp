using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void ConsultarClientesLinq2()
        {
            var db = new CADASTROEntities();
            var qry = from c in db.CONTATOS
                      select new { Nome = c.CLIENTE.NomeCliente, Contato = c.Contato1 };
            foreach (var cli in qry)
            {
                Console.WriteLine(cli.Nome + " - " + cli.Contato);
            }
            Console.ReadLine();
        }

        private static void ConsultarClientesLinq()
        {
            var db = new CADASTROEntities();
            var qry = from cli in db.CLIENTES
                      where cli.NomeCliente.Contains("a")
                      orderby cli.IdCliente descending
                      select cli;
            foreach (var c in qry)
            {
                Console.WriteLine(c.IdCliente.ToString() + " - " + c.NomeCliente + " - " + c.Email);
            }
            Console.ReadLine();
        }

        private static void ConsultarClientes()
        {
            var db = new CADASTROEntities();
            foreach (var cliente in db.CLIENTES)
            {
                Console.WriteLine(cliente.NomeCliente);
                foreach (var cont in cliente.CONTATOS)
                {
                    Console.WriteLine(cont.Tipo);
                    Console.WriteLine(cont.Contato1);
                }
            }
            Console.ReadLine();
        }

        #region Inserção
        private static void Inserir()
        {
            var db = new CADASTROEntities();
            var cli = new CLIENTE()
            {
                NomeCliente = "Wesley",
                Email = "wesley@gmail.com"
            };
            var cont1 = new CONTATO()
            {
                Tipo = "EMAIL",
                Contato1 = "wesley@gmail.com",
                CLIENTE = cli
            };
            var cont2 = new CONTATO()
            {
                Tipo = "TELEFONE",
                Contato1 = "123456789",
                CLIENTE = cli
            };
            db.CONTATOS.Add(cont1);
            db.CONTATOS.Add(cont2);
            db.SaveChanges();
            Console.WriteLine("Registros inseridos com sucesso");
            Console.ReadLine();
        }
        #endregion
    }
}
