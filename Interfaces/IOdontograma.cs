using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interfaces
{
    [ServiceContract]
    public interface IOdontograma
    {
        [OperationContract]
        void Cadastrar(Odontograma obj);

        [OperationContract(Name = "BuscarOdontograma")]
        Odontograma BuscarOdontograma(int id);

        [OperationContract]
        Odontograma BuscarOdtPorIdPaciente(int idPaciente);

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Odontograma objNovo);
    }
}
