using DesignPatternChallenge.Domain.Builders;

Console.WriteLine("=== Sistema de Relatórios com Builder Pattern ===");


var reportVendaMensais = new SalesReportBuilder(
        "Vendas Mensais",
        "PDF",
        new DateTime(2024, 1, 1),
        new DateTime(2024, 1, 31))
    .WithHeader("Relatório de Vendas")
    .WithFooter("Confidencial")
    .AddColumn("Produto")
    .AddColumn("Quantidade")
    .AddColumn("Valor")
    .AddFilter("Status=Ativo")
    .WithChart("Bar")
    .GroupBy("Categoria")
    .SortBy("Valor")
    .WithTotals()
    .WithOrientation("Portrait")
    .WithPageSize("A4")
    .Build();

reportVendaMensais.Generate();

Console.WriteLine("------------------------------------------------------");

var reportTrimestral = new SalesReportBuilder(
        "Relatório Trimestral",
        "Excel",
        new DateTime(2024, 1, 1),
        new DateTime(2024, 3, 31))
    .AddColumn("Vendedor")
    .AddColumn("Região")
    .AddColumn("Total")
    .WithChart("Line")
    .WithHeader("Relatório Trimestral de Vendas")
    .GroupBy("Região")
    .WithTotals()
    .Build();

reportTrimestral.Generate();

Console.WriteLine("------------------------------------------------------");

var reportVendasAnuais = new SalesReportBuilder(
        "Vendas Anuais",
        "PDF",
        new DateTime(2024, 1, 1),
        new DateTime(2024, 12, 31))
    .WithHeader("Relatório de Vendas")
    .WithFooter("Confidencial")
    .AddColumn("Produto")
    .AddColumn("Quantidade")
    .AddColumn("Valor")
    .WithChart("Pie")
    .WithTotals()
    .WithOrientation("Landscape")
    .WithPageSize("A4")
    .Build();

reportVendasAnuais.Generate();

Console.ReadKey();