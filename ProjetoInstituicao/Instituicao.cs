namespace Primeiroprojeto
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Enderecos { get; set; }
        public HashSet<Departamento> Departamentos = new HashSet<Departamento>();
        public void RegistrarDep(Departamento dep)
        {
            Departamentos.Add(dep);
        }
        public int ObterQuantidadeDep()
        {
            return Departamentos.Count;
        }
        public override string ToString()
        {
            return Nome;
        }
        public void teste()
        {
            Console.WriteLine($"\n\nDepartamentos da instituicao de ensino {Nome}\n");
            if (Departamentos.Count != 0)
            {
                foreach (var departamentos in Departamentos)
                {

                    int varriavel = departamentos.Nome.Length;
                    string linha = new string('-', varriavel);
                    Console.WriteLine(linha);
                    Console.WriteLine($"{departamentos}");
                    Console.WriteLine(linha);
                    Console.WriteLine($"\nCursos do {departamentos}\n");
                    foreach (var cursos in departamentos.Cursos)
                    {
                        Console.WriteLine($"==> {cursos}");
                        if (cursos.Disciplinas.Count() > 0)
                        {
                            Console.WriteLine($"Disciplinas do Curso {cursos}");
                            foreach (var disciplinas in cursos.Disciplinas)
                            {
                                Console.WriteLine($"==> {disciplinas} \n");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Vazio");
            }
        }
        public override int GetHashCode()
        {
            return (11 + Nome == null ? 0 : Nome.GetHashCode());
        }
    }
}