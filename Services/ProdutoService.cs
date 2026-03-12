using Microsoft.EntityFrameworkCore;
using MinhaPrimeiraApi.Data;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Services
{
    public class ProdutoService(ApplicationDbContext context) : IProdutoService
    {
        public async Task<IEnumerable<Produto>> ObterTodosAsync()
        {
            return await context.Produtos.ToListAsync();
        }

        public async Task<Produto?> ObterPorIdAsync(int id)
        {
            return await context.Produtos.FindAsync(id);
        }

        public async Task AdicionarAsync(Produto produto)
        {
            context.Produtos.Add(produto);
            await context.SaveChangesAsync();
        }
    }
}