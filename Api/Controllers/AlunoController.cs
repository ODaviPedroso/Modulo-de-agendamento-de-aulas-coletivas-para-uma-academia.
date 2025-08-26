using Aplicacao.Aplicacoes.Alunos;
using Dominio.Alunos;

namespace Api.Controllers
{
    public class AlunosController : GenericController<Aluno>
    {
        public AlunosController(IAplicAluno aplic) : base(aplic)
        {
        }
    }
}
