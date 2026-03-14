using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Categoria : BaseEntity
{
    public string NomeCategoria { get; private set; }

    public string? DescCategoria { get; private set; }

    // N:N
    public List<CategoriaProduto> CategoriaProdutos { get; set; }

    public Categoria(string nomeCategoria, string? descCategoria = null)
    {
        if (string.IsNullOrWhiteSpace(nomeCategoria))
            throw new Exception("Nome da categoria é obrigatório");

        NomeCategoria = nomeCategoria;
        DescCategoria = descCategoria;
    }

    public override string ToString()
    {
        return $"Categoria {NomeCategoria}";
    }
}
