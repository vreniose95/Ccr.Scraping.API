namespace Ccr.Scraping.API.Common.Materializers
{
	public abstract class DomainEntityMaterializer<TEntity, TData> 
		: IDomainEntityMaterializer
  {
    object IDomainEntityMaterializer.MaterializeBase(
      object data)
    {
      return Materialize((TData) data);
    }

    public abstract TEntity Materialize(
      TData data);
  }
}
