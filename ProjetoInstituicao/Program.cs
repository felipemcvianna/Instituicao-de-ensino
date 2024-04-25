using ProjetoInstituicao;
using ProjetoInstituicaoDeEnsino;
namespace Primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var graduacao = new Graduacao("Curso de graduação");
            var latoSensu = new latoSensu("Curso de latoSensu");
            var strictoSensu = new StrictoSensu("Curso de StrictoSensu");
            var CursoGraduacao = new Graduacao("Teste");
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
        }        
    }    
}
