using Application.Interfaces;
using Domain.Repositories;

namespace Application.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Produto>> ObterTodosProdutosAsync()
        {
            return await _repository.ObterTodosAsync();
        }

        public async Task<Produto> ObterProdutoPorIdAsync(int id)
        {
            return await _repository.ObterPorIdAsync(id);
        }

        public async Task AdicionarProdutoAsync(string nome, decimal preco)
        {
            var produto = new Produto(nome, preco);
            await _repository.AdicionarAsync(produto);
        }

        public async Task AtualizarProdutoAsync(int id, string nome, decimal preco)
        {
            var produtoExistente = await _repository.ObterPorIdAsync(id);
            if (produtoExistente == null)
                throw new Exception("Produto não encontrado.");

            produtoExistente.Nome = nome;
            produtoExistente.Preco = preco;

            await _repository.AtualizarAsync(produtoExistente);
        }

        public async Task DeletarProdutoAsync(int id)
        {
            var produto = await _repository.ObterPorIdAsync(id);
            if (produto == null)
                throw new Exception("Produto não encontrado.");

            await _repository.RemoverAsync(produto);
        }
    }
}
