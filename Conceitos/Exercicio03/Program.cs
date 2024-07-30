using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero:");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe outro numero:");
            int n2 = int.Parse(Console.ReadLine());

            int maior_menor = (n1 > n2) ? n1: n2;

            Console.WriteLine($"Seu maior número é {maior_menor}");
            Console.ReadKey();
            

        }
    }
}
