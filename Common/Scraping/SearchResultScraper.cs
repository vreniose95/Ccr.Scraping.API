using AngleSharp.Dom;

namespace Ccr.Scraping.API.Common.Scraping
{
  public abstract class SearchResultScraper<TEntity>
    : ISearchResultScraper<TEntity>
  {
    public abstract TEntity Scrape(
      IElement htmlNode);
  }
}
