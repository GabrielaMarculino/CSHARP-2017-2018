using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu, nd, nt, nq;
            string nm;
            Console.Write("digite o nome do aluno");
            nm = (Console.ReadLine());
            Console.Write("digite a nota um");
            nu = int.Parse(Console.ReadLine());
            Console.Write("digite a nota dois");
            nd = int.Parse(Console.ReadLine());
            Console.Write("digite a nota três");
            nt = int.Parse(Console.ReadLine());
            Console.Write("digite a nota quatro");
            nq = int.Parse(Console.ReadLine());
            Console.Write("o resultado da média é:" + (nu + nd + nt + nq / 4));
            Console.ReadKey();

        }
    }
}
