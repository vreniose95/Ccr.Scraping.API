namespace Ccr.Scraping.API.Infrastructure
{
  public interface INamedAnchorFragment
    : IUriFragment
  {
    string AnchorValue { get; }
  }
}
