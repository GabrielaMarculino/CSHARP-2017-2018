using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo
{
    class Carro : VeiculoR
    {
        public int capacidadePortaMala;
        public Boolean bagageiro;
        public string motor;

        public Carro()
            : base()
        {
            capacidadePortaMala = 0;
            bagageiro = true;
            motor = null;
            
        }
        public Carro(string modelo, string fabricante, string cor, int ano, int numero_portas,int placa, int capacidadePortaMala,bool bagageiro, string motor)
            :base(modelo,fabricante,cor,ano,numero_portas,placa)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.motor = motor;
            
        }
        public int PortaMala
        {
            get { return capacidadePortaMala; }
            set {capacidadePortaMala = value; }
        }
        public bool Bagagem
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }
        public string Motor
        {
            get { return motor; }
            set { motor = value; }
        }
       
    }
}
