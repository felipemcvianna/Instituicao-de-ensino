using Maybe.SkipList;
using ProjetoInstituicao;
using ProjetoInstituicaoDeEnsino;
using System.Text;

namespace Primeiroprojeto
{
    public abstract class Curso
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public HashSet<Professor> Professores = new HashSet<Professor>();
        public HashSet<Disciplina> Disciplinas = new HashSet<Disciplina>();

        public HashSet<Turma> Turmas = new HashSet<Turma>();
        public HashSet<Aluno> Alunos = new HashSet<Aluno>();
        public void RegistrarProfessores(Professor Professor)
        {
            if (Professores.Contains(Professor))
                throw new ArgumentException("professor já registrado");
            Professores.Add(Professor);
            Professor.RegistrarCursos(this);
        }
            public virtual void RegistrarDisciplinas(Disciplina disciplina)
            {
                if (Disciplinas.Contains(disciplina))
                    throw new ArgumentException("Disciplina já registrada");
                Disciplinas.Add(disciplina);
                disciplina.RegistrarCursos(this);
            }
        public void RegistrarTurmas(Turma turma)
        {
            if (Turmas.Contains(turma))
                throw new ArgumentException("Turma já registrada");
            Turmas.Add(turma);
            turma.RegistrarCurso(this);
        }
        public void RegistrarAlunos(Aluno aluno)
        {
            if (Alunos.Contains(aluno))
                throw new ArgumentException("Aluno já registrado");
            Alunos.Add(aluno);
            aluno.RegistrarCursos(this);
        }

        public Disciplina ObterDisciplinaPeloNome(string nome)
        {
            var nomeEncontrado = Disciplinas.FirstOrDefault(p => p.Nome.Equals(nome));
            if (nomeEncontrado == null)
            {
                throw new ArgumentException("Nome não encontrado", nameof(nome));
            }
            return nomeEncontrado;
        }

        public Professor ObterProfessorPeloNome(string nome)
        {
            var nomeEncontrado = Professores.FirstOrDefault(p => p.Nome.Equals(nome));
            if (nomeEncontrado == null)
            {
                throw new ArgumentException("Nome não encontrado", nameof(nome));
            }
            return nomeEncontrado;
        }
        public Turma ObterTurmaPeloCodigo(string Codigo)
        {
            var nomeEncontrado = Turmas.FirstOrDefault(p => p.Codigo.Equals(Codigo));
            if (nomeEncontrado == null)
            {
                throw new ArgumentException("Codigo não encontrado", nameof(Codigo));
            }
            return nomeEncontrado;
        }
        public Aluno ObterAlunoPeloNome(string nome)
        {
            var nomeEncontrado = Alunos.FirstOrDefault(p => p.Nome.Equals(nome));
            if (nomeEncontrado == null)
            {
                throw new ArgumentException("Nome não encontrado" , nameof(nome));
            }
            return nomeEncontrado;
        }
        public int ObterQtdDisciplinas()
        {
            return Disciplinas.Count;
        }
        public int ObterQtdTurmas()
        {
            return Turmas.Count;
        }
        public int ObterQtdProfessores()
        {
            return Professores.Count;
        }
        public int ObterQtdAlunos()
        {
            return Alunos.Count;
        }
        public void EncerrarCurso()
        {
            Disciplinas.Clear();
            Professores.Clear();
            Turmas.Clear();
            Alunos.Clear();
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
