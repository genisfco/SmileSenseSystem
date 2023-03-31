using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class ConsultaRep
    {
        public void Cadastrar(Consulta obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Consultas.Add(obj);
                ctx.SaveChanges();
            }


        }


        public Consulta Buscar(int id)
        {
            Consulta obj = new Consulta();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Consultas.Find(id);
            }
            return obj;
        }


        public IQueryable<Consulta> Buscar(Dentista dentista)
        {
            var ctx = new SistemaContext();
            Paciente p = new Paciente();
            var Consultas = ctx.Consultas.Where(c => c.IdDentista == dentista.Id);
            return Consultas;
        }


        public List<Consulta> Buscar(Dentista dentista, DateTime data)
        {
            var ctx = new SistemaContext();
            List<Consulta> Consultas = new List<Consulta>();
            var queryConsultas = ctx.Consultas.Where(c => c.IdDentista == dentista.Id);
            foreach (var consulta in queryConsultas)
            {
                if (consulta.Data == data)
                {
                    Consultas.Add(consulta);
                }
            }
            return Consultas;
        }



        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Consulta obj = ctx.Consultas.Find(id);
                ctx.Consultas.Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Consulta objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Consulta objAntigo = ctx.Consultas.Find(objNovo.IdConsulta);
                objAntigo.IdPaciente = objNovo.IdPaciente;
                objAntigo.IdDentista = objNovo.IdDentista;
                objAntigo.HoraMarcada = objNovo.HoraMarcada;
                objAntigo.HoraInicio = objNovo.HoraInicio;
                objAntigo.HoraFim = objNovo.HoraFim;
                objAntigo.Data = objNovo.Data;
                objAntigo.Observacao = objNovo.Observacao;
                objAntigo.Status = objNovo.Status;
                ctx.SaveChanges();
            }
        }
    }
}
