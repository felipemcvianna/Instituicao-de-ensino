using Primeiroprojeto;

namespace ProjetoInstituicao
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string RegistroAcademico { get; set; }
        public HashSet<Curso> Cursos { get; set; } = new HashSet<Curso>();
        public Aluno(string nome, string Registro, Curso Cursos)
        {
            Nome = nome;
            RegistroAcademico = Registro;
            Cursos.RegistrarAlunos(this);         
        }
        public void RegistrarCursos(Curso curso)
        {
            if(!Cursos.Contains(curso))
            {
                Cursos.Add(curso);
            }
            else
            {
                throw new InvalidOperationException("Curso já registrado");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj is Aluno)
            {
                Aluno a = obj as Aluno;
                return Nome.Equals(a.Nome);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + Nome == null ? 0 : Nome.GetHashCode());
        }

    }
}
