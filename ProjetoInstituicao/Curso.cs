using ProjetoInstituicaoDeEnsino;
using System.Text;

namespace Primeiroprojeto
{
    public class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        private HashSet<Professor> privateProfessores = new HashSet<Professor>();
        public HashSet<Professor> Professores { get { return privateProfessores; } }        
        private HashSet<Disciplina> privateDisciplinas = new HashSet<Disciplina>();
        public HashSet<Disciplina> Disciplinas
        {
            get
            {
                return new HashSet<Disciplina>(privateDisciplinas);
            }
        }

        public void RegistrarDisciplinas(Disciplina d)
        {
            privateDisciplinas.Add(d);
        }
        public void RegistrarProfessores(Professor Prof)
        {
            privateProfessores.Add(Prof);
        }

        public int ObterQtdDisciplinas()
        {
            return privateDisciplinas.Count;
        }
        public Disciplina ObterDisciplinaPeloNome(string nome)
        {
            return Disciplinas.FirstOrDefault(p => p.Nome.Equals(nome));
        }
        public void EncerrarCurso()
        {
            privateDisciplinas.Clear();
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            sb.AppendLine(Nome);
            return sb.ToString();
        }
        public override bool Equals(object? obj)
        {
            if (obj is Curso)
            {
                Curso? c = obj as Curso;
                return Nome.ToUpper().Equals(c.Nome.ToUpper());
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
