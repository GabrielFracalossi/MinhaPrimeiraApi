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
        public IActionResult Get()
        {
            var produtos = produtoService.ObterTodos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produto = produtoService.ObterPorId(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            produtoService.Adicionar(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }
    }
}