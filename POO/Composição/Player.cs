using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogador
{
    class Player
    {
        // 1-Variável computador do tipo Computador, porque ela compõem uma característica do Jogador.
        // O jogador USA/TEM um computador.
        // 2-É uma maneira de vincular as classes PLAYER e COMPUTER.
        // 3-Não é uma herança.
        // 4-Coloca-se tecnicamente os atributos de COMPUTER dentro da classe PLAYER.

        private string nome;
        private int idade;
        private Computer computer; 
        public Computer getComputer()
        {
            return computer;
        }

        public void setComputer(Computer computer)
        {
            this.computer = computer;
        }
                                                        //Getters e Setters
        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

    }
}

