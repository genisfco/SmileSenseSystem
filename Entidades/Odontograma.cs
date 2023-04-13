using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Odontograma
    {
        public int IdOdontograma { get; set; }
        public int IdPaciente { get; set; }
        public string Procedimentos { get; set; }
        public string Imagem { get; set; }
    }
}
