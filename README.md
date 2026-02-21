![CR-2](https://github.com/user-attachments/assets/77a4d99a-9524-4322-9482-3f6833d9b2a0)

# 🥁 CarnaCode 2026 - Desafio 02 - Builder Pattern

Olá! Eu sou **Leonardo Malavolti Monteiro** 👋
Este projeto faz parte da minha jornada no **CarnaCode 2026**, promovido
pelo balta.io.

## 📌 Sobre o Desafio

O objetivo foi resolver um problema comum em sistemas corporativos:

Um sistema precisava gerar relatórios (PDF, Excel, HTML) com diversas
configurações opcionais, como:

-   Cabeçalho e rodapé
-   Gráficos
-   Filtros
-   Agrupamentos
-   Totais
-   Paginação

A implementação inicial utilizava:

-   ❌ Construtores com muitos parâmetros (construtor telescópico)
-   ❌ Muitos setters, gerando risco de inconsistência

## 🛠️ Solução Aplicada

Implementei o **Builder Pattern** para:

-   ✅ Garantir propriedades obrigatórias no momento da criação
-   ✅ Permitir configuração fluente
-   ✅ Melhorar a legibilidade
-   ✅ Reduzir riscos de estados inválidos
-   ✅ Centralizar validações no método Build()

### Exemplo de uso

``` csharp
var report = new SalesReportBuilder(
        "Vendas Mensais",
        "PDF",
        new DateTime(2024, 1, 1),
        new DateTime(2024, 1, 31))
    .WithHeader("Relatório de Vendas")
    .WithFooter("Confidencial")
    .AddColumn("Produto")
    .AddColumn("Quantidade")
    .AddColumn("Valor")
    .WithChart("Bar")
    .GroupBy("Categoria")
    .WithTotals()
    .Build();

report.Generate();
```

## 📚 Aprendizados

Durante esse desafio aprimorei:

-   Conceitos de Design Patterns
-   Aplicação prática do Builder Pattern
-   Organização e arquitetura de código
-   Boas práticas (Clean Code e SOLID)

## 🎭 Sobre o CarnaCode 2026

O CarnaCode 2026 consiste na implementação prática dos 23 Design
Patterns em cenários reais, com foco em escalabilidade e arquitetura.

------------------------------------------------------------------------

🚀 Seguimos evoluindo!
