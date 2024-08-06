using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03._05_08_24
{
    class Program
    {
        static void Main(string[] args)
               
        {
            Console.WriteLine("Informe uma palavra:");
            string palavra = Console.ReadLine();
            string reverso = "";

            for (int i = palavra.Length -1; i >=0 ; i--)
            {
                reverso = reverso + palavra[i].ToString();
            }            

            // Exibe a palavra invertida
            Console.WriteLine(reverso);

            Console.ReadKey();
        }
    }



}
