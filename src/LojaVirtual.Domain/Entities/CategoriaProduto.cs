using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class CategoriaProduto : BaseEntity
{
    public Guid CategoriaId { get; private set; }

    public Guid ProdutoId { get; private set; }

    public CategoriaProduto(Guid categoriaId, Guid produtoId)
    {
        CategoriaId = categoriaId;
        ProdutoId = produtoId;
    }
}
