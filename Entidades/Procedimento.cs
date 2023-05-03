using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Procedimento
    {
        public int IdProcedimento { get; set; }
        public int IdDentista { get; set; }
        public int IdOdontograma { get; set; }
        public string Cirurgiao { get; set; }
        public string Elemento { get; set; }
        public string Face { get; set; }
        public string Especialidade { get; set; }
        public string Procedimento_realizado { get; set; }
        public DateTime Data { get; set; }        
    }
}
