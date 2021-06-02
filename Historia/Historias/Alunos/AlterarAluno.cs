﻿using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Alunos
{
    public class AlterarAluno
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlterarAluno(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public async Task Executar(int id, Aluno aluno)
        {
            var dadosDoAluno = await _alunoRepository.BuscarPorId(id);

            dadosDoAluno.AtualizarDados(aluno.Nome, aluno.Matricula, aluno.Sexo, aluno.Telefone, aluno.Curso);

            await _alunoRepository.Alterar(dadosDoAluno);
          
        }
    }
}
