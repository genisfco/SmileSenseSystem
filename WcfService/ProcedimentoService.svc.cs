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
using Controllers;
using System.Threading.Tasks;

namespace WcfService
{
    public class ProcedimentoService : IProcedimento
    {
        private ProcedimentoRep rep = new ProcedimentoRep();

        //public void Cadastrar(Procedimento obj)
        //{
        //    rep.Cadastrar(obj);
        //}

        public async Task<int> Cadastrar(Procedimento obj)
        {
            int procedimentoID = await rep.Cadastrar(obj);
            return procedimentoID;
        }

        public Procedimento BuscarProcdporIdOdt(int idOdontograma)
        {
            return rep.BuscarProcdporIdOdt(idOdontograma);
        }

        public List<Procedimento> ListarProcedimentosPorIdOdontograma(int idOdontograma)
        {
            return rep.ListarProcedsporIdOdontograma(idOdontograma);
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
