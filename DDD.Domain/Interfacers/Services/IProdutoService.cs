namespace Application.Interfaces
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> ObterTodosProdutosAsync();
        Task<Produto> ObterProdutoPorIdAsync(int id);
        Task AdicionarProdutoAsync(string nome, decimal preco);
        Task AtualizarProdutoAsync(int id, string nome, decimal preco);
        Task DeletarProdutoAsync(int id);
    }
}
