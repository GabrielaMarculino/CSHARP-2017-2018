using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            Console.Write("Digite os graus em Fahrenheit: ");
            f = int.Parse(Console.ReadLine());
            Console.Write("A temperatura em Graus Celsius é: " + (f - 32) / 1.8);
            Console.ReadKey();
 
        }
    }
}
