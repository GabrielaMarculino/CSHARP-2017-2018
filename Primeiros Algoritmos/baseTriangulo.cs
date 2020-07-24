using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Digite a base do triângulo: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura do triângulo: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("O resultado da base vezes a altura é: " + (a * b));
            Console.ReadKey();
        }
    }
}
