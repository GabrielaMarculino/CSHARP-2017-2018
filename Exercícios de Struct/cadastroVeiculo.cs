using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructCadastroCarros
{
    class Program
    {

        public struct Carro
        {
            public string modelo;
            public string ano;
            public string cor;
            public int cd;
        }
        public struct Caminhao
        {

        }
        static void Main(string[] args)
        {

            int n_carros = 0;
            int n_caminhoes = 0;
            int x = 0; //carros
            int z = 0;  //caminhoes
            int tam = 0;
            int menu = 0;
            string y;
            string w;
            string cor_escolha;
            string modelo_escolha;
            int placa;

            Carro[] carro = new Carro[300];
            Caminhao[] caminhao = new Caminhao[300];

            do
            {
                Console.WriteLine("**** DIGITE A OPÇÃO DESEJADA ****");
                Console.WriteLine(" 1 - Cadastrar carro \n 2 - Cadastrar caminhão \n 3 - Consulta por placa \n 4 - Consultar caminhão por modelo \n 5 - Consultar carro por cor \n 6 - Exibir todos os carros cadastrados \n 7 - Exibir todos os caminhões cadastrados \n 0 - Sair do Sistema");
                          
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Quantos carros você deseja cadastrar?");
                        n_carros = int.Parse(Console.ReadLine());

                        for (x = 0; x < n_carros; x++)
                        {
                            Console.WriteLine("\nDigite o modelo do {0}º carro: ", x + 1);
                            carro[x].modelo = Console.ReadLine();
                            Console.WriteLine("Digite o ano do modelo: ");
                            carro[x].ano = Console.ReadLine();
                            Console.WriteLine("Digite a cor do carro: ");
                            carro[x].cor = Console.ReadLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Quantos caminhões você deseja cadastrar?");
                        n_caminhoes = int.Parse(Console.ReadLine());

                        for (z = 0;  z< n_caminhoes; z++)
                        {
                            Console.WriteLine("\nDigite o modelo do {0}º carro: ",z + 1);
                            caminhao[z].modelo = Console.ReadLine();
                            Console.WriteLine("Digite o ano do modelo: ");
                            caminhao[z].ano = Console.ReadLine();
                            Console.WriteLine("Digite a cor do carro: ");
                            caminhao[z].cor = Console.ReadLine();
                        }
                        break;

                  /*  case 2:

                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o ano dos modelos que você deseja ver: ");
                        ano_escolha = Console.ReadLine();

                        for (x = 0; x < tam; x++)
                        {
                            if (ano_escolha == carro[x].ano)
                            {
                                Console.WriteLine("\n Nome: " + carro[x].modelo);
                                Console.WriteLine("Cor: " + carro[x].cor);
                                Console.WriteLine("Ano: " + carro[x].ano);
                            }
                        }
                        break;
                    */
                    case 3:

                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o número da placa do carro que você deseja ver: ");
                        placa = int.Parse(Console.ReadLine());

                        for (x = 0; x < tam; x++)
                        {
                            if (placa == carro[x].cd)
                            {
                                Console.WriteLine("\n Nome: {0}", carro[x].modelo);
                                Console.WriteLine("Cor: {0}", carro[x].cor);
                                Console.WriteLine("Ano: {0}", carro[x].ano);
                            }
                        }

                        break;

                    case 4:
                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o modelo do caminhão que você deseja ver: ");
                        modelo_escolha = Console.ReadLine();
                        for (x = 0; x < tam; x++)
                        {
                            if (modelo_escolha == caminhao[x].modelo)
                            {
                                Console.WriteLine("\n Nome: {0}", caminhao[x].modelo);
                                Console.WriteLine("Cor: {0}", caminhao[x].cor);
                                Console.WriteLine("Ano: {0}", caminhao[x].ano);
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o a cor do carro que você deseja ver: ");
                        cor_escolha = Console.ReadLine();
                        for (x = 0; x < tam; x++)
                        {
                            if (cor_escolha == carro[x].cor)
                            {
                                Console.WriteLine("\n Nome: {0}", carro[x].modelo);
                                Console.WriteLine("Cor: {0}", carro[x].cor);
                                Console.WriteLine("Ano: {0}", carro[x].ano);
                            }
                        }
                        break;

                    
                    case 6:
                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());
                        for (x = 0; x < tam; x++)
                        {
                            Console.WriteLine("\nNome: {0}", carro[x].modelo);
                            Console.WriteLine("Cor:  {0}", carro[x].cor);
                            Console.WriteLine("Ano: {0} ", carro[x].ano);
                        }



                        Console.WriteLine("Digite o nome do carro que você deseja ver: ");
                        y = Console.ReadLine();

                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        for (x = 0; x < tam; x++)
                            if (y == carro[x].modelo)
                            {
                                Console.WriteLine("\nDigite o modelo do carro: ", x + 1);
                                carro[x].modelo = Console.ReadLine();
                                Console.WriteLine("Digite o ano do modelo: ");
                                carro[x].ano = Console.ReadLine();
                                Console.WriteLine("Digite a cor do carro: ");
                                carro[x].cor = Console.ReadLine();
                            }
                        break;
                    /* Console.WriteLine("Digite o nome do carro que você deseja excluir: ");
                     y = Console.ReadLine();

                     Console.WriteLine("Digite o número de carros que você cadastrou: ");
                     tam = int.Parse(Console.ReadLine());

                     for (x = 0; x < tam; x++)
                         if (y == carro[x].modelo)
                         {
                             carro[x].modelo = "";
                             carro[x].ano = "";
                             carro[x].cor = "";
                         }

                     break;
                     */
                    case 7:
                        Console.WriteLine("Digite o número de caminhoes que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());
                        for (x = 0; x < tam; x++)
                        {
                            Console.WriteLine("\nNome: {0}", caminhao[x].modelo);
                            Console.WriteLine("Cor:  {0}", caminhao[x].cor);
                            Console.WriteLine("Ano: {0} ", caminhao[x].ano);
                        }



                        Console.WriteLine("Digite o nome do caminhão que você deseja ver: ");
                        w = Console.ReadLine();

                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        for (z = 0; z < tam; z++)
                            if (w == carro[x].modelo)
                            {
                                Console.WriteLine("\nDigite o modelo do carro: ", z + 1);
                                caminhao[x].modelo = Console.ReadLine();
                                Console.WriteLine("Digite o ano do modelo: ");
                                caminhao[x].ano = Console.ReadLine();
                                Console.WriteLine("Digite a cor do carro: ");
                                caminhao[x].cor = Console.ReadLine();
                            }
                        break;
                        
                    case 0:
                        //Sair 
                        break;



                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                } 
            } while (menu != 0);
        }
    }
}

                       
        