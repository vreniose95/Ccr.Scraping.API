namespace Ccr.Scraping.API.Common.Materializers
{
	public interface IDomainEntityMaterializer
	{
		object MaterializeBase(object data);
	}
}