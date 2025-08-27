using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Agendamentos
{
    public interface IRepAgendamento : IGenericRepository<Agendamento>
    {
        Task<List<Agendamento>> BuscarAulasAlunoAgendadasNoMes(int alunoId, int ano, int mes);
    }
}
