using ProjetoInstituicaoDeEnsino;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInstituicao
{
    public class latoSensu : PosGraduacao
    {
        public latoSensu(string nome)
        {
            Nome = nome;
        }
        public string AreaDeAtuacao { get; set; }
    }
}
