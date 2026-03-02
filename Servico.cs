namespace Interface_logica_pagar;

internal class Servico : IPagavel
{
    public Servico(string nomeDoServico, decimal valorDoServico, decimal quantidadedehoras)
    {
        NomeDoServico = nomeDoServico;
        ValorDoServico = valorDoServico;
        QuantidadeDeHoras = quantidadedehoras;

        // ValorTotal = ValorDoServico += PrecoDasHoras;
        PrecoDasHoras = 60;
        
        ValorTotal = PrecoDasHoras *  QuantidadeDeHoras;
    }

    public string NomeDoServico { get; set; }

    public decimal ValorDoServico { get; set; }

    public decimal PrecoDasHoras { get; set; }
    public decimal QuantidadeDeHoras { get; set; }
    public decimal ValorTotal { get; set; }

    public void CalcularPagamento()
    {
        Console.WriteLine($"O valor total do seu servico foi de {ValorTotal}");
        Console.WriteLine($"Onde esta incluso as horas do cabeleleiro {PrecoDasHoras}");
        Console.WriteLine($"E o valor do servico {ValorTotal}");
    }
}
