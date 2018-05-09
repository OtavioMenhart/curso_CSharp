using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();
            a1.Nome = "Pedro";
            a1.Idade = 30;

            Aluno a2 = new Aluno("Otavio", 20);

            
            a1.Limpar();
            
            Console.WriteLine(a2.GetTwiceIdade());
            Console.ReadKey();
        }
    }
}
