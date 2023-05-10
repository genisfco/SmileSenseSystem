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
    public class AnamneseService : IAnamnese
    {
        private AnamneseRep rep = new AnamneseRep();

        public void Cadastrar(Anamnese obj)
        {
            rep.Cadastrar(obj);
        }

        public Anamnese Buscar(int id)
        {
            return rep.Buscar(id);
        }
       

        
        public List<Anamnese> Listar()
        {
            return rep.Listar();
        }


        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Anamnese objNovo)
        {
            rep.Editar(objNovo);
        }

        
    }
}
