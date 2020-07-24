using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe_1_Struct
{
    class Program
    {
        public struct data
        {
            public int dia, mes, ano;
        }
        static void Main(string[] args)
        {
            data d;
            bool dc = false;

            while (dc == false)
            {
                bool ddc, dmc;
                //ddc é a variável para dia e dmc é variável do mês

                Console.WriteLine("Digite um dia");
                d.dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um mes");
                d.mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite um ano");
                d.ano = int.Parse(Console.ReadLine());

                //Este IF serve para checar se o dia digitado é correto.
                if (d.dia > 31)
                {
                    ddc = false;
                }
                else ddc = true;
                //Este if serve para do mês.
                if (d.mes > 12)
                {
                    dmc = false;
                }
                else dmc = true;

                //Este IF serve para manter o WHILE rodando.
                if (ddc && dmc == true)
                {
                    dc = true;
                }
                else
                {
                    dc = false;
                    Console.Clear();
                    Console.Write("Data Inválida\n\nDigite Novamente\n\n");
                }
            }
            Console.Write("Data Válida");
            Console.ReadKey();
        }
    }
}
