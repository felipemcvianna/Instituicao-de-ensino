using Primeiroprojeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInstituicaoDeEnsino
{
    public class Coordenador : Professor
    {
        public DateTime Inicio { get; set; }
        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                if (obj is Coordenador)
                {
                    Coordenador coordenador = obj as Coordenador;
                    return Nome.Equals(coordenador.Nome);
                }
            }
            return false;
        }
    }
}
