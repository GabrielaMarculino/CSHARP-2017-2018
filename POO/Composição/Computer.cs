using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogador
{
    class Computer
    {
        private string marca;
        private string cor;
        private string modelo;

        public string getMarca()
        {
            return marca;
        }

        public void setMarca(string marca)
        {
            this.marca = marca;
        }
                                              //Getters e Setters dos atributos da classe Computer.
        public string getCor()
        {
            return cor;
        }

        public void setCor(string cor)
        {
            this.cor = cor;
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
    }
}



