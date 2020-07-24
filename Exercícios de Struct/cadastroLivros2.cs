using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioStruct6
{
    class Program
    {
        public struct Livro
        {
            public string titulo;
            public int ano;
            public float preco;
        }
        static void Main(string[] args)
        {
            const int TAM = 3;
            Livro[] livros = new Livro[TAM];

            Console.WriteLine("\n***** CADASTRANDO LIVROS *****\n");
            for (int x = 0; x < TAM; x++) ;
            livros[x] = cadastrarLivro();

            Console.WriteLine("\n\n\n***** EXIBIDINDO DADOS DO LIVROS *****\n");
            exibirDados(livros);
            Console.ReadKey();
        }
            static Livro cadastrarLivro()
        {
            
            Livro 1;
            Console.WriteLine("\nTítulo do Livro: "); 1.livro = Console.ReadLine();
            Console.WriteLine("\nAno de Lançamento: "); 1.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPreço: "); 1.preco =float.Parse( Console.ReadLine());
            return 1;
        }
        static void exibirDados(Livro[] 1)
        {
            for (int x = 0; x < 1.Length; x++)
            {
                Console.WriteLine("\n\tTítulo do livro: {0}", 1[x].titulo);
                Console.WriteLine("\tAno de lançamento: {0}", 1[x].ano);
                Console.WriteLine("\tPreço: R${0:N2}", 1[x].preco);
            }
        }
    }
}
