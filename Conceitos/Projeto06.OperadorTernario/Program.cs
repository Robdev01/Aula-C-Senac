using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar a idade de uma pessoa
            //Console.Write("Informe sua idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //string resposta = idade < 18 ? "Menor de Idade" : "Maior de Idade";

            //Console.WriteLine($"Você é {resposta}");
            Console.WriteLine("Em que ano estamos");

            int ano = int.Parse(Console.ReadLine());

            string diasFevereiro = ano % 4 == 0 ? "Não bissexto" :"Bissexto";

            Console.WriteLine($"O ano {ano} é {diasFevereiro} ");


            Console.ReadKey();

        }
    }
}
