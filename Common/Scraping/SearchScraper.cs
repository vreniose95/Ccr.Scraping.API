using System.Collections.Generic;

namespace Ccr.Scraping.API.Common.Scraping
{
  public abstract class SearchScraper
    : ISearchScraper
  {
    public abstract IEnumerable<TEntity> Scrape<TEntity>(
      string htmlContent);
  }
}
