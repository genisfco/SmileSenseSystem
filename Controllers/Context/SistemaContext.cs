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
        public SistemaContext() : base("Server=ACERASPIRE-5\\SQLEXPRESS;Database=SmileSense;Integrated Security=True;")
        {

        }        

        public DbSet<Consulta> Consultas{ get; set;}
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Dentista> Dentistas { get; set; }
        public DbSet<Anamnese> Anamneses { get; set; }
        public DbSet<Odontograma> Odontogramas { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SistemaContext>(null);
            modelBuilder.Configurations.Add(new DentistaMap());
            modelBuilder.Configurations.Add(new PacienteMap());
            modelBuilder.Configurations.Add(new ConsultaMap());
            modelBuilder.Configurations.Add(new AnamneseMap());
            modelBuilder.Configurations.Add(new OdontogramaMap());
            modelBuilder.Configurations.Add(new ProcedimentoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
