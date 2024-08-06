using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto01.ClassesObjetos.Classe
{
    class celulares
    {
        #region Propriedades da Classe
        public int porcentagemBateria { get; set; }

        public bool PossuiBateria { get; set; }

        public int MEI { get; set; }

        public string IP { get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        public string StatusBateria => PossuiBateria == true ? "Possui bateria" : "Não possuo bateria";
        #endregion

        #region Métodos da Classe

        public string RetornarDados()
        {
            string resposta = $"Dados do celular: \n Porcentagem Bateria: {porcentagemBateria}" +
                $"\n Possui Bateria: {StatusBateria}\n MEI: {MEI} \n IP:{IP} \n marca: {marca} \n modelo: {modelo}";
            return resposta;
        }        

      
        public void ReceberDados(int _porcentagemBateria, bool _PossuiBateria, int _MEI, string _IP, string _marca, string _modelo)// void não reclama de nada
        {
            porcentagemBateria = _porcentagemBateria;
            PossuiBateria = _PossuiBateria;
            MEI = _MEI;
            IP = _IP;
            marca = _marca;
            modelo = _modelo;
        }
        #endregion

    }
}
