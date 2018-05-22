using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasColecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var alunos = new Hashtable();
            alunos.Add(1, "Otavio");
            alunos.Add(2, "Menhart");
            alunos.Add(3, "Ballonje");
            alunos.Add(4, "Rocha");
            foreach (var aluno in alunos.Keys)
            {
                Console.WriteLine(aluno);
            }
            foreach (var aluno in alunos.Values)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("------------------------------");
            foreach (DictionaryEntry aluno in alunos)
            {
                Console.WriteLine(aluno.Key + " - " + aluno.Value);
            }
            Console.WriteLine("Informe a chave a ser lida: ");
            string str = Console.ReadLine();
            int pos = Convert.ToInt32(str);

            if (alunos.ContainsKey(pos))
            {
                Console.WriteLine("O valor para a chave é: " + alunos[pos]);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não existe valor para essa chave");
                Console.ReadKey();
            }
            Console.WriteLine("Informe letra ou parte a pesquisar no nome: ");
            string letra = Console.ReadLine();
            var qry = from string aluno in alunos.Values
                      where aluno.Contains(letra)
                      select aluno;
            foreach (string aluno in qry)
            {
                Console.WriteLine(aluno);
            }
            Console.ReadKey();
        }
    }
}
