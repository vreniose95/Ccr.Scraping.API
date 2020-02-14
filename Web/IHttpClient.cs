using System.Threading.Tasks;

namespace Ccr.Scraping.API.Web
{
  public interface IHttpClient
  {
    Task<string> GetContentAsync(string address);
  }
}