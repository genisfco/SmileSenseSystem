using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    public class OdontogramaService : IOdontograma
    {
        private OdontogramaRep rep = new OdontogramaRep();

        public void Cadastrar(Odontograma obj)
        {
            rep.Cadastrar(obj);
        }

        public Odontograma BuscarOdontograma(int id)
        {
            return rep.BuscarOdontograma(id);
        }

        public Odontograma BuscarOdtPorIdPaciente(int idPaciente)
        {
            return rep.BuscarOdtPorIdPaciente(idPaciente);
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Odontograma objNovo)
        {
            rep.Editar(objNovo);
        }


    }
}
