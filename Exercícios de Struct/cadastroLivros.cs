using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioStrcut5
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

            Console.WriteLine("\n\n\n**** EXIBINDO OS DADOS DO LIVRO *****\n");
            exibirDados(livros);
            Console.ReadKey();


        }
        static Livro cadastrarLivro()
        {
            Livro 1;

            Console.WriteLine("\n***** CADASTRANDO LIVROS *****\n");
            Console.WriteLine("\nTítulo do livro: "); 1.titulo = Console.ReadLine();
            Console.WriteLine("\nAno de lançamento: "); 1.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPreço: "); 1.preco = float.Parse(Console.ReadLine());
            return 1;
        }
        static void exibirDados(Livro 1)
        {

            Console.WriteLine("\n***** EXIBIDINDO DADOS DO LIVRO *****\n");
            Console.WriteLine("\nTítulo do livro : {0} ", 1.titulo);
            Console.WriteLine("\nAno de lançamento: {0}", 1.ano );
            Console.WriteLine("\nPreço: R${0:N2}", 1.preco );

        }
    }
}
