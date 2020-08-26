using System.Collections.Generic;
using MetaShare.Common.Core.Entities;
using Products.Entities;
using MetaShare.Common.Core.Services;
using Products.Daos.Interfaces;
using Products.Services.Interfaces;

/*add customized code between this region*/
/*add customized code between this region*/

namespace Products.Services
{
	public class CatalogService : Service<Catalog>, ICatalogService
	{
		public CatalogService() : base(typeof (ICatalogDao))
		{
		}

		public List<Catalog> SelectCatalogByParents(int[] parentIds, bool isAggregatedChildren = false)
        {
            List<Catalog> items = this.SelectByColumnIds("ParentId",parentIds,isAggregatedChildren);
            return items;
        }
		public List<Catalog> SelectCatalogByParents(Pager pager, int[] parentIds, bool isAggregatedChildren = false)
        {
            List<Catalog> items = this.SelectByColumnIds(pager,"ParentId",parentIds,isAggregatedChildren);
            return items;
        }
		public List<Catalog> SelectByParent(int pageIndex,int pageSize,int parentId)
        {
            Pager pager = new Pager { PageIndex = pageIndex, PageSize = pageSize };
            List<Catalog> items = this.SelectBy(pager,new Catalog { Parent = new Products.Entities.Catalog{ Id = parentId } },new List<string> { "ParentId" });
            return items;
        }
		public List<Catalog> SelectByParent(int parentId)
        {
            List<Catalog> items = this.SelectBy(new Catalog { Parent = new Products.Entities.Catalog{ Id = parentId } },new List<string> { "ParentId" });
            return items;
        }/*add customized code between this region*/
		/*add customized code between this region*/

	}
}
