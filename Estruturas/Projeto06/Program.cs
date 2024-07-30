using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um nome");
            string nome = Console.ReadLine();            

            string resposta = string.IsNullOrEmpty(nome) ? "Nenhum nome fornecido" : nome;

            Console.WriteLine(resposta);
            Console.ReadKey();



        }
    }
}
