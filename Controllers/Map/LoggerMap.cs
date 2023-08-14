using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class LoggerMap : EntityTypeConfiguration<Logger>
    {
        public LoggerMap()
        {
            this.ToTable("Loggers");
            this.HasKey(log => log.IDLogger);
            this.Property(log => log.IDLogger).HasColumnName("ID_LOGGER").IsRequired();
            this.Property(log => log.IDUser).HasColumnName("ID_USUARIO");
            this.Property(log => log.Data_Logger).HasColumnName("DATA_LOGGER");
            this.Property(log => log.Tipo_Logger).HasColumnName("TIPO_LOGGER");
            this.Property(log => log.Tabela_Logger).HasColumnName("TABELA");
            this.Property(log => log.ID_Tabela).HasColumnName("ID_TABELA");
        }
    }
}
