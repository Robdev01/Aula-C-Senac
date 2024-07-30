using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero:");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe um numero:");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Informe um numero:");
            int n3 = int.Parse(Console.ReadLine());

            int media_aritmetica = (n1 + n2 + n3) / 3;

            Console.WriteLine($"A média dos números digitados é {media_aritmetica}");

            Console.ReadKey();
        }
    }
}
