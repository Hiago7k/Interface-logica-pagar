
namespace Interface_logica_pagar;

internal class Produto : IPagavel
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
        Console.WriteLine($"Os produtos que voce comprou foi {NomeDoProduto}");
        Console.WriteLine($"A quantidade de produtos que voce comprou foi de {QuantidadeDoProduto}");
        Console.WriteLine($"Com isso a sua conta final ficou no valor de {ValorTotal}");
    }
}
