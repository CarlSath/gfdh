using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using MetaShare.Common.Core.Services;
using Products.Entities;
/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services.Interfaces
{
	public interface ICatalogService : IPagingService<Catalog>
	{
	        List<Catalog> SelectCatalogByParents(int[] parentIds, bool isAggregatedChildren = false);
	        List<Catalog> SelectCatalogByParents(Pager pager,int[] parentIds, bool isAggregatedChildren = false);
	        List<Catalog> SelectByParent(int pageIndex,int pageSize,int parentId);
	        List<Catalog> SelectByParent(int parentId);
	/*add customized code between this region*/
	/*add customized code between this region*/
	}
}
