using Primeiroprojeto;
using ProjetoInstituicao.Enums;

namespace ProjetoInstituicao
{
    public class Turma
    {
        public string Codigo { get; set; }
        public Curso Curso { get; private set; }
        public PeriodoCursoEnum Periodo { get; set; }
        public TurnoTurmaEnum Turno { get; set; }
        public Turma(string codigo, Curso curso)
        {
            Codigo = codigo;
            RegistrarCurso(curso);
            curso.RegistrarTurma(this);
        }

        public void RegistrarCurso(Curso curso)
        {
            if (Curso == null && curso.Nome != null)
            {
                Curso = curso;
            }
        }
        public void EncerrarAssociacao()
        {
            if(Curso != null && Curso.Turmas.Contains(this))
            {
                Curso.Turmas.Remove(this);
                Curso = null;
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj is Turma)
            {
                Turma t = obj as Turma;
                return Codigo.Equals(t.Codigo);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return 11 + (Codigo == null ? 0 : Codigo.GetHashCode());
        }
        public override string ToString()
        {
            return Codigo;
        }
    }
}
