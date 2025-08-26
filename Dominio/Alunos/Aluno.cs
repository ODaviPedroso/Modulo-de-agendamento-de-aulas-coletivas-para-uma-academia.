using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Alunos
{
    public class Aluno : BaseEntity
    {
        public string Nome { get; set; }
        public TipoPlanoAulaEnum TipoPlano { get; set; }
    }
}
