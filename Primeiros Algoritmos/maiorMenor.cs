using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercico18
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;
            Console.WriteLine ("primeiro valor:");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor:");
            v2 = int.Parse(Console.ReadLine());
            if (v1 < v2) 
            {
                Console.WriteLine(v2 + " é menor");
            }
            else
            {
                Console.Write(v2 + " é maior");
           
            }
            Console.ReadKey();


        }
    }
}
