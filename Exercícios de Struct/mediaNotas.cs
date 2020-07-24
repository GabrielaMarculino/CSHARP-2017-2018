using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct2
{
    class Program
    {
        public struct Boletim
        {
            public string nome;
            public double nota1;
            public double nota2;
            public double media;
            public string situacao;
        }
        static void Main(string[] args)
        {
            const int tam = 5;
            Boletim[] alunos = new Boletim[tam];

            Console.WriteLine("\n***** CADASTRANDO DADOS DO ALUNO *****\n");
            for (int x = 0; x < tam; x++)
            {
                Console.WriteLine("\nNome do {0}º aluno: ", x + 1);             alunos[x].nome = Console.ReadLine();
                Console.WriteLine("\nDigite a 1° nota: ");                      alunos[x].nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite a 2° nota: ");                      alunos[x].nota2 = double.Parse(Console.ReadLine());
                
                Console.Clear();   
            }
            Console.WriteLine("\n***** EXIBINDO INFORMAÇÕES *****\n");
            for  (int x = 0; x < tam; x++)
            {
                Console.WriteLine("\nNome do {0}º aluno: {1}", x + 1, alunos[x].nome);
                Console.WriteLine("\n1ª nota:  {0:N1}", alunos[x].nota1);
                Console.WriteLine("\n2ª nota:  {0:N1}", alunos[x].nota2);
                Console.WriteLine("\nMédia: {0:N1}", alunos[x].media);
                Console.WriteLine("\nSituação: ", alunos[x].situacao);
            }
            Console.ReadLine();
        }
    }
}
