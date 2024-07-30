using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        enum Estacao
         {
           verao = 1,
           inverno,
           outono,
           primavera            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número de 1 a 4 que eu te falo qual a estação");
            int est = int.Parse(Console.ReadLine());
            Estacao num  = (Estacao)est;

            string text = "";

            switch (num)
            {
                case Estacao.verao: text = "Verão, Solzão";  break;
                case Estacao.inverno: text = "Inverno, Frio da mulestia"; break;
                case Estacao.outono: text = "Outono, as flores caem."; break;
                case Estacao.primavera: text = "Primavera, as flores nascem."; break;

            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
