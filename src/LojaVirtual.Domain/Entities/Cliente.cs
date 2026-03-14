using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Cliente : BaseEntity
{
    public string NomeCliente { get; private set; }

    public string? TelefoneCliente { get; private set; }

    public string CpfCliente { get; private set; }

    // 1:N
    public List<Produto> Produtos { get; set; }

    public Cliente(string nomeCliente, string cpfCliente, string? telefoneCliente = null)
    {
        if (string.IsNullOrWhiteSpace(nomeCliente))
            throw new Exception("Nome do cliente é obrigatório");

        if (string.IsNullOrWhiteSpace(cpfCliente))
            throw new Exception("CPF do cliente é obrigatório");

        if (cpfCliente.Length != 11)
            throw new Exception("CPF deve conter 11 dígitos");

        NomeCliente = nomeCliente;
        CpfCliente = cpfCliente;
        TelefoneCliente = telefoneCliente;
    }

    public void Desativar()
    {
        Active = false;
    }

    public override string ToString()
    {
        return $"Cliente {NomeCliente} - CPF: {CpfCliente}";
    }
}
