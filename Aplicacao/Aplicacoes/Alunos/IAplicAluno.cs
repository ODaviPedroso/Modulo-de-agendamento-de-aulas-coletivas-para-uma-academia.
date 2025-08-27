using Aplicacao.Comuns;
using Dominio.Alunos;
using Dominio.Alunos.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Aplicacoes.Alunos
{
    public interface IAplicAluno : IGenericAplic<Aluno>
    {
        Task<RelatorioAlunoDTO> GerarRelatorioAluno(int codigoAluno, DateTime mesAno);
    }
}
