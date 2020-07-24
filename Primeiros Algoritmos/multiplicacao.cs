using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiro_valor, segundo_valor;
            Console.Write("digite o primeiro valor");
            primeiro_valor = int.Parse(Console.ReadLine());
            Console.Write("digite o segundo valor");
            segundo_valor = int.Parse(Console.ReadLine());
            Console.WriteLine("soma do primeiro valor e segundo valor é:" + primeiro_valor + segundo_valor);
            Console.WriteLine("o valor da multiplicação do primeiro e segundo valor é:" + primeiro_valor * segundo_valor);
            Console.WriteLine("o valor da subtração do primeiro e segundo valor é:" + primeiro_valor - segundo_valor);
            Console.ReadKey();



        }
    }
}
