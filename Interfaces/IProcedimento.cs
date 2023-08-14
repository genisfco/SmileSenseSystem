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
        Task<int> Cadastrar(Procedimento obj);

        [OperationContract(Name = "BuscarPorIdOdontograma")]
        Procedimento BuscarProcdporIdOdt(int idOdontograma);

        [OperationContract(Name = "ListarPorIdOdontograma")]
        List<Procedimento> ListarProcedimentosPorIdOdontograma(int idOdontograma);


        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Procedimento objNovo);
    }
}
