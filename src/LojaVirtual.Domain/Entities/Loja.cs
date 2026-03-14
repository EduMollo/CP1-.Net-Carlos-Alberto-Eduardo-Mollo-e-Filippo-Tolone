using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Loja : BaseEntity
{
    public string NomeLoja { get; set; }

    public string CnpjLoja { get; set; }

    // 1:N
    public List<Estoque> Estoques { get; set; }
}
