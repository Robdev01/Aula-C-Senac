using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor da compra:");
            double valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade:");
            int idade = int.Parse(Console.ReadLine());

            double desconto_para60 = valor * 0.15;
            double desconto = idade > 60 ? valor - desconto_para60 : valor;

            Console.WriteLine($"Seu idade {idade} e o valor que você vai pagar é {desconto} ");


            Console.ReadKey();
        }
    }
}
