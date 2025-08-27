using Aplicacao.Aplicacoes.Agendamentos.DTOs;
using Aplicacao.Comuns;
using AutoMapper;
using Dominio.Agendamentos;
using Dominio.Alunos;
using Dominio.Aulas;
using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Agendamentos
{
    public class AplicAgendamento : GenericAplic<Agendamento>, IAplicAgendamento
    {
        private readonly IRepAgendamento _repAgendamento;
        private readonly IRepAula _repAula;
        private readonly IRepAluno _repAluno;
        public AplicAgendamento(IRepAgendamento repository, IMapper mapper, IRepAula repAula, IRepAluno repAluno) 
            : base(repository, mapper)
        {
            _repAgendamento = repository;
            _repAula = repAula;
            _repAluno = repAluno;
        }

        public async Task<Agendamento> CriarAgendamento(CriarAgendamentoDTO dto)
        {
            try
            {
                VerificacoesAntesSalvar(dto.CodigoAula, dto.CodigoAluno); //Aqui eu fiz as regras de negocio pedidas :)

                var novoAgendamento = new Agendamento
                {
                    CodigoAluno = dto.CodigoAluno,
                    CodigoAula = dto.CodigoAula,
                    DataAgendamento = dto.DataAgendamento
                };

                await _repAgendamento.AddAsync(novoAgendamento);

                return novoAgendamento;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        private void VerificacoesAntesSalvar(int codigoAula, int codigoAluno)
        {
            var aula = _repAula.GetByIdAsync(codigoAula).Result;
            var totalAgendamentos = _repAgendamento.GetAllAsync().Result.Where(a => a.CodigoAula == codigoAula).Count();

            if (aula != null && totalAgendamentos >= aula.CapacidadeMaxima)
            {
                throw new Exception("A capacidade máxima da aula foi atingida.");
            }

            var aulasALuno = _repAgendamento.GetAllAsync().Result.Where(a => a.CodigoAluno == codigoAluno).ToList();

            if (aulasALuno.Count() > 0)
            {
                if (aulasALuno.Any(a => a.CodigoAula == codigoAula))
                {
                    throw new Exception("O aluno já possui um agendamento para essa aula.");
                }

                var aluno = _repAluno.GetByIdAsync(codigoAluno).Result;

                if (aluno.TipoPlano.Equals(TipoPlanoAulaEnum.Mensal) && aulasALuno.Count() + 1 > 12)
                    throw new Exception("Limite de aulas do plano mensal ultrapasada.");

                if (aluno.TipoPlano.Equals(TipoPlanoAulaEnum.Trimestral) && aulasALuno.Count() + 1 > 20)
                    throw new Exception("Limite de aulas do plano Trimestral ultrapasada.");

                if (aluno.TipoPlano.Equals(TipoPlanoAulaEnum.Anual) && aulasALuno.Count() + 1 > 30)
                    throw new Exception("Limite de aulas do plano Anual ultrapasada.");
            }
        }
    }
}
