using Interface_logica_pagar;

Produto produto1 = new Produto("Shampoo", 100, 20);
Console.WriteLine($"Produto: {produto1.NomeDoProduto}");
Console.WriteLine($"Quantidade disponivel: {produto1.QuantidadeDoProduto}");
Console.WriteLine($"Valor: {produto1.ValorDoProduto}");

Console.WriteLine();

Servico servico1 = new Servico("Lavagem de Cabelo", 200, 30);
Console.WriteLine($"Servico {servico1.NomeDoServico}");
Console.WriteLine($"Valor do Servico {servico1.ValorDoServico}");
Console.WriteLine($"Taxa da cabeleleira {servico1.TaxaDeServico}");