using Dominio.Aulas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Configurations
{
    public class AulaConfig : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            builder.ToTable("Aula");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.DataAula)
                .HasColumnName("Data_Aula")
                .IsRequired();

            builder.Property(a => a.TipoAula)
                .HasColumnName("Tipo_Aula")
                .IsRequired();

            builder.Property(a => a.CapacidadeMaxima)
                .HasColumnName("Capacidade_Maxima")
                .IsRequired();
        }
    }
}
