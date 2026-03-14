using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Cliente : BaseEntity
{
    public string NomeCliente { get; set; }

    public string? TelefoneCliente { get; set; }

    public string CpfCliente { get; set; }

    // 1:N
    public List<Produto> Produtos { get; set; }
}
