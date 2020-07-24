using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int r, c, d;
            Console.Write("digite o valor em, reais: ");
            r = int.Parse(Console.ReadLine());
            Console.Write("digite a cotação do dólar: ");
            c = int.Parse(Console.ReadLine());
            d = r * c;
            Console.Write("o valor em dólares será de: " + d);
            Console.ReadKey();
               

        }
    }
}
