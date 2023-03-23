using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class DentistaMap : EntityTypeConfiguration<Dentista>
    {
        public DentistaMap()
        {
            this.ToTable("Dentista");
            this.HasKey(d => d.Id);
            this.Property(d => d.Id).HasColumnName("ID_DENTISTA");
            this.Property(d => d.Nome).HasColumnName("NOME_DENTISTA");
            this.Property(d => d.CRO).HasColumnName("CRO");
            this.Property(d => d.RGDent).HasColumnName("RG_DENTISTA");
            this.Property(d => d.CPFDent).HasColumnName("CPF_DENTISTA");
            this.Property(d => d.Especialidade1).HasColumnName("ESP1_DENTISTA");
            this.Property(d => d.Especialidade2).HasColumnName("ESP2_DENTISTA");
            this.Property(d => d.Email).HasColumnName("EMAIL_DENTISTA");
            this.Property(d => d.Telefone).HasColumnName("TELEFONE_DENTISTA");
            this.Property(d => d.Celular).HasColumnName("CELULAR_DENTISTA");
        }
    }
}
