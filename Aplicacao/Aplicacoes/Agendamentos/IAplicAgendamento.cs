using Aplicacao.Aplicacoes.Agendamentos.DTOs;
using Aplicacao.Comuns;
using Dominio.Agendamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Agendamentos
{
    public interface IAplicAgendamento : IGenericAplic<Agendamento>
    {
        Task<Agendamento> CriarAgendamento(CriarAgendamentoDTO dto);
    }
}
