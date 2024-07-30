using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto02.if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual sua mensalidade?");
            double mensalidade = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua média:");
            double media = double.Parse(Console.ReadLine());


            double mensalidade_media = mensalidade - (mensalidade * 0.10);
            double nota = media >= 9 ? mensalidade_media : mensalidade;


            Console.WriteLine("Você estuda EAD (sim/não)?");
            string modalidade = Console.ReadLine().ToLower();


            double mensalidade_modalidade = modalidade == "sim" ? mensalidade * 0.15 : 0;
            double mensalidade_com_desconto = nota - mensalidade_modalidade;


            Console.WriteLine($"O valor final da mensalidade é: {mensalidade_com_desconto:F2}");

            Console.ReadKey();
        }
    }
}
    

