using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto07.Coalescencia
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto1 = "Curso C#";
            string texto2 = null;

            //usando operador ternario
            string resposta1 = (texto2 == null) ?
                texto1: texto2;

            //usando o operador de coalescencia
            //?? analise se for nulo.
            string resposta2 = texto2 ?? texto1;

            Console.WriteLine(resposta1);
            Console.WriteLine(resposta2);
            Console.ReadKey();
            




        }
    }
}
