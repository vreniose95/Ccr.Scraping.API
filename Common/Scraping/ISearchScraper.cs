using System.Collections.Generic;

namespace Ccr.Scraping.API.Common.Scraping
{
  public interface ISearchScraper
  {
    IEnumerable<TEntity> Scrape<TEntity>(
      string htmlContent);
  }
}
