namespace Ccr.Scraping.API.Infrastructure
{
  public interface IPathFragment
    : IUriFragment
  {
    string Path { get; }
  }
}