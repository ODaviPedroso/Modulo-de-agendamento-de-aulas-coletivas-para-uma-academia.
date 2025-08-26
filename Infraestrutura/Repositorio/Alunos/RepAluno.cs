using Dominio.Alunos;
using Infraestrutura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio.Alunos
{
    public class RepAluno : GenericRepository<Aluno>, IRepAluno
    {
        public RepAluno(ApplicationDbContext context) : base(context)
        {
        }
    }
}
