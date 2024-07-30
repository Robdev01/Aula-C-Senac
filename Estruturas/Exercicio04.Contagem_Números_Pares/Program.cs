using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Contagem_Números_Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie um programa que conta e exibe todos os números pares de 1 a 50 usando um loop
             */

            int contador = 0;
            
            while (contador <= 50)
                {
                 Console.WriteLine(contador);
                 contador += 2;
               
                 
                }

               Console.WriteLine("Fim da bagaça....");
               Console.ReadKey();
            
        }
    }
}
