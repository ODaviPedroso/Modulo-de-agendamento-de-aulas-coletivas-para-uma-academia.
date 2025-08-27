using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Agendamentos.DTOs
{
    public class CriarAgendamentoDTO
    {
        public int CodigoAluno { get; set; }
        public int CodigoAula { get; set; }
        public DateTime DataAgendamento { get; set; }
    }
}
