using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Categoria : BaseEntity
{
    public string NomeCategoria { get; set; }

    public string? DescCategoria { get; set; }

    // N:N
    public List<CategoriaProduto> CategoriaProdutos { get; set; }
}
