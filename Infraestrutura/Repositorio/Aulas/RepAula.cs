using Dominio.Aulas;
using Infraestrutura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio.Aulas
{
    public class RepAula : GenericRepository<Aula>, IRepAula
    {
        public RepAula(ApplicationDbContext context) : base(context)
        {
        }
    }
}
