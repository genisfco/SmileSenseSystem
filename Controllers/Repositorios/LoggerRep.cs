using Controllers.Context;
using Entidades;

namespace Controllers.Repositorios
{
    public class LoggerRep
    {
        public void Cadastrar(Logger obj)
        {
            using (var ctx = new SistemaContext())
            {
                ctx.Loggers.Add(obj);
                ctx.SaveChanges();
            }
        }
    }
}
