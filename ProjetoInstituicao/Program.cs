using ProjetoInstituicao;
using ProjetoInstituicao.Enums;
using ProjetoInstituicaoDeEnsino;
using System.ComponentModel.DataAnnotations.Schema;
namespace Primeiroprojeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var graduacao = new Graduacao("Curso de graduação", 5000, 10);
            Disciplina disciplina = new Disciplina("POO", graduacao, 60);
            Disciplina disciplina2 = new Disciplina("Java", graduacao, 80);                     
            Turma t = new Turma("Turma 1", graduacao, 2, PeriodoCursoEnum.Primeiro, 
                TurnoTurmaEnum.Vespertino);           
            Aluno felipe = new Aluno("Felipe", "6", graduacao);            
            foreach (var disciplinas in graduacao.Disciplinas)
            {
                try
                {
                    t.RegistrarMatricula(new Matricula(felipe, t, disciplinas));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro ao cadastrar a matricula: "+ ex.Message);
                }
                
            }
            graduacao.ObterAlunoPeloNome("Joao");
        }        
    }    
}
