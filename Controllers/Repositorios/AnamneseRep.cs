using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class AnamneseRep
    {
        public void Cadastrar(Anamnese obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Anamneses.Add(obj);
                ctx.SaveChanges();
            }


        }

        //BUSCA ANAMNESE PELO ID DA ANAMNESES
        //public Anamnese Buscar(int id)    
        //{
        //    Anamnese obj = new Anamnese();
        //    using (var ctx = new SistemaContext())
        //    {
        //        obj = ctx.Anamneses.Find(id);
        //    }
        //    return obj;
        //}


        //BUSCA ANAMNESE PELO ID DO PACIENTE
        public Anamnese Buscar(int idPaciente)
        {
            Anamnese obj = new Anamnese();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Anamneses.FirstOrDefault(anm => anm.IdPaciente == idPaciente);
            }
            return obj;
        }
        ///////////////



        //public IQueryable<Anamnese> Buscar(Paciente paciente)
        //{
        //    var ctx = new SistemaContext();
        //    var Anamneses = ctx.Anamneses.Where(anm => anm.IdPaciente == paciente.Id);
        //    return Anamneses;
        //}    


        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Anamnese obj = ctx.Anamneses.Find(id);
                ctx.Anamneses.Remove(obj);
                ctx.SaveChanges();
            }
        }


        public void Editar(Anamnese objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Anamnese objAntigo = ctx.Anamneses.Find(objNovo.IdAnamnese);
                objAntigo.IdPaciente = objNovo.IdPaciente;
                objAntigo.Diabetes = objNovo.Diabetes;
                objAntigo.Hipertensao = objNovo.Hipertensao;
                objAntigo.Cardiopatia = objNovo.Cardiopatia;
                objAntigo.Uso_Continuo = objNovo.Uso_Continuo;
                objAntigo.Medicamento_Continuo = objNovo.Medicamento_Continuo;
                objAntigo.Alergia_Medicamento = objNovo.Medicamento_Continuo;
                objAntigo.Alergia_Qual_Medicamento = objNovo.Alergia_Qual_Medicamento;
                objAntigo.Problemas_Hemorragicos = objNovo.Problemas_Hemorragicos;
                objAntigo.Motivo_Problemas = objNovo.Motivo_Problemas;
                objAntigo.Complicacoes_Odonto = objNovo.Complicacoes_Odonto;
                objAntigo.Porque_Complicacoes = objNovo.Porque_Complicacoes;
                objAntigo.Doenca_Cong = objNovo.Doenca_Cong;
                objAntigo.Qual_Doenca = objNovo.Qual_Doenca;                 
                ctx.SaveChanges();
            }
        }
    }
}
