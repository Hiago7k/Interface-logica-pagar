
namespace Interface_logica_pagar;

internal class Produto
{
    public Produto(string nomeDoProduto, int quantidadeDoProduto, int valorDoProduto)
    {
        NomeDoProduto = nomeDoProduto;
        QuantidadeDoProduto = quantidadeDoProduto;
        ValorDoProduto = valorDoProduto;
    }

    public string NomeDoProduto { get; set; }
    public int QuantidadeDoProduto { get; set; }
    public int ValorDoProduto { get; set; }


    public void CalcularPagamento()
    {
      int valorTotal = QuantidadeDoProduto += ValorDoProduto;
        Console.WriteLine($"O valor total e de {valorTotal}"); 
    }
}
