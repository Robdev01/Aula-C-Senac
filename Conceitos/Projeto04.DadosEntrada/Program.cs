using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.DadosEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtendo os dados de entrada fornecidos pelo usuario.
            Console.Write("Informe o seu nome: ");
            //Write nao pula para a linha baixo.
            string nome = Console.ReadLine();
            //ReadLine aguarda o usuario apertar ENTER para continuar.

            Console.Write("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            string resposta = "\nNome informado: " + nome +
                "\nIdade informada: " + idade + " anos" +
                "\nAltura informada: " + altura;

            Console.WriteLine(resposta);
            //ReadLine sempre retorna string.
            Console.ReadKey();
        }
    }
}
