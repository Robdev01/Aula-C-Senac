using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Uso_switch
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe um número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("informe um número:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("informe qual operação: +, -, *, /");

            string opera = Console.ReadLine();
            double resul = 0;

            switch (opera)
            {
                case "+": resul = num1 + num2; break;
                case "-": resul = num1 - num2; break;
                case "*": resul = num1 * num2; break;
                case "/": resul = num1 / num2; break;

            }
            Console.WriteLine($"O resultado {resul}");
            Console.ReadKey();


        }

    }
}