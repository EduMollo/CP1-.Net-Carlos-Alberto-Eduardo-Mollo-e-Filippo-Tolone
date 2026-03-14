using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class EstoqueProduto : BaseEntity
{
    public Guid EstoqueId { get; private set; }

    public Guid ProdutoId { get; private set; }

    public EstoqueProduto(Guid estoqueId, Guid produtoId)
    {
        EstoqueId = estoqueId;
        ProdutoId = produtoId;
    }
}
