
namespace Interface_logica_pagar;

internal class Produto
{
    public Produto(string nomeDoProduto, int quantidadeDoProduto, decimal valorDoProduto)
    {
        NomeDoProduto = nomeDoProduto;
        QuantidadeDoProduto = quantidadeDoProduto;
        ValorDoProduto = valorDoProduto;
    }

    public string NomeDoProduto { get; set; }
    public int QuantidadeDoProduto { get; set; }
    public decimal ValorDoProduto { get; set; }
}
