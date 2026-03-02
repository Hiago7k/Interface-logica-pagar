namespace Interface_logica_pagar;

internal class Servico
{
    public Servico(string nomeDoServico, decimal valorDoServico, int taxaDeServico)
    {
        NomeDoServico = nomeDoServico;
        ValorDoServico = valorDoServico;
        TaxaDeServico = taxaDeServico;
    }

    public string NomeDoServico { get; set; }

    public decimal ValorDoServico { get; set; }

    public int TaxaDeServico { get; set; }
   // public int QuantidadeDeHoras { get; set; }
}
