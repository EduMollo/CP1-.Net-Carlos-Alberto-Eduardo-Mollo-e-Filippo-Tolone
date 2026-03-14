namespace LojaVirtual.Domain.Entities;

public class Categoria
{
    public int IdCategoria { get; set; }
    public string NomeCategoria { get; set; } = string.Empty;
    public string? DescCategoria { get; set; }

    // Relacionamento N:N — Uma categoria contém muitos produtos
    
    public ICollection<CategoriaProduto> CategoriaProdutos { get; set; } = new List<CategoriaProduto>();
}
