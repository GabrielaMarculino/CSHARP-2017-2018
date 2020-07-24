using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMetodo5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Os cases foram divididos em:
             * -Coleta de dados (escreva: leia,escreva2: leia2) e resultado
             * -Digite qualquer tecla para sair
             */

            int opc = -1; //menu da calculadora
            double num1; //primeiro número digitado
            double num2; //segundo número digitado
            int sair = -1; //variável que define quando o programa vai fechar

            do //menu
            {
                Console.Clear();
                Console.WriteLine("1-ADIÇÃO\n2-SUBTRAÇÃO\n3-DIVISÃO\n4-MULTIPLICAÇÃO\n5-RESTO DE DIVISÃO\n6-DOBRO\n7-AO QUADRADO\n8-AO CUBO\n9-RAIZ QUADRADA\n0-SAIR");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1: //puxa o método de adição
                        Console.WriteLine("Você escolheu ADIÇÃO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2° número");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine(adicao(num1, num2));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 2: //puxa o método de subtração
                        Console.WriteLine("Você escolheu SUBTRAÇÃO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o 2° número");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + subtracao(num1, num2));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 3: //puxa o método de divisão
                        Console.WriteLine("Você escolheu DIVISÃO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Dividido por: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + divisao(num1, num2));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 4: //puxa o método de multiplicação
                        Console.WriteLine("Você escolheu MULTIPLICAÇÃO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Vezes: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + multiplicacao(num1, num2));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 5: //puxa o método do resto de divisão
                        Console.WriteLine("Você escolheu RESTO DE DIVISÃO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Dividido por: ");
                        num2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + resto(num1, num2));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 6: //puxa o método dobro
                        Console.WriteLine("Você escolheu DOBRO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + dobro(num1));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 7: //puxa o método ao quadrado
                        Console.WriteLine("Você escolheu AO QUADRADO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + quadrado(num1));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 8: //puxa o método de ao cubo
                        Console.WriteLine("Você escolheu AO CUBO!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + cubo(num1));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 9: //puxa o método raiz quadrada
                        Console.WriteLine("Você escolheu RAIZ QUADRADA!");
                        Console.WriteLine("Digite o 1° número: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("O resultado é: " + raizQuadrada(num1));
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;

                    case 0: //sai do programa
                        Console.WriteLine("Você escolheu SAIR!");
                        Console.WriteLine("Digite qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        sair = 1;
                        break;
                }
            } while (sair != 1);
        }


        static double adicao(double num1, double num2) //SOMA 
        {
            double c1 = 0;      //c1 = conta 1
            c1 = num1 + num2;

            return c1;          //o resultado da conta, volta para a calculadora
        }
        static double subtracao(double num1, double num2)//SUBTRAI
        {
            double c2 = 0;
            c2 = num1 - num2;

            return c2;
        }
        static double divisao(double num1, double num2) //DIVIDE
        {
            double c3 = 0;
            c3 = num1 / num2;

            return c3;
        }
        static double multiplicacao(double num1, double num2) //MULTIPLICA
        {
            double c4 = 0;
            c4 = num1 * num2;

            return c4;
        }
        static double resto(double num1, double num2) //DIVIDE NÚMEROS ÍMPARES
        {
            double c5 = 0;
            c5 = num1 % num2;

            return c5;
        }
        static double dobro(double num1) //DOBRA
        {
            double c6 = 0;
            c6 = num1 * 2;

            return c6;
        }
        static double quadrado(double num1) //ELEVA AO QUADRADO
        {
            double c7 = 0;
            c7 = num1 * num1;

            return c7;
        }
        static double cubo(double num1) //ELEVA AO CUBO
        {
            double c8 = 0;
            c8 = (num1 * num1) * num1;

            return c8;
        }
        static double raizQuadrada(double num1) //CALCULA A RAÍZ
        {
            double c9 = 0;
            c9 = num1 = (Convert.ToSingle(Math.Sqrt(num1)));  //peguei este código no site da Microsoft

            return c9;
        }
    }
}


