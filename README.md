![CR-2](https://github.com/user-attachments/assets/77a4d99a-9524-4322-9482-3f6833d9b2a0)


## 🥁 CarnaCode 2026 - Desafio 02 - Builder

Oi, eu sou o **Leonardo Malavolti Monteiro** 👋 e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Builder** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)

* O objetivo foi resolver um problema comum em sistemas corporativos:

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

## Problema
Sistema precisa gerar diferentes tipos de relatórios (PDF, Excel, HTML) com múltiplas configurações opcionais (cabeçalho, rodapé, gráficos, tabelas, filtros).
O código atual usa construtores enormes ou muitos setters, tornando difícil criar relatórios

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

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na idetinficação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
