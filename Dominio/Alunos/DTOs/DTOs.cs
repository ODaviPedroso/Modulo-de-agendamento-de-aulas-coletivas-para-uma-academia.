using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Alunos.DTOs
{
    public class CriarAlunoDTO
    {
        public string Nome { get; set; }
        public TipoPlanoAulaEnum TipoPlano { get; set; }
    }

    public class RelatorioAlunoDTO
    {
        public string Nome { get; set; }
        public int TotalAulas { get; set; }
        public TipoAulaEnum TipoAulaMaisFrequente { get; set; }
    }
}
