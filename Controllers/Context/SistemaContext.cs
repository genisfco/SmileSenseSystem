﻿using Controllers.Map;
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
        /*public SistemaContext() : base("Server=ACERASPIRE-5\\SQLEXPRESS; Database=SmileSense; Integrated Security=True;")
        {
                // BANCO LOCAL
        }*/
        
        public SistemaContext() : base("workstation id = SmileSense.mssql.somee.com; packet size = 4096; user id = genis_SQLLogin_1; pwd=qe4hpfhfjo;data source = SmileSense.mssql.somee.com; persist security info=False;initial catalog = SmileSense")
        {
            // BANCO HOSPEDADO
        }



        public DbSet<Consulta> Consultas{ get; set;}
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
