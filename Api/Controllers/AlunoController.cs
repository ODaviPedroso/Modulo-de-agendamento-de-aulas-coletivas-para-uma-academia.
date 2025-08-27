using Aplicacao.Aplicacoes.Agendamentos;
using Aplicacao.Aplicacoes.Alunos;
using Dominio.Agendamentos;
using Dominio.Alunos;
using Dominio.Alunos.DTOs;
using Dominio.Comuns;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class AlunoController : GenericController<Aluno, CriarAlunoDTO>
    {
        private readonly IAplicAluno _aplic;
        public AlunoController(IAplicAluno aplic) : base(aplic)
        {
            _aplic = aplic;
        }

        [HttpGet("GerarRelatorioAluno")]
        public async Task<ActionResult<RelatorioAlunoDTO>> GerarRelatorioAluno([FromQuery] int codigoAluno, DateTime mesAno)
        {
            try
            {
                return await _aplic.GerarRelatorioAluno(codigoAluno, mesAno);
            }
            catch (Exception ex)
            {
                var respostaErroDto = new RespostaErroDTO { Message = ex.Message, StatusCode = 400 };
                return StatusCode(StatusCodes.Status500InternalServerError, respostaErroDto);
            }
        }
    }
}
