using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiro_valor, segundo_valor, terceiro_valor;
            Console.Write("digite o primeiro valor");
            primeiro_valor=int.Parse(Console.ReadLine());
            Console.Write("digite o segundo valor");
            segundo_valor = int.Parse(Console.ReadLine());
            Console.Write("digite o terceiro valor");
            terceiro_valor = int.Parse(Console.ReadLine());
            Console.Write("a soma do primeiro valor e terceiro valor é:"+primeiro_valor+terceiro_valor);
            Console.Write("a multiplicação do primeiro e segundo valor é:" + segundo_valor * primeiro_valor * terceiro_valor);
            Console.ReadKey();
              

               
           
       
          
        }
    }
}
