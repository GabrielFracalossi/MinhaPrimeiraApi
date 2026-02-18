using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Services
{
    public class ProdutoService : IProdutoService
    {
        private static readonly List<Produto> Produtos = new()
        {
          new Produto { Id = 1, Nome = "Teclado", Preco = 150 },
          new Produto { Id = 2, Nome = "Mouse", Preco = 80 }
        };

        public IEnumerable<Produto> ObterTodos()
        {
            return Produtos;
        }

        public Produto? ObterPorId(int id)
        {
            return Produtos.FirstOrDefault(p => p.Id == id);
        }

        public void Adicionar(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}