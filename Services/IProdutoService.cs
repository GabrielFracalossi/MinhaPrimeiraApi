using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Services
{
    public interface IProdutoService
    {
        IEnumerable<Produto> ObterTodos();
        Produto? ObterPorId(int id);
        void Adicionar(Produto produto);
    }
}