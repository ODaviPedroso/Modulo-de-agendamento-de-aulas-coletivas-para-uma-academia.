using Aplicacao.Aplicacoes.Aulas;
using Aplicacao.Comuns;
using Dominio.Aulas;
using Dominio.Aulas.DTOs;

namespace Api.Controllers
{
    public class AulaController : GenericController<Aula, CriarAulaDTO>
    {
        public AulaController(IAplicAula service) : base(service)
        {
        }
    }
}
