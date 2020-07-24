using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodo4
{
    class Program
    {
        static void Main(string[] args)
        {
            double h = 0.0; //altura
            string s=""; //sexo
            Console.WriteLine("Digite sua altura: ");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu sexo ( 'feminino' ou 'masculino' ) : ");
            s = (Console.ReadLine());
            calcularPesoIdeal(h, s);
            Console.WriteLine("Sua altura é : " + h + ", seu sexo é : " + s + " e seu peso ideal é: "+ calcularPesoIdeal(h,s));
            Console.WriteLine("\n\nDigite qualquer tecla para sair"); //sair/fechar programa
            Console.ReadKey();
        }

        static double calcularPesoIdeal(double h, string s)
        {
            double r; // variável que guardará o valor recebido e retornará como resposta
            if (s == "f")
            {
               
                r = (62.1 * h) - 44.7;
            }
            else if (s == "m")
            {
               
                r = (62.1 * h) - 44.7;
            }
            else
            {
                Console.WriteLine("Opção inválida !");
                r = 0;
            }
            return r;
        }

    }

} 
