﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Controllers.Map
{
    class OdontogramaMap : EntityTypeConfiguration<Odontograma>
    {
        public OdontogramaMap()
        {
            this.ToTable("Odontograma");
            this.HasKey(odt => odt.IdOdontograma);
            this.Property(odt => odt.IdOdontograma).HasColumnName("ID_ODONTOGRAMA");
            this.Property(odt => odt.IdPaciente).HasColumnName("ID_PACIENTE");
            this.Property(odt => odt.CaminhoImagem).HasColumnName("CAMINHO_IMAGEM");
        }
    }
}
