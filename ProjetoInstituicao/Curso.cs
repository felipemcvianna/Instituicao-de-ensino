using ProjetoInstituicao;
using ProjetoInstituicaoDeEnsino;
using System.Text;

namespace Primeiroprojeto
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        private HashSet<Professor> privateProfessores = new HashSet<Professor>();
        public HashSet<Professor> Professores { get { return privateProfessores; } }        
        private HashSet<Disciplina> privateDisciplinas  = new HashSet<Disciplina>();
        public HashSet<Disciplina> Disciplinas { get  { return privateDisciplinas; }
        }
        private HashSet<Turma> privateTurma = new HashSet<Turma>();
        public HashSet<Turma> Turmas { get { return privateTurma; } }
        public void RegistrarProfessores(Professor Prof)
        {
            if (!String.IsNullOrEmpty(Prof.Nome))
            {
                Prof.Cursos.Add(this);
                privateProfessores.Add(Prof);
            }
        }
        public void RegistrarDisciplinas(Disciplina d)
        {
            if (!String.IsNullOrEmpty(d.Nome))
            {
                privateDisciplinas.Add(d);
            }
        }       
        public void RegistrarTurma(Turma t)
        {
            if (!String.IsNullOrEmpty(t.Codigo)) { privateTurma.Add(t); } 
            else { throw new Exception("Turma sem identificação"); }
            
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
