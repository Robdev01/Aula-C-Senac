using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salario:");
            double salario = double.Parse(Console.ReadLine());

            double  salario_imposto = salario > 3000 ? salario+salario*0.2 : salario+salario*0.1;

            Console.WriteLine($"Seu salario novo é {salario_imposto}");

            Console.ReadKey();
        }
    }
}
