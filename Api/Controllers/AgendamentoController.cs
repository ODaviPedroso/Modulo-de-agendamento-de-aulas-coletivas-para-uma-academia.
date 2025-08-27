using Aplicacao.Aplicacoes.Agendamentos;
using Aplicacao.Aplicacoes.Agendamentos.DTOs;
using Aplicacao.Comuns;
using Dominio.Agendamentos;
using Dominio.Comuns;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class AgendamentoController : GenericController<Agendamento, CriarAgendamentoDTO>
    {
        private readonly IAplicAgendamento _aplic;
        public AgendamentoController(IAplicAgendamento aplic) : base(aplic)
        {
            _aplic = aplic;
        }

        public override async Task<ActionResult<Agendamento>> Create(CriarAgendamentoDTO dto)
        {
            try
            {
                var entity = await _aplic.CriarAgendamento(dto);
                return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
            }
            catch(Exception ex)
            {
                var respostaErroDto = new RespostaErroDTO { Message = ex.Message, StatusCode = 400 };
                return StatusCode(StatusCodes.Status500InternalServerError, respostaErroDto);
            }
        }
    }
}
