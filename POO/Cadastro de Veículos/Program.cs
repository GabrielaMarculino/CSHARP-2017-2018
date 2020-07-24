using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    class Program : VeiculoR
    {


        static void Main(string[] args)
        {
            Carro cCarro = new Carro();
            Caminhao cCaminhao = new Caminhao();
            VeiculoR vVeiculo = new VeiculoR();
                                                                                        //Modificado em 19/05/2018
            int n_carros = 0;
            int n_caminhoes = 0;
            int x = 0;   //carros
            int z = 0;  //caminhoes
            int tam = 0;
            int menu = 0;
            string y;
            string w;
            string cor_escolha;
            string modelo_escolha;
            int placa;


            Carro[] carro = new Carro[300];
            Caminhao[] caminhao = new Caminhao[200];

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
                            vVeiculo.modelo = carro[x].modelo = Console.ReadLine();
                            Console.WriteLine("Digite o ano do modelo: ");                   //Checar os erros
                            vVeiculo.ano = carro[x].ano = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a cor do carro: ");
                            vVeiculo.cor = carro[x].cor = Console.ReadLine();
                            Console.WriteLine("Digite a placa do carro: ");
                            vVeiculo.placa = carro[x].placa = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a capacidade do porta - malas: ");
                            cCarro.capacidadePortaMala = carro[x].capacidadePortaMala = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a capacidade do bagageiro: ");
                            cCarro.bagageiro = carro[x].bagageiro = bool.Parse(Console.ReadLine());
                            Console.WriteLine("Digite qual a marca do motor: ");
                            cCarro.motor = carro[x].motor = Console.ReadLine();
                            Console.WriteLine("Digite quantas portas tem o carro: ");
                            cCarro.numero_portas = carro[x].numero_portas = int.Parse(Console.ReadLine());
                        }
                        break;

                    case 2:
                        Console.WriteLine("Quantos caminhões você deseja cadastrar?");
                        n_caminhoes = int.Parse(Console.ReadLine());

                        for (z = 0; z < n_caminhoes; z++)
                        {
                            Console.WriteLine("\nDigite o modelo do {0}º caminhão: ", z + 1);
                            vVeiculo.modelo =caminhao[z].modelo= Console.ReadLine();
                            Console.WriteLine("Digite o ano do modelo: ");
                            vVeiculo.ano=caminhao[z].ano = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite a cor do caminhão: ");
                            Console.WriteLine("Digite a placa do carro: ");
                            vVeiculo.placa = caminhao[z].placa = int.Parse(Console.ReadLine());
                            vVeiculo.cor=caminhao[z].cor = Console.ReadLine();
                            Console.WriteLine("Digite a quantidade de eixos que o caminhão tem: ");
                            cCaminhao.numero_eixos = caminhao[z].numero_eixos = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o peso máximo de carga que o caminhão suporta: ");
                            cCaminhao.peso_maximo_carga = caminhao[z].peso_maximo_carga = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite se o porte do caminhão é grande, médio ou pequeno: ");
                            cCaminhao.porte = caminhao[z].porte = Console.ReadLine();
                            Console.WriteLine("Digite quantas portas tem o caminhão: ");
                            cCaminhao.numero_portas = caminhao[z].numero_portas = int.Parse(Console.ReadLine());
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

                        Console.WriteLine("Digite o número de  que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o número da placa do veículo que você deseja consultar: ");
                        placa = int.Parse(Console.ReadLine());

                        for (x = 0; x < tam; x++)
                        {
                            if (placa == carro[x].placa)
                            {
                                Console.WriteLine("\n Nome: {0}", carro[x].modelo);
                                Console.WriteLine("Cor: {0}", carro[x].cor);
                                Console.WriteLine("Ano: {0}", carro[x].ano);
                                Console.WriteLine("Placa: {0}", carro[x].placa);
                                Console.WriteLine("Capacidade do porta - malas: {0}", carro[x].PortaMala);
                                Console.WriteLine("Capacidade do bagageiro: {0}", carro[x].bagageiro);
                                Console.WriteLine("Marca do motor: {0}", carro[x].motor);
                                Console.WriteLine("Quantidade de portas: {0}", carro[x].numero_portas);

                            }else if (placa == caminhao[z].placa)

                            {
                                Console.WriteLine("\n Nome: {0}", caminhao[z].modelo);
                                Console.WriteLine("Cor: {0}", caminhao[z].cor);
                                Console.WriteLine("Ano: {0}", caminhao[z].ano);
                                Console.WriteLine("Quantidade de eixos: {0}", caminhao[z].numero_eixos);
                                Console.WriteLine("Quantidade máxima de carga suportada (KG): {0}", caminhao[z].peso_maximo_carga);
                                Console.WriteLine("Porte do caminhão: {0}", caminhao[z].porte);
                                Console.WriteLine("Quantidade de portas: {0}", caminhao[z].numero_portas);
                            }else
                            {
                                Console.WriteLine("Placa inválida!");
                            }
                        }

                        break;

                    case 4:
                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o modelo do caminhão que você deseja consultar: ");
                        modelo_escolha = Console.ReadLine();
                        for (x = 0; x < tam; x++)
                        {
                            if (modelo_escolha == caminhao[z].modelo)
                            {
                                Console.WriteLine("\n Nome: {0}", caminhao[z].modelo);
                                Console.WriteLine("Cor: {0}", caminhao[z].cor);
                                Console.WriteLine("Ano: {0}", caminhao[z].ano);
                                Console.WriteLine("Quantidade de eixos: {0}", caminhao[z].numero_eixos);
                                Console.WriteLine("Quantidade máxima de carga suportada (KG): {0}", caminhao[z].peso_maximo_carga);
                                Console.WriteLine("Porte do caminhão: {0}", caminhao[z].porte);
                                Console.WriteLine("Quantidade de portas: {0}", caminhao[z].numero_portas);
                            }
                        }
                        break;

                    case 5:
                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o a cor do carro que você deseja consultar: ");
                        cor_escolha = Console.ReadLine();
                        for (x = 0; x < tam; x++)
                        {
                            if (cor_escolha == carro[x].cor)
                            {
                                Console.WriteLine("\n Nome: {0}", carro[x].modelo);
                                Console.WriteLine("Cor: {0}", carro[x].cor);
                                Console.WriteLine("Ano: {0}", carro[x].ano);
                                Console.WriteLine("Placa: {0}", carro[x].placa);
                                Console.WriteLine("Capacidade do porta - malas: {0}", carro[x].PortaMala);
                                Console.WriteLine("Capacidade do bagageiro: {0}", carro[x].bagageiro);
                                Console.WriteLine("Marca do motor: {0}", carro[x].motor);
                                Console.WriteLine("Quantidade de portas: {0}", carro[x].numero_portas);
                            }
                        }
                        break;


                    case 6:
                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());
                        for (x = 0; x < tam; x++)
                        {
                            Console.WriteLine("\n Nome: {0}", carro[x].modelo);
                            Console.WriteLine("Cor: {0}", carro[x].cor);
                            Console.WriteLine("Ano: {0}", carro[x].ano);
                            Console.WriteLine("Placa: {0}", carro[x].placa);
                            Console.WriteLine("Capacidade do porta - malas: {0}", carro[x].PortaMala);
                            Console.WriteLine("Capacidade do bagageiro: {0}", carro[x].bagageiro);
                            Console.WriteLine("Marca do motor: {0}", carro[x].motor);
                            Console.WriteLine("Quantidade de portas: {0}", carro[x].numero_portas);
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
                                carro[x].ano = int.Parse(Console.ReadLine());
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
                            Console.WriteLine("\n Nome: {0}", caminhao[z].modelo);
                            Console.WriteLine("Cor: {0}", caminhao[z].cor);
                            Console.WriteLine("Ano: {0}", caminhao[z].ano);
                            Console.WriteLine("Quantidade de eixos: {0}", caminhao[z].numero_eixos);
                            Console.WriteLine("Quantidade máxima de carga suportada (KG): {0}", caminhao[z].peso_maximo_carga);
                            Console.WriteLine("Porte do caminhão: {0}", caminhao[z].porte);
                            Console.WriteLine("Quantidade de portas: {0}", caminhao[z].numero_portas);
                        }



                        Console.WriteLine("Digite o nome do caminhão que você deseja ver: ");
                        w = Console.ReadLine();

                        Console.WriteLine("Digite o número de carros que você cadastrou: ");
                        tam = int.Parse(Console.ReadLine());

                        for (z = 0; z < tam; z++)
                            if (w == carro[x].modelo)
                            {
                                Console.WriteLine("\nDigite o modelo do carro: ", z + 1);
                                caminhao[z].modelo = Console.ReadLine();
                                Console.WriteLine("Digite o ano do modelo: ");
                                caminhao[z].ano = int.Parse(Console.ReadLine());
                                Console.WriteLine("Digite a cor do carro: ");
                                caminhao[z].cor = Console.ReadLine();
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
