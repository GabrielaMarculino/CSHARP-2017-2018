using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            int v, maior, menor;
            Console.WriteLine(" primeiro valor:");
            v = int.Parse(Console.ReadLine());
            maior= v;
            menor = v;
            Console.WriteLine(" segundo valor:");
            v = int.Parse(Console.ReadLine());
            if (v > maior) {
                maior = v;
            } 


        }
    }
}
