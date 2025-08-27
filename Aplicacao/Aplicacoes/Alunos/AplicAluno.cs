using Aplicacao.Comuns;
using AutoMapper;
using Dominio.Agendamentos;
using Dominio.Alunos;
using Dominio.Alunos.DTOs;
using Dominio.Aulas;
using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Alunos
{
    public class AplicAluno : GenericAplic<Aluno>, IAplicAluno
    {
        private readonly IRepAgendamento _repAgendamento;
        private readonly IRepAula _repAula;
        private readonly IRepAluno _repAluno;
        public AplicAluno(IRepAluno repository, IMapper mapper, IRepAgendamento repAgendamento, IRepAula repAula) 
            : base(repository, mapper)
        {
            _repAgendamento = repAgendamento;
            _repAula = repAula;
            _repAluno = repository;
        }

        public async Task<RelatorioAlunoDTO> GerarRelatorioAluno(int codigoAluno, DateTime mesAno)
        {
            try
            {
                var relatorio = new RelatorioAlunoDTO();
                var nomAluno = _repAluno.GetByIdAsync(codigoAluno).Result.Nome;

                if (nomAluno == null)
                    throw new Exception("Aluno não encontrado");

                relatorio.Nome = nomAluno;

                var agendamentosDoMes = await _repAgendamento.BuscarAulasAlunoAgendadasNoMes(codigoAluno, mesAno.Year, mesAno.Month);

                if (agendamentosDoMes == null || !agendamentosDoMes.Any())
                    return relatorio;

                relatorio.TotalAulas = agendamentosDoMes.Count();

                var aulaMaisFrequenteGrupo = agendamentosDoMes
                        .GroupBy(agendamento => agendamento.Aula.TipoAula)
                        .OrderByDescending(grupo => grupo.Count())
                        .FirstOrDefault(); // Aqui eu só to agrupando pelo tipo e vendo qual maior grupo 

                relatorio.TipoAulaMaisFrequente = aulaMaisFrequenteGrupo.Key;

                return relatorio;
            }
            catch
            {
                throw new Exception("Erro ao buscar relatorio, verifique os dados informados");
            }
        }
    }
}
