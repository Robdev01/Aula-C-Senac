using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Uso_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie um programa que pergunte ao usuário a temperatura
             * em graus Celsius e determine se a temperatura está abaixo de zero
             * (congelante), entre 0 e 30 graus (temperatura normal) ou acima de 30
             * graus (quente).
             */

            Console.WriteLine("Informe uma temperatura:");
            int temp = int.Parse(Console.ReadLine());

            string temperatura = "";

            if (temp > 0)
            {
                temperatura = "Temperatura normal";
            }
            else if (temp > 30)
            {
                temperatura = "Quente";
            }
            else temperatura = "Congelante";
           

            Console.WriteLine($" Temperatura {temperatura} {temp}°C");
            Console.ReadKey();
            

        }
    }
}
