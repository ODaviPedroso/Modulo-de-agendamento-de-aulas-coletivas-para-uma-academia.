using Dominio.Alunos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Configurations
{
    public class AlunoConfig : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .HasColumnName("Nome")
                .IsRequired() 
                .HasMaxLength(100); 


            builder.Property(a => a.TipoPlano)
                .HasColumnName("Tipo_Plano")
                .IsRequired()
                .HasMaxLength(150);

        }
    }
}
