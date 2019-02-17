using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Models;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro() { Marca = "FIAT", Modelo = "UNO" };
            Casa casa = new Casa() { Cidade = "Brasília", Endereco = "QSQ 400" };
            Usuario usuario = new Usuario() { Nome = "Maria", Email = "maria@gmail.com", Senha = "maria123" };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Deserializar<Carro>();
            Casa casa2 = Serializador.Deserializar<Casa>();
            Usuario usuario2 = Serializador.Deserializar<Usuario>();

            Console.WriteLine("Carro2: {0} - {1}", carro2.Marca, carro2.Modelo);
            Console.WriteLine("Casa2: {0} - {1}", casa2.Cidade, casa2.Endereco);
            Console.WriteLine("Usuário2: {0} - {1}", usuario2.Nome, usuario2.Email);
            Console.ReadKey();
        }
    }
}
