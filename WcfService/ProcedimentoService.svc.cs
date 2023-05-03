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
    public class ProcedimentoService : IProcedimento
    {
        private ProcedimentoRep rep = new ProcedimentoRep();

        public void Cadastrar(Procedimento obj)
        {
            rep.Cadastrar(obj);
        }

        public Procedimento Buscar(int id)
        {
            return rep.Buscar(id);
        }

        

        public List<Procedimento> Listar()
        {
            return rep.Listar();
        }


        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Procedimento objNovo)
        {
            rep.Editar(objNovo);
        }

    }
}
