using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_atomica_da_gabi
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            double v1, v2;
            int opc =-1;
            while (opc != 0)
            {

                Console.WriteLine("1-adição\n2-subtração\n3-divisão\n4-multiplicação");
                opc = int.Parse(Console.ReadLine());
                switch (opc) { 
                



                    case 1:
                        Console.WriteLine("Digite o 1° valor : ");
                        v1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2° valor : ");
                        v2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Soma" + (v1 + v2));
                        break;

                    case 2:
                        Console.WriteLine("Digite o 1° valor : ");
                        v1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2° valor : ");
                        v2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Subtração" + (v1 - v2));
                        break;

                    case 3:
                        Console.WriteLine("Digite o 1° valor : ");
                        v1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2° valor : ");
                        v2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Divisão" + (v1 / v2));
                        break;

                    case 4:
                        Console.WriteLine("Digite o 1° valor : ");
                        v1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2° valor : ");
                        v2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(" Multiplicação" + (v1 * v2));
                        break;
                        
                }
                Console.ReadKey();
            }

            }
        }
    }