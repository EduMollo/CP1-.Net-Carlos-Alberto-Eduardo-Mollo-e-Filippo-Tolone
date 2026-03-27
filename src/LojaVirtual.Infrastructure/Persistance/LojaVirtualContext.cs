
using Microsoft.EntityFrameworkCore;
using LojaVirtual.Domain.Entities;
using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Infrastructure.Persistance
{
    public class LojaVirtualContext : DbContext
    {
        public LojaVirtualContext(DbContextOptions<LojaVirtualContext> options) 
            : base(options) 
        { }

       
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<EstoqueProduto> EstoqueProdutos { get; set; }
        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
          
            modelBuilder.Entity<EstoqueProduto>()
                .HasKey(ep => new { ep.EstoqueId, ep.ProdutoId });
                
            modelBuilder.Entity<CategoriaProduto>()
                .HasKey(cp => new { cp.CategoriaId, cp.ProdutoId });
        }
    }
}