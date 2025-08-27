using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Aulas.DTOs
{
    public class CriarAulaDTO
    {
        public TipoAulaEnum TipoAula { get; set; }
        public DateTime DataAula { get; set; }
        public int CapacidadeMaxima { get; set; }
    }
}
