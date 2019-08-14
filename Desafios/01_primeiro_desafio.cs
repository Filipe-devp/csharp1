using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioUm
{
    class Program
    {
        static void Main(string[] args)
        {
            int notaUm, notaDois, notaTres, notaQuatro, media;

            Console.Write("Digite a primeira nota: ");
            notaUm = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            notaDois = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            notaTres = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            notaQuatro = Convert.ToInt32(Console.ReadLine());

            media = (notaUm + notaDois + notaTres + notaQuatro) / 4;

            Console.WriteLine("O aluno teve média " + media);

            Console.ReadKey();
        }
    }
}