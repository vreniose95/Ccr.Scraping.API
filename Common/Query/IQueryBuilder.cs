using Ccr.Scraping.API.Infrastructure;

namespace Ccr.Scraping.API.Common.Query
{
  public interface IQueryBuilder
  {
    string BuildRequestUrl(DomainFragment requestBuilder);
  }
}