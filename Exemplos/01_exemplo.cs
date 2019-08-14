using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome;
            int numUm, numDois;
            
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o primeiro número: ");
            numUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numDois = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("O nome informado foi: " + nome);
            Console.WriteLine("O resultado da soma dos valores informados é de: " + (numUm + numDois));

            Console.ReadKey();
        }
    }
}