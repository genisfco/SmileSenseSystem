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

    public interface ILogger
    {
        [OperationContract]
        void Cadastrar (Logger obj);
    }    
}
