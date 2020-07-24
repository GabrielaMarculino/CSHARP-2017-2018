using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine(" digite o primeiro número : ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" digite o segundo valor :");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("multiplicação do primeiro e  segundo valor é :" + n1 * n2);
            Console.ReadKey();
             

        }
    }
}
