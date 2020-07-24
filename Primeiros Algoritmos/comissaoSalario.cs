using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, tv,sf;
            string nv;
            Console.Write("Digite o nome do vendedor: ");
            nv = (Console.ReadLine());
            Console.Write("Digite seu salário: ");
            s = double.Parse(Console.ReadLine());
            Console.Write("Digite o total vendas: ");
            tv = double.Parse(Console.ReadLine());
            sf = (s - tv) * 15 / 100;
            Console.Write("O salário total com a comissão é: "+sf);
            Console.ReadKey();
        }
    }
}
