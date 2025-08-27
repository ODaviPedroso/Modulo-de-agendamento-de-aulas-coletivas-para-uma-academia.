using Dominio.Agendamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Data.Configurations
{
    public class AgendamentoConfig : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.CodigoAluno)
                .HasColumnName("Id_Aluno")
                .IsRequired();

            builder.Property(a => a.CodigoAula)
                .HasColumnName("Id_Aula")
                .IsRequired();

            builder.HasOne(agendamento => agendamento.Aluno)
                .WithMany() 
                .HasForeignKey(agendamento => agendamento.CodigoAluno) 
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(agendamento => agendamento.Aula)
                .WithMany()
                .HasForeignKey(agendamento => agendamento.CodigoAula)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
