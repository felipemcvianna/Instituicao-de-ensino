using Primeiroprojeto;
using ProjetoInstituicao.Enums;

namespace ProjetoInstituicao
{
    public class Turma
    {
        public string Codigo { get; set; }
        private Curso privateCurso { get; set; }
        public Curso Curso
        {
            get { return privateCurso; }
            set { privateCurso = value; }
        }
        public readonly int QTDVagas;
        public PeriodoCursoEnum Periodo { get; set; }
        public TurnoTurmaEnum Turno { get; set; }        
        public HashSet<Matricula> Matriculas = new HashSet<Matricula>();
        public Turma(string codigo, Curso curso, int QTD, PeriodoCursoEnum periodo, TurnoTurmaEnum turno)
        {
            Codigo = codigo;
            QTDVagas = QTD;
            Periodo = periodo;
            Turno = turno;           
            curso.RegistrarTurmas(this);
        }
        public void RegistrarMatricula(Matricula mat)
        {
            if (Matriculas.Count >= QTDVagas)
            {
                throw new Exception("Matriculas esgotadas");
            }
            Matriculas.Add(mat);
            mat.Turma = this;
            mat.Disciplina.RegistrarMatricula(mat);
            mat.Aluno.RegistraMatricula(mat);
        }
        public void RegistrarCurso(Curso curso)
        {
            if (Curso != curso)
            {
                Curso = curso;
            }
        }
        public override bool Equals(object obj)
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
            return "Codigo da Turma: " + Codigo + "\n" + Curso.Nome + "\n" + "Periodo: " + Periodo + "\n" + "Turno: " + Turno;
        }
    }
}