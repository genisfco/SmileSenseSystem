using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    [ServiceContract]
    public interface IPaciente
    {
        
       
            [OperationContract]
            void Cadastrar(Paciente obj);

            [OperationContract]
            Paciente Buscar(int id);

            [OperationContract]
            List<Paciente> Listar();

            [OperationContract]
            void Deletar(int id);

            [OperationContract]
            void Editar(Paciente objNovo);
        
    }
}
