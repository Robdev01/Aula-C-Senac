using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto04.ComandoSwitch02
{
    class Program
    {
        enum DiasSemanas 
        {
            Domingo = 1,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado        
        }

        static void Main(string[] args)
        {
            //Declarando variavel unum
            //DiasSemanas dias = DiasSemanas.Quarta;
            Console.WriteLine("Informe um dia de semana (1 a 7): ");
            int valor = int.Parse(Console.ReadLine());
            DiasSemanas dias = (DiasSemanas)valor;

            string diasTexto;
            switch (dias)
            {
                case DiasSemanas.Domingo: diasTexto = "Domingo"; break;
                case DiasSemanas.Segunda: diasTexto = "Segunda Feira"; break;
                case DiasSemanas.Terca: diasTexto = "Terça Feira"; break;
                case DiasSemanas.Quarta: diasTexto = "Quarta Feira"; break;
                case DiasSemanas.Quinta: diasTexto = "Quinta Feira"; break;
                case DiasSemanas.Sexta: diasTexto = "Sexta Feira"; break;
                default: diasTexto =  "Sabado"; break;
            }

          

            Console.WriteLine(diasTexto);
            Console.ReadKey();

        }
    }
}
