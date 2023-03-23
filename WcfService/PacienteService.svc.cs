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
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "PacienteService" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione PacienteService.svc ou PacienteService.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class PacienteService : IPaciente
    {
        private PacienteRep rep = new PacienteRep();

        public void Cadastrar(Paciente obj)
        {
            rep.Cadastrar(obj);
        }

        public Paciente Buscar(int id)
        {
            return rep.Buscar(id);
        }


        public List<Paciente> Listar()
        {
            return rep.Listar();
        }

        public void Deletar(int id)
        {
            rep.Deletar(id);
        }

        public void Editar(Paciente objNovo)
        {
            rep.Editar(objNovo);
        }
    }
}
