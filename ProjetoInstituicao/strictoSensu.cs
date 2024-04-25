using ProjetoInstituicaoDeEnsino;

namespace ProjetoInstituicao
{
    public class StrictoSensu : PosGraduacao
    {
        public StrictoSensu(string nome)
        {
            Nome = nome;
        }
        public IList<string> LinhasDePesquisa { get; } = new List<string>();
    }
}
