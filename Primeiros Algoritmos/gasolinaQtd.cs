using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, d, c;
            Console.Write("Digite a distância que foi percorrida: ");
            d = int.Parse(Console.ReadLine());
            Console.Write("Digite quantos litros de gasolina foram gastos: ");
            c = int.Parse(Console.ReadLine());
            m = d / c;
            Console.Write("A gasolina gasta é: "+ m);
            Console.ReadKey();
        }
    }
}
