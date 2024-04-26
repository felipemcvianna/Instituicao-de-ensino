using Primeiroprojeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInstituicaoDeEnsino
{
    public class Professor
    {
        public string Nome {  get; set; }        
        public DateTime Contratacao { get; set; }
        public HashSet<Curso> Cursos { get; set; } = new HashSet<Curso>();
        public void RegistrarCursos(Curso curso)
        {
            if (!Cursos.Contains(curso))
            {
                Cursos.Add(curso);
            }     
        }
        
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                if (obj is Professor)
                {
                    Professor Prof = obj as Professor;
                    return Nome.Equals(Prof.Nome);
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
            return "Nome: " + Nome;
        }
    }
}
