using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ProdutoDbContext : DbContext
    {
        public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
