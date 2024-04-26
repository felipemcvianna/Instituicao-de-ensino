namespace Primeiroprojeto
{
    public class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Enderecos { get; set; }
        public HashSet<Departamento> Departamentos = new HashSet<Departamento>();

        //Sobrecarga de métodos
        public void RegistrarDepartamento(Departamento dep)
        {
            Departamentos.Add(dep);
        }
        public void RegistrarDepartamento(string Nome)
        {
            Departamentos.Add(new Departamento() { Nome = Nome });
        }
        public int ObterQuantidadeDep()
        {
            return Departamentos.Count;
        }
        public override string ToString()
        {
            return Nome;
        }
        public override int GetHashCode()
        {
            return (11 + Nome == null ? 0 : Nome.GetHashCode());
        }
    }
}