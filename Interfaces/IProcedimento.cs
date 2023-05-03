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
    public interface IProcedimento
    {
        [OperationContract]
        void Cadastrar(Procedimento obj);

        [OperationContract(Name = "BuscarPorIdOdontograma")]
        Procedimento Buscar(int id);

        [OperationContract]
        List<Procedimento> Listar();

        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Procedimento objNovo);
    }
}
