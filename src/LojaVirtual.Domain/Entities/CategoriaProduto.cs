namespace LojaVirtual.Domain.Entities;

/// Entidade associativa para o relacionamento N:N entre Categoria e Produto.

public class CategoriaProduto
{
    public int CategoriaId { get; set; }
    public Categoria Categoria { get; set; } = null!;

    public int ProdutoId { get; set; }
    public Produto Produto { get; set; } = null!;
}
