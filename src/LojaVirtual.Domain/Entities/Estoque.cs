using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Estoque : BaseEntity
{
    public int QntdEstoq { get; private set; }

    public DateTime? ValidadeEstoq { get; private set; }

    // N:1
    public Guid LojaId { get; private set; }

    // N:N
    public List<EstoqueProduto> EstoqueProdutos { get; set; }

    public Estoque(Guid lojaId, int qntdEstoq, DateTime? validadeEstoq = null)
    {
        if (qntdEstoq < 0)
            throw new Exception("Quantidade em estoque não pode ser negativa");

        LojaId = lojaId;
        QntdEstoq = qntdEstoq;
        ValidadeEstoq = validadeEstoq;
    }

    public void AtualizarQuantidade(int novaQuantidade)
    {
        if (novaQuantidade < 0)
            throw new Exception("Quantidade em estoque não pode ser negativa");

        QntdEstoq = novaQuantidade;
    }

    public override string ToString()
    {
        return $"Estoque - Qtd: {QntdEstoq} - Validade: {ValidadeEstoq?.ToString("dd/MM/yyyy") ?? "N/A"}";
    }
}
