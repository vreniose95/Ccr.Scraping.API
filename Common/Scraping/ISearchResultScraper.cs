using AngleSharp.Dom;

namespace Ccr.Scraping.API.Common.Scraping
{
  public interface ISearchResultScraper<out TValue>
  {
    TValue Scrape(IElement htmlNode);
  }
}
