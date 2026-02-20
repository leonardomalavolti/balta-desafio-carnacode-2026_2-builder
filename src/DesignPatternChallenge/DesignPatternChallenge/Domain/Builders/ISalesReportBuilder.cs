using DesignPatternChallenge.Domain.Entities;

namespace DesignPatternChallenge.Domain.Builders;

public interface ISalesReportBuilder
{
    ISalesReportBuilder WithHeader(string headerText);
    ISalesReportBuilder WithFooter(string footerText);
    ISalesReportBuilder AddColumn(string column);
    ISalesReportBuilder AddFilter(string filter);
    ISalesReportBuilder WithChart(string chartType);
    ISalesReportBuilder GroupBy(string groupBy);
    ISalesReportBuilder SortBy(string sortBy);
    ISalesReportBuilder WithTotals();
    ISalesReportBuilder WithOrientation(string orientation);
    ISalesReportBuilder WithPageSize(string pageSize);

    SalesReport Build();
}