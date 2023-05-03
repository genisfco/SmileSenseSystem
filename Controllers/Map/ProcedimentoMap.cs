using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Controllers.Map
{
    class ProcedimentoMap : EntityTypeConfiguration<Procedimento>
    {
        public ProcedimentoMap()
        {
            this.ToTable("Procedimento");
            this.HasKey(procd => procd.IdProcedimento);
            this.Property(procd => procd.IdProcedimento).HasColumnName("ID_PROCEDIMENTO");
            this.Property(procd => procd.IdDentista).HasColumnName("ID_DENTISTA");
            this.Property(procd => procd.IdOdontograma).HasColumnName("ID_ODONTOGRAMA");
            this.Property(procd => procd.Cirurgiao).HasColumnName("CIRURGIAO");
            this.Property(procd => procd.Elemento).HasColumnName("ELEMENTO");
            this.Property(procd => procd.Face).HasColumnName("FACE");
            this.Property(procd => procd.Especialidade).HasColumnName("ESPECIALIDADE");
            this.Property(procd => procd.Procedimento_realizado).HasColumnName("PROCEDIMENTO_REALIZADO");
            this.Property(procd => procd.Data).HasColumnName("DATA_PROCEDIMENTO");
        }
    }
}
