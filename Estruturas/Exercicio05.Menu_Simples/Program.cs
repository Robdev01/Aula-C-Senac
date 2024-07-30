using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.Menu_Simples
{
    class Program
    {
        static void Main(string[] args)
        {/*
          * Crie um programa que apresenta um menu simples ao usuário com opções de 1 a 3. 
          * O programa deve continuar exibindo o menu até que o usuário escolha a 
          * opção 3 para sair, usando um loop `do-while`.
          * 
          */


            int num = 0;
            do
            {
                Console.WriteLine("Informe um número de 1 a 3:");
                num = int.Parse(Console.ReadLine());


            } while (num != 3);

            Console.WriteLine("Achou....");
            Console.ReadKey()
;
        }
    }
}

  
