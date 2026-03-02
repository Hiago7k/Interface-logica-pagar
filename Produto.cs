
namespace Interface_logica_pagar;

internal class Produto
{
    public Produto(string nomeDoProduto, int quantidadeDoProduto, int valorDoProduto)
    {
        NomeDoProduto = nomeDoProduto;
        QuantidadeDoProduto = quantidadeDoProduto;
        ValorDoProduto = valorDoProduto;
        ValorTotal = quantidadeDoProduto += ValorDoProduto;
    }

    public string NomeDoProduto { get; set; }
    public int QuantidadeDoProduto { get; set; }
    public int ValorDoProduto { get; set; }
    public int ValorTotal { get; set; }


    public void CalcularPagamento()
    {
        Console.WriteLine(ValorTotal);
    }
}
