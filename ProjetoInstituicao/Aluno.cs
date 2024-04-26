using Primeiroprojeto;

namespace ProjetoInstituicao
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string RegistroAcademico { get; set; }                
        public HashSet<Curso> Cursos => new HashSet<Curso>();        
        public HashSet<Matricula> Matriculas = new HashSet<Matricula>();
        public Aluno(string nome, string Registro, Curso Cursos)
        {
            Nome = nome;
            RegistroAcademico = Registro;
            Cursos.RegistrarAlunos(this);
        }

        public void RegistrarCursos(Curso curso)
        {
            Cursos.Add(curso);
        }
        public void RegistraMatricula(Matricula mat)
        {
            Matriculas.Add(mat);
            mat.Aluno = this;
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
