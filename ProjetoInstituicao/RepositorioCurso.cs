using Primeiroprojeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInstituicao
{
    public class RepositorioCurso : IRepositorio<Curso>
    {
        public HashSet<Curso> Cursos = new HashSet<Curso>();
        public Curso ObterPorNome(string nome)
        {
            return Cursos.FirstOrDefault(p => p.Nome.Equals(nome));
        }
        public void Gravar(Curso c)
        {
            Cursos.Add(c);
        }
        public void Remover(Curso c)
        {
            try
            {
                if (Cursos.Contains(c))
                {
                    Cursos.Remove(c);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Curso não encontrado: " + ex.Message);
            }
        }
        public IEnumerable<Curso> ObterTodos()
        {
            return Cursos;
        }
    }
}
