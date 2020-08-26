using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services.Interfaces
{
	public interface IEnterpriseService : IPagingService<Enterprise>
	{
	        List<Enterprise> SelectAllWithReferenceData(List<Enterprise> items);
	        List<Enterprise> SelectEnterpriseByProductCatalogs(int[] productCatalogIds, bool isAggregatedChildren = false);
	        List<Enterprise> SelectEnterpriseByProductCatalogs(Pager pager,int[] productCatalogIds, bool isAggregatedChildren = false);
	        List<Enterprise> SelectByProductCatalog(int pageIndex,int pageSize,int productCatalogId);
	        List<Enterprise> SelectByProductCatalog(int productCatalogId);
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
