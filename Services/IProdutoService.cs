using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ObterTodosAsync();
        Task<Produto?> ObterPorIdAsync(int id);
        Task AdicionarAsync(Produto produto);
    }
}