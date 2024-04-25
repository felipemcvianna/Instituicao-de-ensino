﻿using ProjetoInstituicao;
using ProjetoInstituicaoDeEnsino;
using System.Text;

namespace Primeiroprojeto
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        private HashSet<Professor> privateProfessores = new HashSet<Professor>();
        public HashSet<Professor> Professores => new HashSet<Professor>(privateProfessores);
        
        private HashSet<Disciplina> privateDisciplinas = new HashSet<Disciplina>();
        public HashSet<Disciplina> Disciplinas => new HashSet<Disciplina>(privateDisciplinas);
        private HashSet<Turma> privateTurma = new HashSet<Turma>();
        public HashSet<Turma> Turmas => new HashSet<Turma>(privateTurma);
        private HashSet<Aluno> privateAlunos = new HashSet<Aluno>();
        public HashSet<Aluno> Alunos => new HashSet<Aluno>(privateAlunos);  
        public void RegistrarProfessores(Professor Professor)
        {
            if (!String.IsNullOrEmpty(Professor.Nome))
            {
                privateProfessores.Add(Professor);
                Professor.Cursos.Add(this);
            }
        }
        public void RegistrarDisciplinas(Disciplina disciplina)
        {
            Disciplinas.Add(disciplina);
            disciplina.RegistrarCursos(this);
        }
        public void RegistrarTurma(Turma turma)
        {
            Turmas.Add(turma);
            turma.RegistrarCurso(this);
        }
        public void RegistrarAlunos(Aluno aluno)
        {
            Alunos.Add(aluno);
            aluno.RegistrarCursos(this);
        }
        public int ObterQtdDisciplinas()
        {
            return Disciplinas.Count;
        }
        public Disciplina ObterDisciplinaPeloNome(string nome)
        {
            return Disciplinas.FirstOrDefault(p => p.Nome.Equals(nome));
        }
        public Professor ObterProfessorPeloNome(string nome)
        {
            return Professores.FirstOrDefault(p => p.Nome.Equals(nome));
        }
        public Turma ObterTurmaPeloCodigo(string Codigo)
        {
            return Turmas.FirstOrDefault(p => p.Codigo.Equals(Codigo));
        }
        public void EncerrarCurso()
        {
            privateDisciplinas.Clear();
            privateProfessores.Clear();
            privateTurma.Clear();
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Nome);
            sb.Append(CargaHoraria.ToString());
            return sb.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Curso)
            {
                Curso? c = obj as Curso;
                return Nome.Contains(c.Nome);
            }
            else
            {
                Console.WriteLine("Objetos de tipos diferentes");
                return false;
            }
        }
        public override int GetHashCode()
        {
            return (11 + Nome == null ? 0 : Nome.GetHashCode());
        }
    }
}
