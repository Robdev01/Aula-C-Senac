using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.Comandoif01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("informe seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("informe sua idade:");
            int idade = int.Parse(Console.ReadLine());

            string ingresso = "";

            if (idade <= 17) {
               ingresso = "Valor R$ 30,00";
            }
            else if (idade >= 18 && idade <= 50)
            {
               ingresso = "Valor R$ 50,00";
            } else
            {
               ingresso = "Valor R$ 20,00";
            }

            Console.WriteLine($"Olá {nome}, sua idade é {idade} e você pagara {ingresso}");

            Console.ReadKey();
        }
    }
}
