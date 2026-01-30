using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private static readonly List<Produto> Produtos = new()
        {
            new Produto { Id = 1, Nome = "Teclado", Preco = 150 },
            new Produto { Id = 2, Nome = "Mouse", Preco = 80 }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Produtos);
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            Produtos.Add(produto);
            return CreatedAtAction(nameof(Get), produto);
        }
    }
}
