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
    public class LoggerService : ILogger
    {
        private LoggerRep rep = new LoggerRep();

        public void Cadastrar(Logger obj)
        {
            rep.Cadastrar(obj);
        }        
    }
}
