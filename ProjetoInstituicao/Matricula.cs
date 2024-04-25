﻿using Primeiroprojeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInstituicao
{
    public class Matricula
    {       
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
        public Disciplina Disciplina { get; set; }
        public Matricula(Aluno aluno, Turma turma, Disciplina disciplina)
        {
            Aluno = aluno;
            Turma = turma;
            Disciplina = disciplina;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Matricula)
            {
                Matricula mat = obj as Matricula;
                return Aluno.RegistroAcademico.Equals(mat.Aluno.RegistroAcademico) &&
                    Turma.Codigo.Equals(mat.Turma.Codigo) &&
                    Disciplina.Nome.Equals(mat.Disciplina.Nome);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + ((Aluno.RegistroAcademico == null || Turma.Codigo == null || Disciplina.Nome == null) ? 0 : 
                Aluno.RegistroAcademico.GetHashCode() +
                Turma.Codigo.GetHashCode() +
                Disciplina.Nome.GetHashCode()));
        }
    }
}