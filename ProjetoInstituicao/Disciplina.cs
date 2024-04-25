namespace Primeiroprojeto
{
    public class Disciplina
    {
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public HashSet<Curso> Cursos { get; set; } = new HashSet<Curso>();
        public Disciplina(string nome, Curso curso)
        {
            Nome = nome;
            curso.RegistrarDisciplinas(this);
        }
        public void RegistrarCursos(Curso cursos)
        {
            if (!Cursos.Contains(cursos))
            {
                Cursos.Add(cursos);
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj is Disciplina)
            {
                Disciplina c = obj as Disciplina;
                return Nome.Equals(c.Nome);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + Nome == null ? 0 : Nome.GetHashCode());
        }
        public override string ToString()
        {
            return "Nome: " + Nome + "\nCarga horária: " + CargaHoraria;
        }
    }
}
