using Controllers.Repositorios;
using Entidades;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "ConsultaService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione ConsultaService.svc ou ConsultaService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ConsultaService : IConsulta
    {
        private ConsultaRep rep = new ConsultaRep();

        public void Cadastrar(Consulta obj)
        {
            rep.Cadastrar(obj);
        }

        public Consulta Buscar(int id)
        {
            return rep.Buscar(id);
        }

        public IQueryable<Consulta> Buscar(Dentista dentista)
        {
            return rep.Buscar(dentista);
        }

        public List<Consulta> Buscar(Dentista dentista, DateTime data)
        {
            return rep.Buscar(dentista, data);
        }


        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Consulta objNovo)
        {
            rep.Editar(objNovo);
        }
    }
}
