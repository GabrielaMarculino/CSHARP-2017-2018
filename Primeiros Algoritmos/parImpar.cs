using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int V1;
            Console.WriteLine("primeiro valor:");
            V1 = int.Parse(Console.ReadLine());
            if (V1 % 2 == 0)
            {
                Console.WriteLine(" é par");
            }
            else
            {
                Console.Write(" é ímpar");
            }
            Console.ReadKey();
        }
    }
}
