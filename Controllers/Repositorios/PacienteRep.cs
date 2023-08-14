using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class PacienteRep
    {
        //public void Cadastrar(Paciente obj)
        //{
        //    using (var ctx = new SistemaContext())
        //    {
        //        ctx.Pacientes.Add(obj);
        //        ctx.SaveChanges();
        //    }
        //}

        //public int Cadastrar(Paciente obj)
        //{
        //    using (var ctx = new SistemaContext())
        //    {
        //        ctx.Pacientes.Add(obj);
        //        ctx.SaveChanges();
        //        return obj.Id; // Supondo que a classe Paciente tenha uma propriedade "Id"
        //    }
        //}

        public async Task<int> Cadastrar(Paciente obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Pacientes.Add(obj);
                await ctx.SaveChangesAsync();

                return obj.Id;
            }
        }

        public Paciente Buscar(int id)
        {
            Paciente obj = new Paciente();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Pacientes.Find(id);
            }
            return obj;
        }

        public Paciente BuscarPorCPF(string cpf)
        {
            using (var ctx = new SistemaContext())
            {
                var paciente = ctx.Pacientes.FirstOrDefault(p => p.CPF == cpf);
                return paciente;
            }
        }



        public List<Paciente> Listar()
        {
            using (var ctx = new SistemaContext())
            {
                var Pacientes = (from obj in ctx.Pacientes select obj).OrderBy(x => x.Nome).ToList();
                return Pacientes;
            }
        }


        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Paciente obj = ctx.Pacientes.Find(id);
                ctx.Pacientes.Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Paciente objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Paciente objAntigo = ctx.Pacientes.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.Sexo = objNovo.Sexo;
                objAntigo.Nascimento = objNovo.Nascimento;
                objAntigo.Telefone = objNovo.Telefone;
                objAntigo.Celular = objNovo.Celular;
                objAntigo.Email = objNovo.Email;
                objAntigo.CEP = objNovo.CEP;
                objAntigo.Endereco = objNovo.Endereco;
                ctx.SaveChanges();
            }
        }
    }
}
