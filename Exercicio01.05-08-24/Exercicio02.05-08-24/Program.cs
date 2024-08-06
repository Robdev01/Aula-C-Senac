using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02._05_08_24
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            int soma = 0;
            for (int i = 0; i <= 100; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine($"A soma dos numeros de 1 a 100 é igual {soma}");
            Console.ReadKey();

        }
    }
}
