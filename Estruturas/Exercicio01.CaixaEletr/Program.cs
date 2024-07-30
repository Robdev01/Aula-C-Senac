using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.CaixaEletr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu valor de saque: ");
            int valor = int.Parse(Console.ReadLine());

            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;

            // verifica se o número é multiplo de 5
            if (valor % 5 != 0)
            {
                Console.WriteLine("Valor inválido para saque. O valor deve ser múltiplo de 5.");
            }
            else
            {
                // verifica a quantidade de cada nota
                nota50 = valor / 50;
                valor %= 50;
                
                nota20 = valor / 20;
                valor %= 20;
                
                nota10 = valor / 10;
                valor %= 10;
                
                nota5 = valor / 5;
                
                Console.WriteLine($"Notas de 50: {nota50}");
                Console.WriteLine($"Notas de 20: {nota20}");
                Console.WriteLine($"Notas de 10: {nota10}");
                Console.WriteLine($"Notas de 5: {nota5}");
            }

            Console.ReadKey(); ;


        }
    }
}
