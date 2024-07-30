using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05.operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operador de divisão inteira
            // Console.Write irá mostra na tela.

            Console.Write("Informe um número inteiro: ");
            // int.Parse irá converter a string para Int
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe outro número inteiro: ");

            int n2 = int.Parse(Console.ReadLine());
            // para devolver decimal é só colocar o Double e para mostra inteiro coloca int 
            Double resultado =(Double) n1 / (Double)n2;

            Double soma = (Double)n1 + (Double)n2;

            Double multi = (Double)n1 * (Double)n2;

            Console.WriteLine($"Divisão inteira: {resultado} ");
            Console.WriteLine($"Soma : {soma} ");
            Console.WriteLine($"Multiplicação : {multi} ");

            // esse Console.ReadKey ira rodar o app
            Console.ReadKey();
        }
    }
}
