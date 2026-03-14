namespace LojaVirtual.Domain.Entities;

public class Estoque
{
    public int IdEstoq { get; set; }
    public int QntdEstoq { get; set; }
    public DateTime? ValidadeEstoq { get; set; }

    // Relacionamento N:1 — Cada estoque pertence a uma loja
    public int LojaId { get; set; }
    public Loja Loja { get; set; } = null!;

    // Relacionamento N:N — Um estoque tem muitos produtos
    public ICollection<EstoqueProduto> EstoqueProdutos { get; set; } = new List<EstoqueProduto>();
}
