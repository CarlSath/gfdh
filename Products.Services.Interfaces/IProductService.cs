using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services.Interfaces
{
	public interface IProductService : IPagingService<Product>
	{
	        List<Product> SelectAllWithReferenceData(List<Product> items);
	        List<Product> SelectProductByCatalogs(int[] catalogIds, bool isAggregatedChildren = false);
	        List<Product> SelectProductByCatalogs(Pager pager,int[] catalogIds, bool isAggregatedChildren = false);
	        List<Product> SelectProductByOwners(int[] ownerIds, bool isAggregatedChildren = false);
	        List<Product> SelectProductByOwners(Pager pager,int[] ownerIds, bool isAggregatedChildren = false);
	        List<Product> SelectByCatalog(int pageIndex,int pageSize,int catalogId);
	        List<Product> SelectByCatalog(int catalogId);
	        List<Product> SelectByCatalogOwner(int pageIndex,int pageSize,int catalogId,int ownerId);
	        List<Product> SelectByCatalogOwner(int catalogId,int ownerId);
	        List<Product> SelectByOwner(int pageIndex,int pageSize,int ownerId);
	        List<Product> SelectByOwner(int ownerId);
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
