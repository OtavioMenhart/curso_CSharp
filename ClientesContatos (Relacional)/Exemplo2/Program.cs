using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClientesContatos
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CADASTRO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var con = new SqlConnection(constr);
            var SQL1 = "select * from CLIENTES";
            var SQL2 = "select * from CONTATOS";

            var cmd1 = new SqlCommand(SQL1, con);
            var cmd2 = new SqlCommand(SQL2, con);

            var ds = new DataSet("CLIENTES");
            var da1 = new SqlDataAdapter(cmd1);
            var da2 = new SqlDataAdapter(cmd2);

            da1.Fill(ds,"CLIENTES");
            da2.Fill(ds,"CONTATOS");

            var dtClientes = ds.Tables[0];
            var dtContatos = ds.Tables[1];

            DataRelation relation = ds.Relations.Add(
                "ClientesContatos",
                dtClientes.Columns["IdCliente"],
                dtContatos.Columns["IdCliente"]
            );

            foreach (DataRow cli in dtClientes.Rows)
            {
                Console.WriteLine("Nome Cliente: " + cli[1].ToString());
                foreach (DataRow cont in cli.GetChildRows(relation))
                {
                    Console.WriteLine(cont[1].ToString() + " - " + cont[2].ToString());
                }
            }
            Console.ReadKey();
        }
    }
}
