using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //dataset
using System.Data.SqlClient; //provider para o sql server

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            var constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CADASTRO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var con = new SqlConnection(constr);
            var SQL = "select * from CLIENTES";
            var cmd = new SqlCommand(SQL, con);
            var ds = new DataSet();
            var da = new SqlDataAdapter();



        }
    }
}
