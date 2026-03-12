using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;
using MinhaPrimeiraApi.Services;

namespace MinhaPrimeiraApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController(IProdutoService produtoService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await produtoService.ObterTodosAsync();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var produto = await produtoService.ObterPorIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            await produtoService.AdicionarAsync(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }
    }
}