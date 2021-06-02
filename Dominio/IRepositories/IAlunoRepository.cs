﻿using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IAlunoRepository
    {
        Task Criar(Aluno aluno);

        Task Alterar(Aluno aluno);

        Task Excluir(Aluno aluno);

        Task<Aluno> BuscarPorId(int id);

        Task<IEnumerable<Aluno>> ListarTodosAlunos();
    }
}
