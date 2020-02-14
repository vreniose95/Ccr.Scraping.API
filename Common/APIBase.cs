using System.Collections.Generic;
using Ccr.Scraping.API.Common.Query;
using Ccr.Scraping.API.Infrastructure;

namespace Ccr.Scraping.API.Common
{
  public abstract class APIBase<TResult, TQueryBuilder>
    where TQueryBuilder
      : IQueryBuilder
  {
    protected abstract DomainFragment RequestBuilder { get; }


    public abstract IEnumerable<TResult> Query(
      TQueryBuilder queryBuilder);
  }
}
