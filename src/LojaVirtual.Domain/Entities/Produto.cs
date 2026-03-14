using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Produto : BaseEntity
{
    private const int MinLength = 2;
    private const int MaxLength = 100;

    public string NomeProd { get; private set; }

    public decimal PrecoProd { get; private set; }

    // N:1
    public Guid ClienteId { get; private set; }

    // N:N
    public List<EstoqueProduto> EstoqueProdutos { get; set; }

    // N:N
    public List<CategoriaProduto> CategoriaProdutos { get; set; }

    public Produto(string nomeProd, decimal precoProd, Guid clienteId)
    {
        AtualizarNome(nomeProd);
        AtualizarPreco(precoProd);
        ClienteId = clienteId;
    }

    public void AtualizarNome(string nomeProd)
    {
        if (string.IsNullOrWhiteSpace(nomeProd))
            throw new Exception("Nome do produto é obrigatório");

        NomeProd = nomeProd.Length switch
        {
            < MinLength => throw new Exception("Nome do produto deve ter no mínimo 2 caracteres"),
            > MaxLength => throw new Exception("Nome do produto deve ter no máximo 100 caracteres"),
            _ => nomeProd.Trim()
        };
    }

    public void AtualizarPreco(decimal precoProd)
    {
        if (precoProd < 0)
            throw new Exception("Preço do produto não pode ser negativo");

        PrecoProd = precoProd;
    }

    public override string ToString()
    {
        return $"Produto {NomeProd} - R$ {PrecoProd:F2}";
    }
}
