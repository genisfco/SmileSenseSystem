﻿using Controllers.Context;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Repositorios
{
    public class DentistaRep
    {
        //public void Cadastrar(Dentista obj)
        //{
        //    using (var ctx = new SistemaContext())
        //    {
        //        ctx.Dentistas.Add(obj);
        //        ctx.SaveChanges();
        //    }
        //}

        public async Task<int> Cadastrar(Dentista obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Dentistas.Add(obj);
                await ctx.SaveChangesAsync();

                return obj.Id;
            }
        }


        public Dentista Buscar(int id)
        {
            Dentista obj = new Dentista();
            using (var ctx = new SistemaContext())
            {
                obj = ctx.Dentistas.Find(id);
            }
            return obj;
        }

        public Dentista BuscarPorNome(string nome)
        {
            using (var ctx = new SistemaContext())
            {
                var dentista = ctx.Dentistas.FirstOrDefault(d => d.Nome == nome);
                return dentista;
            }
        }


        public List<Dentista> Listar()
        {

            using (var ctx = new SistemaContext())
            {
                var Dentistas = (from obj in ctx.Dentistas select obj).OrderBy(x => x.Nome).ToList();
                return Dentistas;
            }
        }


        public void Deletar(int id)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista obj = ctx.Dentistas.Find(id);
                ctx.Dentistas.Remove(obj);
                ctx.SaveChanges();
            }
        }

        public void Editar(Dentista objNovo)
        {
            using (var ctx = new SistemaContext())
            {
                Dentista objAntigo = ctx.Dentistas.Find(objNovo.Id);
                objAntigo.Nome = objNovo.Nome;
                objAntigo.Especialidade1 = objNovo.Especialidade1;
                objAntigo.Especialidade2 = objNovo.Especialidade2;
                objAntigo.Email = objNovo.Email;
                objAntigo.Telefone = objNovo.Telefone;
                objAntigo.Celular = objNovo.Celular;
                ctx.SaveChanges();
            }
        }
    }
}
