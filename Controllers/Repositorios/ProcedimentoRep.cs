using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class ProcedimentoRep
    {
        public void Cadastrar(Procedimento obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Procedimentos.Add(obj);
                ctx.SaveChanges();
            }

        }

        //BUSCA PROCEDIMENTO PELO ID DO ODONTOGRAMA
        public Procedimento Buscar(int idOdontograma)
        {
            Procedimento obj = new Procedimento();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Procedimentos.FirstOrDefault(anm => anm.IdOdontograma == idOdontograma);
            }
            return obj;
        }


        public List<Procedimento> Listar()
        {
            using (var ctx = new SistemaContext())
            {
                var Procedimentos = (from obj in ctx.Procedimentos select obj).OrderBy(x => x.IdOdontograma).ToList();
                return Procedimentos;
            }
        }


        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Procedimento obj = ctx.Procedimentos.Find(id);
                ctx.Procedimentos.Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Procedimento objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Procedimento objAntigo = ctx.Procedimentos.Find(objNovo.IdProcedimento);
                objAntigo.IdOdontograma = objNovo.IdOdontograma;
                objAntigo.IdDentista = objNovo.IdDentista;
                objAntigo.Cirurgiao = objNovo.Cirurgiao;
                objAntigo.Elemento = objNovo.Elemento;
                objAntigo.Face = objNovo.Face;
                objAntigo.Especialidade = objNovo.Especialidade;
                objAntigo.Procedimento_realizado = objNovo.Procedimento_realizado;
                objAntigo.Data = objNovo.Data;

                ctx.SaveChanges();
            }
        }
    }
}
