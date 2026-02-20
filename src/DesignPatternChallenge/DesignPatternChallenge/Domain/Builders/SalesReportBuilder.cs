using DesignPatternChallenge.Domain.Entities;

namespace DesignPatternChallenge.Domain.Builders;

public class SalesReportBuilder : ISalesReportBuilder
{
    private readonly SalesReport _report;

    public SalesReportBuilder(string title, string format, DateTime startDate, DateTime endDate)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Título é obrigatório.");

        if (string.IsNullOrWhiteSpace(format))
            throw new ArgumentException("Formato é obrigatório.");

        _report = new SalesReport
        {
            Title = title,
            Format = format,
            StartDate = startDate,
            EndDate = endDate
        };
    }

    public ISalesReportBuilder WithHeader(string headerText)
    {
        _report.IncludeHeader = true;
        _report.HeaderText = headerText;
        return this;
    }

    public ISalesReportBuilder WithFooter(string footerText)
    {
        _report.IncludeFooter = true;
        _report.FooterText = footerText;
        return this;
    }

    public ISalesReportBuilder AddColumn(string column)
    {
        _report.Columns.Add(column);
        return this;
    }

    public ISalesReportBuilder AddFilter(string filter)
    {
        _report.Filters.Add(filter);
        return this;
    }

    public ISalesReportBuilder WithChart(string chartType)
    {
        _report.IncludeCharts = true;
        _report.ChartType = chartType;
        return this;
    }

    public ISalesReportBuilder GroupBy(string groupBy)
    {
        _report.GroupBy = groupBy;
        return this;
    }

    public ISalesReportBuilder SortBy(string sortBy)
    {
        _report.SortBy = sortBy;
        return this;
    }

    public ISalesReportBuilder WithTotals()
    {
        _report.IncludeTotals = true;
        return this;
    }

    public ISalesReportBuilder WithOrientation(string orientation)
    {
        _report.Orientation = orientation;
        return this;
    }

    public ISalesReportBuilder WithPageSize(string pageSize)
    {
        _report.PageSize = pageSize;
        return this;
    }

    public SalesReport Build()
    {
        if (_report.Columns.Count == 0)
            throw new InvalidOperationException("O relatório deve conter ao menos uma coluna.");

        return _report;
    }
}