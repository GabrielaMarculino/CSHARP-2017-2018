using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercico17
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1, n2, n3, n4, m;
            Console.Write("nome do aluno:");
            nome=Console.ReadLine();
            Console.WriteLine("primeira nota:");
            n1= double.Parse(Console.ReadLine());
            Console.WriteLine("segunda nota:");
            n2= double.Parse(Console.ReadLine());
            Console.Write("terceira nota:");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("quarta nota:");
            n4 = double.Parse(Console.ReadLine());
            m = (n1 + n2 + n3 + n4) / 4;
            Console.WriteLine("o aluno " + nome + " obteve média " + m + " e foi");
            if (m >= 6)
            {
                Console.Write("aprovado");
            }
            else
            {
                Console.Write("reprovado");
            }
            Console.ReadKey();
            



           
        }
    }
}
