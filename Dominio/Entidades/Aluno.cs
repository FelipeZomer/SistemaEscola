using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Aluno
    {
        public Aluno(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public int Id { get; private set; }
        public int CursoId { get; private set; }
        public string Nome { get; private set; }
        public string Matricula { get; private set; }
        public string Sexo { get; private set; }
        public string Telefone { get; private set; }
        public Curso Curso { get; private set; }

        public void AtualizarDados(string nome, string matricula, string sexo, string telefone, Curso curso)
        {
            this.Nome = nome;
            this.Matricula = matricula;
            this.Sexo = sexo;
            this.Telefone = telefone;
            this.Curso = curso;
        }
    }
}
