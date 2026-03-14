using LojaVirtual.Domain.Commons;

namespace LojaVirtual.Domain.Entities;

public class Loja : BaseEntity
{
    public string NomeLoja { get; private set; }

    public string CnpjLoja { get; private set; }

    // 1:N
    public List<Estoque> Estoques { get; set; }

    public Loja(string nomeLoja, string cnpjLoja)
    {
        if (string.IsNullOrWhiteSpace(nomeLoja))
            throw new Exception("Nome da loja é obrigatório");

        if (string.IsNullOrWhiteSpace(cnpjLoja))
            throw new Exception("CNPJ da loja é obrigatório");

        if (cnpjLoja.Length != 14)
            throw new Exception("CNPJ deve conter 14 dígitos");

        NomeLoja = nomeLoja;
        CnpjLoja = cnpjLoja;
    }

    public void Desativar()
    {
        Active = false;
    }

    public override string ToString()
    {
        return $"Loja {NomeLoja} - CNPJ: {CnpjLoja}";
    }
}
