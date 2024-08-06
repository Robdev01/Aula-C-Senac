using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04._05_08_24
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tabela de Multiplicação (1 a 10)");
            Console.WriteLine("-------------------------------");


            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    // Calcula o produto
                    int resultado = i * j;

                    // Exibe o resultado formatado
                    // O formato "{0,4}" alinha o texto em colunas de 4 caracteres
                    Console.Write(resultado.ToString().PadLeft(5));
                }

                // Pula para a próxima linha após cada linha da tabela ser impressa
                Console.WriteLine();
            }

            // Aguarda uma tecla ser pressionada para encerrar
            Console.ReadKey();
        }
        
    }
}