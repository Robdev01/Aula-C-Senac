using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um numero:");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe outro numero:");
            int n2 = int.Parse(Console.ReadLine());

            // Aqui somo os dois numeros e informo se o modulo sobrar 1 é impar se nao par

            string impar_par = (n1 + n2) % 2 ==0 ? "Par": "Impar";

            Console.WriteLine(impar_par);
            Console.ReadKey();

        }
    }
}
