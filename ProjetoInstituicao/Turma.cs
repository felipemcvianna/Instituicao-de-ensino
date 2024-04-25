using Primeiroprojeto;
using ProjetoInstituicao.Enums;

namespace ProjetoInstituicao
{
    public class Turma
    {
        public string Codigo { get; set; }
        private Curso _curso { get; set; }
        public Curso Curso
        {
            get { return _curso; }
            set
            {
                _curso = value;
            }

        }
        public PeriodoCursoEnum Periodo { get; set; }
        public TurnoTurmaEnum Turno { get; set; }
        private HashSet<Matricula> privateMatricula = new HashSet<Matricula>();
        public HashSet<Matricula> Matriculas => new HashSet<Matricula>(privateMatricula);

        public void RegistrarMatricula(Matricula mat)
        {
            if (privateMatricula.Count >= 2)
            {
                throw new Exception("Matriculas esgotadas");
            }
            else
            {
                privateMatricula.Add(mat);
                mat.Turma = this;
            }
        }
        public Turma(string codigo, Curso curso)
        {
            Codigo = codigo;
            curso.RegistrarTurma(this);
        }

        public void RegistrarCurso(Curso curso)
        {
            if (Curso != curso)
            {
                Curso = curso;
            }
            else
            {
                throw new InvalidOperationException("Curso já registrado");
            }

        }
        public void EncerrarAssociacao()
        {
            if (Curso != null && Curso.Turmas.Contains(this))
            {
                Curso.Turmas.Remove(this);
                _curso = null;
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
