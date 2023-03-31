﻿using Entidades;
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
    public interface IAnamnese
    {
        [OperationContract]
        void Cadastrar(Anamnese obj);

        [OperationContract(Name = "BuscarPorId")]
        Anamnese Buscar(int id);

        [OperationContract(Name = "BuscarPorPaciente")]
        IQueryable<Anamnese> Buscar(Anamnese anamnese);    



        [OperationContract]
        void Deletar(int id);

        [OperationContract]
        void Editar(Anamnese objNovo);
    }
}
