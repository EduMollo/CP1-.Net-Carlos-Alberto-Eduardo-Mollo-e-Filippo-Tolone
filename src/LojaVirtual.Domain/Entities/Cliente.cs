namespace LojaVirtual.Domain.Entities;

public class Cliente
{
    public int IdCliente { get; set; }
    public string NomeCliente { get; set; } = string.Empty;
    public string? TelefoneCliente { get; set; }
    public string CpfCliente { get; set; } = string.Empty;

    // Relacionamento 1:N — Um cliente compra muitos produtos
    
    public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
