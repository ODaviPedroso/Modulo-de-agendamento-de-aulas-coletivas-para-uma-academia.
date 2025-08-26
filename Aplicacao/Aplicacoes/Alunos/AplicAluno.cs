using Aplicacao.Comuns;
using Dominio.Alunos;
using Dominio.Comuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Alunos
{
    public class AplicAluno : GenericAplic<Aluno>, IAplicAluno
    {
        public AplicAluno(IGenericRepository<Aluno> repository) : base(repository)
        {
        }
    }
}
