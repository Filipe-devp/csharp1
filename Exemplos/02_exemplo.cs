using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            // forma 01
            carro carro;
            carro = new carro();

            // forma 02
            carro carroDois = new carro();

            Console.WriteLine("marca:" + carro.marca);
            carro.marca = "ford";
            Console.WriteLine("marca" + carro.marca);
            
            // trabalhando com metodos
            Console.WriteLine("luzes internas:" + carro.luzesInternas);
            carro.abrirportas();
            Console.WriteLine("quando abrir as portas " + carro.luzesInternas);
            carro.fecharportas();
            Console.WriteLine(" quando fechar as portas " + carro.luzesInternas);

            string statusfarol = carro.acenderFarolautomaticamente();
            Console.WriteLine(" status do farol " + statusfarol);

            Console.ReadKey();
        }
    }
}
