using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01._05_08_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Vamos Brincar de tabuada..");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Informe um numero que te passaremos a tabuada:");
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");

            }
            
            Console.ReadKey();


        }
    }
}
