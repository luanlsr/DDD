using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using DDD.CrossCutting.DTOs;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _service.ObterTodosProdutosAsync();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var produto = await _service.ObterProdutoPorIdAsync(id);
            if (produto == null) return NotFound("Produto não encontrado.");
            return Ok(produto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ProdutoRequestDTO request)
        {
            await _service.AdicionarProdutoAsync(request.Nome, request.Preco);
            return Ok("Produto adicionado com sucesso!");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ProdutoRequestDTO request)
        {
            try
            {
                await _service.AtualizarProdutoAsync(id, request.Nome, request.Preco);
                return Ok("Produto atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.DeletarProdutoAsync(id);
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
