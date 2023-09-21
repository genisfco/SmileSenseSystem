using System;

namespace Entidades
{
    public class Logger
    {
        public int IDLogger { get; set; }   
        public int IDUser { get; set; }
        public DateTime Data_Logger { get; set; }
        public string Tipo_Logger { get; set; }
        
        public string Tabela_Logger { get; set; }
        public int ID_Tabela { get; set; }

        public string Observacao { get; set; }
    }
}
