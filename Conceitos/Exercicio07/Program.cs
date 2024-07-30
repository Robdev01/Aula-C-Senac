using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a nota da 1° prova:");
            int p1 = int.Parse(Console.ReadLine());

            Console.Write("Informe a nota da 2° prova:");
            int p2 = int.Parse(Console.ReadLine());

            Console.Write("Informe a nota da 3° prova:");
            int p3 = int.Parse(Console.ReadLine());

            int media = (p1 + p2 + p3) / 3;

            string resposta = media >= 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"A sua média é {media} e você tá {resposta}");

            Console.ReadKey();
        }
    }
    
}
