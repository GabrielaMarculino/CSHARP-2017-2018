using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogador
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Composição: classes criadas a partir da classe mãe
            //que compõem as características da classe mãe.

            // 2- O jogador de vídeo-game utiliza um computador,ou seja,
            //pega-se as características do computador através de uma
            //classe chamada COMPUTER e  as características do jogador
            //através da classe PLAYER, juntos eles compõem um JOGADOR DE VÍDEO-GAME.


            Player j1 = new Player();                                               
                                                                                   
            j1.setNome("Soraka");
            Computer c1 = new Computer();
            j1.setIdade(19);                                                        
                                                                                    
            Console.WriteLine("O nome do jogador é: " + (j1.getNome()));            
            Console.WriteLine("A idade do jogador é: " + (j1.getIdade()));          


            c1.setMarca("INTEL");
            c1.setCor("Vermelho");
            c1.setModelo("PC BATTLEBOX ULTIMATE");

            Console.WriteLine("A marca do Personal Computer é: " + (c1.getMarca()));
            Console.WriteLine("A cor é: " + (c1.getCor()));
            Console.WriteLine("O modelo é: " + (c1.getModelo()));

            j1.setComputer(c1);
            //Este códido poderia ser "traduzido" para "O jogador TEM um computador

            c1.setMarca("Samsung");
            //a partir deste comando a marca que era INTEL foi alterada na memória para SAMSUNG

            Console.WriteLine("A marca do Personal Computer foi alterada para: " + (j1.getComputer().getMarca()));
            //Com este código percebemos que PLAYER e COMPUTER estão interligados
         
            Console.ReadKey();
        }
    }
}
