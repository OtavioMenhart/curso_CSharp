using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Aplicacao
{
    class Antigo
    {
        static void Main(string[] args)
        {
            // as regions minimizadas estão comentadas
            #region Conexão básica

            //string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=CADASTRO;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            //    string ConnectionString = getConnectioStringFromConfig();

            //    using (var con = new SqlConnection(ConnectionString))
            //    {
            //        Console.WriteLine("String de conexão: " + ConnectionString);
            //        con.Open();
            //        Console.WriteLine("Conexão com o banco de dados efetuada com sucesso");
            //        Console.WriteLine("Estado de conexão " + con.State);
            //        con.Close();
            //        Console.WriteLine("Estado de conexão " + con.State);
            //    }
            //    Console.ReadKey();
            //}

            //private static string getConnectioStringFromConfig()
            //{
            //    return ConfigurationManager.ConnectionStrings["CADASTRO"].ConnectionString;
            //}

            //private static string getConnectionStringFromBuilder()
            //{
            //    var ConBuilder = new SqlConnectionStringBuilder();
            //    ConBuilder.DataSource = @"(localdb)\MSSQLLocalDB";
            //    ConBuilder.InitialCatalog = "CADASTRO";
            //    ConBuilder.IntegratedSecurity = true;
            //    var ConnectionString = ConBuilder.ConnectionString;
            //    return ConnectionString;
            //}

            #endregion

            #region Inserção de dados
            ////entrada de dados
            //Console.WriteLine("Informe nome do cliente: ");
            //var NomeCliente = Console.ReadLine();

            //Console.WriteLine("Informe email do cliente: ");
            //var Email = Console.ReadLine();

            ////gravação de dados
            //var ConStr = ConfigurationManager.ConnectionStrings["CADASTRO"].ConnectionString;
            //var con = new SqlConnection(ConStr);
            ////var SQL = "insert into CLIENTES(NomeCliente,Email) values(@NomeCliente, @Email)";
            //var SQL = "InsertCliente";
            //var cmd = new SqlCommand(SQL, con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@NomeCliente", NomeCliente);
            //cmd.Parameters.AddWithValue("@Email", Email);
            //con.Open();
            //try
            //{
            //    cmd.ExecuteNonQuery();
            //    Console.WriteLine("Registro inserido com sucesso!");
            //}
            //finally
            //{
            //    con.Close();
            //}
            //Console.ReadKey();
            #endregion

            #region Transaction
            //var ConStr = ConfigurationManager.ConnectionStrings["CADASTRO"].ConnectionString;
            //using (var con = new SqlConnection(ConStr))
            //{
            //    con.Open();
            //    var trans = con.BeginTransaction();
            //    try
            //    {
            //        var sql1 = "insert into CLIENTES(NomeCliente, Email) values (@NomeCliente, @Email)";
            //        var sql2 = "delete CLIENTES where IdCliente = 1";
            //        var cmd1 = con.CreateCommand();
            //        cmd1.CommandText = sql1;
            //        cmd1.Transaction = trans;

            //        var cmd2 = con.CreateCommand();
            //        cmd2.CommandText = sql2;
            //        cmd2.Transaction = trans;

            //        cmd1.Parameters.AddWithValue("@NomeCliente", "José");
            //        cmd1.Parameters.AddWithValue("@Email", "jose@gmail.com");

            //        //executados em uma única transação
            //        cmd1.ExecuteNonQuery();
            //        cmd2.ExecuteNonQuery();
            //        //efetiva operações no BD
            //        trans.Commit();
            //        Console.WriteLine("Comandos executados com sucesso");
            //    }
            //    catch (Exception e)
            //    {
            //        trans.Rollback();
            //        Console.WriteLine("Erro ao executar transação");
            //        Console.WriteLine(e.GetType());
            //        Console.WriteLine(e.Message);
            //    }
            //}
            #endregion

            var ConStr = ConfigurationManager.ConnectionStrings["CADASTRO"].ConnectionString;
            using(var con = new SqlConnection(ConStr))
            {
                var SQL = "SELECT [IdCliente], [NomeCliente], [Email] from [CLIENTES]";
                var cmd = con.CreateCommand();
                cmd.CommandText = SQL;
                con.Open();
                var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection); //read-only, forward-only, sem cache

                //varredura do data reader
                while (dr.Read())
                {
                    Console.WriteLine("ID: " + dr[0].ToString());
                    Console.WriteLine("Nome: " + dr[1].ToString());
                    Console.WriteLine("Email: " + dr[2].ToString());
                    Console.WriteLine("##############################################");
                }
                dr.Close();
                Console.ReadKey();
            }
        }
    }
}
