using Controllers.Map;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace Controllers.Context
{
    class SistemaContext : DbContext
    {
        //public SistemaContext() : base("Server = ACERASPIRE - 5\\SQLEXPRESS; Database = SmileSense; Integrated Security = True;")
        //{
        //    // BANCO LOCAL  MYSQL Server=localhost;Database=SmileSense;Uid=root;Pwd='1234'; convert zero datetime=True
        //    // SQL                Server = ACERASPIRE - 5\\SQLEXPRESS; Database = SmileSense; Integrated Security = True
        //}

        public SistemaContext() : base("workstation id=SmileSense.mssql.somee.com;packet size=4096;user id=genis_SQLLogin_1;pwd=#Tcc2023;data source=SmileSense.mssql.somee.com;persist security info=False;initial catalog=SmileSense")
        {
            // BANCO HOSPEDADO
        }



        public DbSet<Consulta> Consultas{ get; set;}
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }
        public DbSet<Anamnese> Anamneses { get; set; }

        //public DbSet<Odontograma> Odontogramas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            modelBuilder.Configurations.Add(new AnamneseMap());
            //modelBuilder.Configurations.Add(new OdontogramaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
