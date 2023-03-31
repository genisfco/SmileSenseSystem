using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Map
{
    class AnamneseMap : EntityTypeConfiguration<Anamnese>
    {
        public AnamneseMap()
        {
            this.ToTable("Anamnese");
            this.HasKey(anm => anm.IdAnamnese);
            this.Property(anm => anm.IdAnamnese).HasColumnName("ID_ANAMNESE");
            this.Property(anm => anm.IdPaciente).HasColumnName("ID_PACIENTE");
            this.Property(anm => anm.Diabetes).HasColumnName("DIABETES");
            this.Property(anm => anm.Hipertensao).HasColumnName("HIPERTENSAO");
            this.Property(anm => anm.Cardiopatia).HasColumnName("CARDIOPATIA");
            this.Property(anm => anm.Uso_Continuo).HasColumnName("USOCONTINUO");
            this.Property(anm => anm.Medicamento_Continuo).HasColumnName("MEDICAMENTO_CONTINUO");
            this.Property(anm => anm.Alergia_Medicamento).HasColumnName("ALERGIA_MEDICAMENTO");
            this.Property(anm => anm.Alergia_Qual_Medicamento).HasColumnName("ALERG_QUAL_MEDICAM");
            this.Property(anm => anm.Problemas_Hemorragicos).HasColumnName("PROBL_HEMORRAG");
            this.Property(anm => anm.Motivo_Problemas).HasColumnName("MOTIVO_PROBL");
            this.Property(anm => anm.Complicacoes_Odonto).HasColumnName("COMPLIC_ODONTO");
            this.Property(anm => anm.Porque_Complicacoes).HasColumnName("PORQ_COMPL");
            this.Property(anm => anm.Doenca_Cong).HasColumnName("DOENCA_CONG");
            this.Property(anm => anm.Qual_Doenca).HasColumnName("QUAL_DOENCA");            
        }
    }
}
