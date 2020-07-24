using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateR
{
    class Program :program 
    {
        // 1- Delegação é o "encapsulamento do método" nomeado ou anônimo.
        // 2- São fortemente tipados e seguros.
        // 3- Pode-se instanciar o método delegado em qualquer classe.
        // 4- Pode-se convocar o mesmo método delegado, porém, com diferentes nomes.

        private static object qualquerFuncao;

        static void Main(string[] args)
        { 
            //Instanciando a delegação.
            UmExemploDeDelegate OI = new UmExemploDeDelegate(program.qualquerFuncao);

            //Convocando o "método" delegado.
            OI();
            Console.ReadKey();
        }
    }

    //Declarando o método delegado.
    public delegate void UmExemploDeDelegate();

    class program
    {
        //Convovando a função do método delegado.
        public static void qualquerFuncao()
        {
            Console.WriteLine("Oi, sou uma delegação");
        }
    }
}