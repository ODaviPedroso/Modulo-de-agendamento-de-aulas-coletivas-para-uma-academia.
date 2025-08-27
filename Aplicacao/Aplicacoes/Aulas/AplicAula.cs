using Aplicacao.Comuns;
using AutoMapper;
using Dominio.Aulas;
using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Aulas
{
    public class AplicAula : GenericAplic<Aula>, IAplicAula
    {
        public AplicAula(IGenericRepository<Aula> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
