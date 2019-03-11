using _04_Reflections.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Otávio",
                Email = "otavio@gmail.com",
                Senha = "123456"
            };

            Log.Gravar(usuario.Clone());

            usuario.Nome = "Otávio Rocha";
            Log.Gravar(usuario.Clone());

            Carro carro = new Carro() { Marca = "FIAT", Modelo = "Palio" };
            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.WriteLine("Log gravado");
            Console.ReadKey();
        }
    }
}
