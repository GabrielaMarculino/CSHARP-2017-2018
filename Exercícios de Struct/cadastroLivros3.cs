using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioStruct7
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
            const int NUM_L = 3, NUM_C = 2;
            Livro[,] livros = new Livro[NUM_L, NUM_C];

            Console.WriteLine("\n***** CADASTRANDO LIVROS *****\n");
            for (int l = 0; l < NUM_L; l++)
            {
                for (int c = 0; c < NUM_C; c++)
                {
                    livros[l, c] = cadastrarLivro();
                }
            }
            Console.Clear();
            Console.WriteLine("\n***** EXIBDINDO OS DADOS DOS LIVROS ****\n");
            exibirDados(livros);
            Console.ReadKey();
        }
        static Livro cadastarLivro()
        {
            Livro 1;
            Console.WriteLine("\nTítulo do livro: "); 1.livro = Console.ReadLine();
            Console.WriteLine("\nAno de Lançamento: "); 1.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço: "); 1.preco = float.Parse(Console.ReadLine());
            return 1;

        }

        static void exibirDados(Livro[,] lv)
        {
            int px = 3, py = 3; //variáveis para controlar a posição do cursor da tela
            for (int l = 0; l < lv.GetLength(0); l++)
            {
                for (int c = 0; c < lv.GetLength(1); c++)
                {
                    Console.SetCursorPosition(px, py + 1);
                    Console.Write("\tTítulo: {0}", lv[l, v].titulo);
                    Console.SetCursorPosition(px, py + 2);
                    Console.Write("\tAno: {0}", lv[l, v].ano);
                    Console.SetCursorPosition(px, py + 3);
                    Console.Write("\tPreço: R${0:N2}", lv[l, v].preco);
                    px += 25;  //para deixar um espçao a direita p/ próximo  registro
                }
                px = 0;  //quando pular de linha retornar  na posição inicial
                py += 5;  //quando pular de linha, pular 5 linhas a partir da posição atual

            }
        }
    }
}
