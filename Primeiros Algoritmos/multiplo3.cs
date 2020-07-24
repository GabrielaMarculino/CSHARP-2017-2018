using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int v;
            Console.Write(" valor:");
            v = int.Parse(Console.ReadLine());
            if (v % 2 == 0)
            {

                Console.Write(" é par e multiplo de 3");
            }
            else
            {
                Console.Write(" é ímpar e não é multiplo de 3");
            }
            Console.ReadKey();
        }
             


        }
    }

