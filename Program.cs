using Interface_logica_pagar;

Produto produto1 = new Produto("Shampoo", 100, 20);
Console.WriteLine($"Comprando: {produto1.NomeDoProduto}");
Console.WriteLine($"Quantidade adicionada ao carrinho: {produto1.QuantidadeDoProduto}");
Console.WriteLine($"Valor: {produto1.ValorDoProduto}");
produto1.CalcularPagamento();

Console.WriteLine();

Servico servico1 = new Servico("Lavagem de cabelo", 100, 3);

servico1.CalcularPagamento();