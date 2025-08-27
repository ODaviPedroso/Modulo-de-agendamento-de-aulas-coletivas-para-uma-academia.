using Dominio.Agendamentos;
using Infraestrutura.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio.Agendamentos
{
    public class RepAgendamento : GenericRepository<Agendamento>, IRepAgendamento
    {
        public RepAgendamento(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<Agendamento>> BuscarAulasAlunoAgendadasNoMes(int alunoId, int ano, int mes)
        {
            var lista = await _context.Agendamentos
                .Include(ag => ag.Aula) 
                .Where(ag => ag.CodigoAluno == alunoId &&
                             ag.DataAgendamento.Year == ano &&
                             ag.DataAgendamento.Month == mes)
                .ToListAsync();

            return lista;
        }
    }
}