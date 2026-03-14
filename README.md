# LojaVirtual — CP1 Modelo Entidade-Relacionamento & WebAPI

## Integrantes do Grupo

| Nome | RM |
|------------------------------|--------------|
| (Carlos Alberto Guedes Neto) | (RM: 566022) |
| (Eduardo Novaes Mollo)       | (RM: 561515) |
| (Filippo Dal Medico Tolone)  | (RM: 562329) |

## Domínio Escolhido

**Loja Virtual** — Sistema de gerenciamento de uma loja virtual, abrangendo lojas, estoques, produtos, categorias e clientes.

## Entidades Modeladas

| Entidade      | PK | Atributos |
|---------------|----------------------|-------------------------------------------------------------------------------|
| **Loja**      | `Id` (Guid)          | `NomeLoja` (string), `CnpjLoja` (string)                                      |
| **Estoque**   | `Id` (Guid)          | `QntdEstoq` (int), `ValidadeEstoq` (DateTime?)                                |
| **Produto**   | `Id` (Guid)          | `NomeProd` (string), `PrecoProd` (decimal)                                     |
| **Categoria** | `Id` (Guid)          | `NomeCategoria` (string), `DescCategoria` (string?)                            |
| **Cliente**   | `Id` (Guid)          | `NomeCliente` (string), `TelefoneCliente` (string?), `CpfCliente` (string)    |

Além das 5 entidades principais, foram criadas 2 **entidades associativas** para os relacionamentos N:N:
- **EstoqueProduto** (Estoque ↔ Produto)
- **CategoriaProduto** (Categoria ↔ Produto)

## Relacionamentos

| Relacionamento | Cardinalidade | Opcionalidade | Descrição |
|---------------|---------------|---------------|-----------|
| Loja **possui** Estoque  |  1:N  |  Loja (obrigatório, 1,n) · Estoque (obrigatório, 1,1)  |  Uma loja possui um ou mais estoques; cada estoque pertence a exatamente uma loja. |
| Estoque **tem** Produto  |  N:N  |  Estoque (obrigatório, 1,n) · Produto (obrigatório, 1,n)  |  Um estoque contém vários produtos e um produto pode estar em vários estoques. |
| Categoria **pertence** Produto  |  N:N  |  Categoria (obrigatório, 1,n) · Produto (opcional, 0,n)  |  Uma categoria possui vários produtos; um produto pode pertencer a nenhuma ou várias categorias. |
| Produto **compra** Cliente  |  N:1  |  Produto (obrigatório, 1,1) · Cliente (opcional, 0,n)  |  Cada produto é comprado por exatamente um cliente; um cliente pode comprar nenhum ou vários produtos. |

## Diagrama MER

O diagrama MER está disponível em [`docs/mer.jpeg`](docs/mer.jpeg).

## Estrutura do Projeto (Clean Architecture)

```
LojaVirtual.sln
├── src/
│   ├── LojaVirtual.Domain/            → Camada de domínio (entidades)
│   │   ├── Commons/
│   │   │   └── BaseEntity.cs           → Classe base (Id, CreatedAt, Active)
│   │   └── Entities/
│   │       ├── Loja.cs
│   │       ├── Estoque.cs
│   │       ├── Produto.cs
│   │       ├── Categoria.cs
│   │       ├── Cliente.cs
│   │       ├── EstoqueProduto.cs       → Associativa (N:N)
│   │       └── CategoriaProduto.cs     → Associativa (N:N)
│   ├── LojaVirtual.Application/       → Camada de aplicação (casos de uso)
│   ├── LojaVirtual.Infrastructure/    → Camada de infraestrutura (acesso a dados)
│   └── LojaVirtual.Api/              → Camada de apresentação (WebAPI)
│       └── Program.cs
├── docs/
│   └── mer.jpeg                       → Diagrama MER
└── README.md
```

## Tecnologias

- **.NET 10** (WebAPI)
- **C#**
- Arquitetura: **Clean Architecture**
