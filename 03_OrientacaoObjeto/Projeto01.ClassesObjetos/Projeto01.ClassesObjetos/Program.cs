using Projeto01.ClassesObjetos.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            celulares android = new celulares();
            android.porcentagemBateria = 100;
            android.PossuiBateria = true;
            android.MEI = 5646;
            android.IP = "v2471975";
            android.marca = "Samsung";
            android.modelo = "A15";

           celulares iphone = new celulares();
            //iphone.porcentagemBateria = 0;
            //iphone.PossuiBateria = false;
            //iphone.MEI = 7458;
            //iphone.IP = "X3235684";
            //iphone.marca = "Aple";
            //iphone.modelo = "Iphone 8";


           // Console.Write(android.RetornarDados());
           
            Console.Write("\n ------------ \n");
         
            iphone.ReceberDados(100, true, 5646, "v2471975", "Samsung","a15");
            Console.Write(iphone.RetornarDados());
            Console.ReadKey();

        }
    }
}
