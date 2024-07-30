using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variaveis.
            //Variaveis servem para armazenas dados para uso posterior.

            //variáveis inteiras.

            sbyte medida = 127; // -128 a 127
            byte tamanho = 255; // 0 a 255
            short quantidade = 100; // -32768 a 32767
            int idade = 34; //-2147483648 a 2147483647 

            //comportamento dos tipos inteiros
            byte b1 = 100;
            byte b2 = 160;
            byte soma = (byte)(b1 + b2); //typecast (molde)

            //O valor de b1 + b2 = soma;

            //interpolação.
            Console.WriteLine($"O valor de {b1} + {b2} = {soma}");

            //variaveis reais - float(32bits), double (64bits)
            float f1 = 10;
            float f2 = (float)10.0;

            Console.WriteLine($"f1 = {f1}");
            Console.WriteLine($"f2 = {f2}");

            //Variaveis booleanas ou lógicas.

            bool bl1 = false;
            bool bl2 = true;
            bool bl3 = b2 > 10; //atribuindo uma comparacao.
            bool bl4 = (b2 == 10); //comparacao.

            Console.WriteLine($"bl1 = {bl1}");
            Console.WriteLine($"bl2 = {bl2}");
            Console.WriteLine($"bl3 = {bl3}");
            Console.WriteLine($"bl4 = {bl4}");








            Console.ReadKey();

        }
    }
}
