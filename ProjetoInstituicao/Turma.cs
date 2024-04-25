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
        public readonly int QTDVagas;
        public PeriodoCursoEnum Periodo { get; set; }
        public TurnoTurmaEnum Turno { get; set; }
        private HashSet<Matricula> privateMatricula = new HashSet<Matricula>();
        public HashSet<Matricula> Matriculas => new HashSet<Matricula>(privateMatricula);
        public Turma(string codigo, Curso curso, int QTD, PeriodoCursoEnum periodo, TurnoTurmaEnum turno)
        {
            Codigo = codigo;
            QTDVagas = QTD;
            Periodo = periodo;
            Turno = turno;
            curso.RegistrarTurma(this);
        }
        public void RegistrarMatricula(Matricula mat)
        {
            if (privateMatricula.Count >= QTDVagas)
            {
                throw new Exception("Matriculas esgotadas");
            }
            else
            {
                privateMatricula.Add(mat);
                mat.Turma = this;
                mat.Disciplina.RegistrarMatricula(mat);
            }
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
            return "Codigo da Turma: " + Codigo + "\n" + Curso.Nome + "\n" + "Quantidade de vagas: " + QTDVagas + "\n" + "Periodo: " + Periodo + "\n" + "Turno: " + Turno;
        }
    }
}