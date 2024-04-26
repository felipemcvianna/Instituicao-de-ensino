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
        public latoSensu(string nome, int cargahoraria)
        {
            Nome = nome;
            CargaHoraria = cargahoraria;
        }
        public string AreaDeAtuacao { get; set; }
    }
}
