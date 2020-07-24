using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade_parcelas;
            double valor_produto,valor_entrada,valor_parcelas;
            Console.Write("digite o valor do produto:");
            valor_produto=double.Parse(Console.ReadLine());
            Console.Write("digite o valor da entrada:");
            valor_entrada=double.Parse(Console.ReadLine());

            Console.Write("digite a quantidade de parcelas:");
            quantidade_parcelas=int.Parse(Console.ReadLine());
            valor_parcelas=(valor_produto-valor_entrada)/quantidade_parcelas;
            Console.Write("cada parcela é:" + quantidade_parcelas);
       
            Console.ReadKey();

        }
    }
}
