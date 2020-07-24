using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.Write("digite a primeira nota");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("digite a segunda nota");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("digite a terceira nota");
            n3 = int.Parse(Console.ReadLine());
            n4=(9*5)-n1-n2-n3;
            Console.Write("você precisa da nota: "+ n4);
            Console.ReadKey();
                          
        }
    }
}
