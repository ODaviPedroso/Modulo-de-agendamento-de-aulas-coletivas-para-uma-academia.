using Aplicacao.Aplicacoes.Agendamentos.DTOs;
using AutoMapper;
using Dominio.Agendamentos;
using Dominio.Alunos;
using Dominio.Alunos.DTOs;
using Dominio.Aulas;
using Dominio.Aulas.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Mappers
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<CriarAgendamentoDTO, Agendamento>();
            CreateMap<CriarAlunoDTO, Aluno>();
            CreateMap<CriarAulaDTO, Aula>();
        }
    }
}
