﻿using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class DentistaService : IDentista
    {
        private DentistaRep rep = new DentistaRep();
        
        //public void Cadastrar(Dentista obj)
        //{
        //    rep.Cadastrar(obj);
        //}

        public async Task<int> Cadastrar(Dentista obj)
        {
            int dentistaId = await rep.Cadastrar(obj);
            return dentistaId;
        }

        public Dentista Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public Dentista BuscarPorNome(string nome)
        {
            return rep.BuscarPorNome(nome);
        }


        public List<Dentista> Listar()
        {
            return rep.Listar();
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Dentista objNovo)
        {
            rep.Editar(objNovo);
        }
    }
}
