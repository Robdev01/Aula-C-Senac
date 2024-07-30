using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto03.Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            //DADOS INICIAIS
            string nomePessoa = "Lucas Aragão ";  //class
            
            //int? idade = 31;  //struct

            Nullable<int> idade = 31;

            //double? salario = 1000; //struct

            Nullable<double> salario = 1000;

            //double? altura = 1.75; //struct

            Nullable<double> altura = 1.75;


            //Alterando os dados.
            //nomePessoa = nomePessoa + "Feliciano";

      
            //definindo uma resposta.
            string resposta = $"Nome da pessoa: {nomePessoa}" +
                $"\nIdade: {idade} \nSalário: {salario:c} " +
                $"\nAltura: {altura}";

            //currency

            Console.WriteLine(resposta);

            //Suponha que nao tenhamos nenhum dados da pessoa em questao.
            nomePessoa = null;
            idade = null;
            salario = null;
            altura = null;


            Console.WriteLine(nomePessoa);
            Console.ReadKey();

        }
    }
}
