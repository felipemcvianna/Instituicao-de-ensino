using ProjetoInstituicao;
using ProjetoInstituicaoDeEnsino;
namespace Primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {            
            var graduacao = new Graduacao() { Nome = "Curso de graduação", CargaHoraria = 2000};
            var latoSensu = new latoSensu() { Nome = "Curso de latoSensu"};
            var strictoSensu = new StrictoSensu() { Nome = "Curso de StrictoSensu"};
            var CursoGraduacao = new Graduacao() { Nome = "Teste" };

            RepositorioCurso repositorio = new RepositorioCurso();
            repositorio.Gravar(graduacao);
            repositorio.Gravar(latoSensu);
            repositorio.Gravar(strictoSensu);          
            Console.WriteLine();
            Console.WriteLine("Cursos Gravados");
            foreach (var cursos in repositorio.Cursos)
            {
                Console.WriteLine($"===> {cursos.Nome} ({cursos.GetType()})");
            }
            repositorio.Remover(CursoGraduacao);            
        }
    }
}
