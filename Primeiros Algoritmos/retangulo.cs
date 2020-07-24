using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a;
            Console.Write("Qual a base do retangulo? ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Qual a altura?");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("A area do retangulo é de:" + (a * b));
            Console.ReadKey();



        }
    }
}
