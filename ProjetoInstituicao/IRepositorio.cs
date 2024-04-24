using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInstituicao
{
    public interface IRepositorio<T>
    {
        T ObterPorNome(string nome);
        IEnumerable<T> ObterTodos();
        void Gravar(T objeto);
        void Remover(T objeto);

    }
}
