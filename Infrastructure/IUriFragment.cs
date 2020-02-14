namespace Ccr.Scraping.API.Infrastructure
{
  public interface IUriFragment
  {
    string GetFragment(bool start, bool end);
  }
}
