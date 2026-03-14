namespace LojaVirtual.Domain.Entities;

public class Loja
{
    public int IdLoja { get; set; }
    public string NomeLoja { get; set; } = string.Empty;
    public string CnpjLoja { get; set; } = string.Empty;

    // Relacionamento 1:N — Uma loja possui muitos estoques
    public ICollection<Estoque> Estoques { get; set; } = new List<Estoque>();
}
