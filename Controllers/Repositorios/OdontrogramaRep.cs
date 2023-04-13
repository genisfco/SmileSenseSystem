using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class OdontogramaRep
    {
        public void Cadastrar(Odontograma obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Odontogramas.Add(obj);
                ctx.SaveChanges();
            }

        }


        public Odontograma Buscar(int id)
        {
            Odontograma obj = new Odontograma();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Odontogramas.Find(id);
            }
            return obj;
        }


        public IQueryable<Odontograma> Buscar(Paciente paciente)
        {
            var ctx = new SistemaContext();
            Paciente p = new Paciente();
            var Odontogramas = ctx.Odontogramas.Where(anm => anm.IdPaciente == paciente.Id);
            return Odontogramas;
        }


        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Odontograma obj = ctx.Odontogramas.Find(id);
                ctx.Odontogramas.Remove(obj);
                ctx.SaveChanges();
            }
        }


        public void Editar(Odontograma objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Odontograma objAntigo = ctx.Odontogramas.Find(objNovo.IdOdontograma);
                objAntigo.IdPaciente = objNovo.IdPaciente;
                objAntigo.Procedimentos = objNovo.Procedimentos;
                objAntigo.Imagem = objNovo.Imagem;

                ctx.SaveChanges();
            }
        }
    }
}

