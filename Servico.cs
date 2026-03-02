namespace Interface_logica_pagar;

internal class Servico : IPagavel
{
    public Servico(string nomeDoServico, int valorDoServico, int taxaDeServico)
    {
        NomeDoServico = nomeDoServico;
        ValorDoServico = valorDoServico;
        TaxaDeServico = taxaDeServico;
        ValorTotal = ValorDoServico += TaxaDeServico;
    }

    public string NomeDoServico { get; set; }

    public int ValorDoServico { get; set; }

    public int TaxaDeServico { get; set; }

    public int ValorTotal { get; set; }
    // public int QuantidadeDeHoras { get; set; }

    public void CalcularPagamento()
    {
        Console.WriteLine(ValorTotal);
    }
}
