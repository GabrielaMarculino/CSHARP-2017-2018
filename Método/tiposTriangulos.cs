using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoMetodo3
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;

            Console.Write("Digite o primeiro lado: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo lado: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro lado: ");
            c = double.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("Equilátero? " + Equilatero(a, b, c) + "\n");
            Console.WriteLine("Isosceles? " + Isosceles(a, b, c) + "\n");
            Console.WriteLine("Escaleno? " + Escaleno(a, b, c) + "\n");

            Console.ReadKey();

        }

        static Boolean Equilatero(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return true;
            }
            else return false;
        }

        static Boolean Isosceles(double a, double b, double c)
        {
            if (a == b && b != c)
            {
                return true;
            }
            else return false;
        }

        static Boolean Escaleno(double a, double b, double c)
        {
            if (a != b && b != c)
            {
                return true;
            }
            return false;
        }

    }
}