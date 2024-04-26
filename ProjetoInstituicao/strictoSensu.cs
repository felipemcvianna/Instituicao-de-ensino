using ProjetoInstituicaoDeEnsino;

namespace ProjetoInstituicao
{
    public class StrictoSensu : PosGraduacao
    {
        public StrictoSensu(string nome, int cargahoraria)
        {
            Nome = nome;
            CargaHoraria = cargahoraria;
        }
        public IList<string> LinhasDePesquisa { get; } = new List<string>();
    }
}
