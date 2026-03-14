namespace LojaVirtual.Domain.Entities;

public class Produto
{
    public int IdProd { get; set; }
    public string NomeProd { get; set; } = string.Empty;
    public decimal PrecoProd { get; set; }

    // Relacionamento N:1 — Cada produto é comprado por um cliente (obrigatório)
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } = null!;

    // Relacionamento N:N — Um produto está em muitos estoques
    public ICollection<EstoqueProduto> EstoqueProdutos { get; set; } = new List<EstoqueProduto>();

    // Relacionamento N:N — Um produto pertence a muitas categorias (opcional)
    public ICollection<CategoriaProduto> CategoriaProdutos { get; set; } = new List<CategoriaProduto>();
}
