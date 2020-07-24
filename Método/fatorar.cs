using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodo1
{
    class Program
    {
        static int fator(int x)
        {
            int y = 1;
            for (int cont1 = 1; cont1 <= x; cont1++)
                y *= cont1;
            return y;
        }
        static void Main(string[] args)
        {
            int x;
            Console.Write(" Digite o numero que deseja fatorar: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine(fator(x));
            Console.ReadKey();
        }

    }
}
