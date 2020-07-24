using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            Console.Write("Qual o raio do circulo? ");
            raio = double.Parse(Console.ReadLine());
            Console.Write("A area do circulo é:" + (raio * raio) * 3.14);
            Console.ReadKey();
        }
    }
}
