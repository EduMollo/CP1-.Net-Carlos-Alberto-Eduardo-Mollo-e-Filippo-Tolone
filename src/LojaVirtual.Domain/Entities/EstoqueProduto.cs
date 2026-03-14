namespace LojaVirtual.Domain.Entities;

/// Entidade associativa para o relacionamento N:N entre Estoque e Produto.

public class EstoqueProduto
{
    public int EstoqueId { get; set; }
    public Estoque Estoque { get; set; } = null!;

    public int ProdutoId { get; set; }
    public Produto Produto { get; set; } = null!;
}
