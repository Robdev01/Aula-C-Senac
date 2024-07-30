using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.ComandoSwitch01
{
    class Program
    {
        static void Main(string[] args)
        {
            // o usuario informa mes de 1 a 12 e o programa responde numero de dias no mês.

            Console.WriteLine("Informe o mês 1 a 12");
            int mes = int.Parse(Console.ReadLine());
            int dias;

            switch (mes)
            {
                case 2: dias = 28; break;
                case 4: case 6: case 9: case 11: dias = 30; break;
                default: dias = 31; break;

                    // para eliminar todas essas linhas colocamos esse case e default isso deixa o cod mas limpo
                    /*case 1: dias = 31; break;
                    case 2: dias = 28; break;
                    case 3: dias = 31; break;
                    case 4: dias = 30; break;
                    case 5: dias = 31; break;
                    case 6: dias = 30; break;
                    case 7: dias = 31; break;
                    case 8: dias = 31; break;
                    case 9: dias = 30; break;
                    case 10: dias = 31; break;
                    case 11: dias = 31; break;
                    case 12: dias = 31; break; */       
            }
            Console.WriteLine($"O mês {mes} possui {dias} dias");
            Console.ReadKey();

        }
    }
}
