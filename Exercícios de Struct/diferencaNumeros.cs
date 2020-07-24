using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodo2r
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0; //variável que irá receber o primeiro valor
            int y = 0; //variável que irá receber o segundo valor
            
            Console.WriteLine("Digite o 1° valor : ");
            x = int.Parse(Console.ReadLine()); //lendo o primeiro valor
            Console.WriteLine("Digite o 2° valor : ");
            y = int.Parse(Console.ReadLine()); //lendo o segundo valor
            Console.WriteLine("A diferença entre o maior e menor número é : "+diferenca (x,y));
            Console.WriteLine("\n\nPressione qualquer tecla para sair."); //sair/fechar o programa.
            Console.ReadKey();

        }
        static int diferenca(int x, int y)
        {
            int f = 0;

            if (y >= x)
            {
                f = y - x;
            }
            else
            {
                f = x - y;
            }
           
            return f;
        }
    }
}

