using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculo 
{
    class Caminhao : VeiculoR

    {
        public int numero_eixos;
        public double peso_maximo_carga;
        public string porte;

        public Caminhao()
            : base()
        {
            numero_eixos = 0;
            peso_maximo_carga = 0;
            porte =null;
        }
        public Caminhao (string modelo,string fabricante, string cor, int ano, int numero_portas,int placa, int numero_eixos, double peso_maximo_carga,string porte)
            : base(modelo, fabricante, cor, ano, numero_portas,placa)
        {
            this.numero_eixos = numero_eixos;
            this.peso_maximo_carga = peso_maximo_carga;
            this.porte = porte;
        }
        public int Eixos
        {
            get { return numero_eixos; }
            set { numero_eixos = value; }
        }
        public double Peso
        {
            get { return peso_maximo_carga; }
            set { peso_maximo_carga = value; }
        }
        public string Porte
        {
            get { return porte; }
            set { porte = value; }
        }
    }
}
