using Dominio.Alunos;
using Dominio.Aulas;
using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Agendamentos
{
    public class Agendamento : BaseEntity
    {
        public int CodigoAluno { get; set; }
        public int CodigoAula { get; set; }
        public DateTime DataAgendamento { get; set; }
        public Aluno Aluno { get; set; } = null!;
        public Aula Aula { get; set; } = null!;
    }
}
