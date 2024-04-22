namespace Primeiroprojeto
{
    public class Departamento
    {
        public string Nome { get; set; }
        public HashSet<Curso> Cursos { get; set; } = new HashSet<Curso>();
        private Instituicao? PrivateIntituicao;
        public Instituicao intituicao
        {
            get
            {
                return PrivateIntituicao;
            }
            set
            {
                if (value != null && !value.Departamentos.Contains(this))
                {
                    PrivateIntituicao = value;
                    PrivateIntituicao.RegistrarDep(this);
                }
            }
        }
        public void RegistrarCursos(Curso cursos)
        {
            Console.WriteLine("Curso registrado com sucesso!");
            Cursos.Add(cursos);
        }
        public int ObterQuantidadeDeCursos()
        {
            return Cursos.Count;
        }
        public Curso ObterCursoPorNome(string nome)
        {

            return Cursos.FirstOrDefault(p => p.Nome.Equals(nome));
        }
        public void FecharDepartamento()
        {
            Cursos.Clear();
            Console.WriteLine("Limpo");
        }
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                if (obj is Departamento)
                {
                    Departamento dep = obj as Departamento;
                    return Nome.Equals(dep.Nome);
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (11 + Nome == null ? 0 : Nome.GetHashCode());
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
