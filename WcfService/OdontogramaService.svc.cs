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

        public Odontograma Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public IQueryable<Odontograma> Buscar(Odontograma odontograma)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Odontograma> Buscar(Paciente paciente)
        {
            return rep.Buscar(paciente);
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
