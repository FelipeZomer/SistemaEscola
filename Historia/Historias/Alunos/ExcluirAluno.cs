using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Alunos
{
    public class ExcluirAluno
    {
        private readonly IAlunoRepository _alunoRepository;

        public ExcluirAluno(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public async Task Executar(Aluno aluno)
        {
            await _alunoRepository.Excluir(aluno);
        }
    }
}
